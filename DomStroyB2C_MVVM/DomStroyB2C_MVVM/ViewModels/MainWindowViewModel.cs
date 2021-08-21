using DomStroyB2C_MVVM.Commands;
using System.Data;
using System.Windows.Input;
using System.Windows.Threading;
using System;
using DomStroyB2C_MVVM.API.Shop.ShopService;
using DomStroyB2C_MVVM.API.Shop;
using DomStroyB2C_MVVM.API.Shop.Cart;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DomStroyB2C_MVVM.Views;
using DomStroyB2C_MVVM.API.Shop.Cart.CartService;
using DomStroyB2C_MVVM.API.Shop.CartItem.CartItemService;
using DomStroyB2C_MVVM.API.Shop.CartItem;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using DomStroyB2C_MVVM.Views.ModalViews;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Constructor


        public MainWindowViewModel(MainWindow window)
        {
            this.window = window;
            GridVisibility = false;
            UpdateViewCommand = new UpdateViewCommand(this);

            BackMainMenuCommand = new RelayCommand(BackMainMenu);
            SelectedViewModel = new LoginViewModel(this, window);

            objDbAccess = new DBAccess();
            tbSendShop = new DataTable();
            tbSendCartItem = new DataTable();

            _shopService = new ShopService();
            _cartService = new CartService();
            _cartItemService = new CartItemService();

            openInvoiceCommand = new RelayCommand(OpenInvoice);
        }

        #endregion

        #region Private values

        /// <summary>
        /// The main window view model
        /// </summary>
        private MainWindow window;

        /// <summary>
        /// The password variable enter password by user
        /// </summary>
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }

        /// <summary>
        /// The visibility of left menu
        /// </summary>
        private bool _gVisibility;
        public bool GridVisibility
        {
            get { return _gVisibility; }
            set
            {
                _gVisibility = value;
                OnPropertyChanged("GridVisibility");
            }
        }

        /// <summary>
        /// The base vieemodel to set OnPropertyChagned event to controllers
        /// </summary>
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");

            }
        }

        /// <summary>
        /// The data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// The data table for send shop
        /// </summary>
        private DataTable tbSendShop;

        public DataTable TbSendShop
        {
            get { return tbSendShop; }
        }

        /// <summary>
        /// Shop service to do crud operations
        /// </summary>
        private ShopService _shopService { get; set; }

        /// <summary>
        /// Cart service to create cart item
        /// </summary>
        private CartService _cartService { get; set; }

        /// <summary>
        /// The cart item service to store products
        /// </summary>
        private CartItemService _cartItemService { get; set; } 

        /// <summary>
        /// The title of main window that shows proccess of sending shop to server
        /// </summary>
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

        /// <summary>
        /// The data table to get cart item list
        /// </summary>
        private DataTable tbSendCartItem;

        public DataTable TbSendCartItem
        {
            get { return tbSendCartItem; }
        }

        #endregion

        #region Public Fields

        /// <summary>
        /// user_password and user_id of user
        /// </summary>
        public static string user_password = string.Empty;
        public static int user_id = 0;
        public static string user_token = string.Empty;
        public static int section = 0;

        DispatcherTimer sendShopTimer;

        public bool finish_send = true;

        #endregion

        #region Commands

        public ICommand UpdateViewCommand { get; set; }
        public ICommand BackMainMenuCommand { get; set; }

        private RelayCommand openInvoiceCommand;

        public RelayCommand OpenInvoiceCommand
        {
            get { return openInvoiceCommand; }
        }

        #endregion

        #region Helper methods to Get and Post

        public void BackMainMenu()
        {
            this.SelectedViewModel = new MainViewModel(this, window);
            GridVisibility = true;
        }

        /// <summary>
        /// The function to start send shop to remote
        /// </summary>
        public void StartSendShop()
        {
            string queryToGetSend = "SELECT password FROM send";
            using(DataTable tbSend = new DataTable())
            {
                ObjDbAccess.readDatathroughAdapter(queryToGetSend, tbSend);
                if(tbSend.Rows.Count > 0)
                {
                    string send_password = tbSend.Rows[0]["password"].ToString();
                    if(user_password == send_password)
                    {
                        sendShopTimer = new DispatcherTimer();
                        sendShopTimer.Tick += new EventHandler(SendShopAsync);
                        sendShopTimer.Interval = new TimeSpan(0, 0, 10);
                        sendShopTimer.Start();
                    }
                }
            }
        }

        /// <summary>
        /// The function to send shop to remote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SendShopAsync(object sender, EventArgs e)
        {
            if (finish_send)
            {
                finish_send = false;

                #region Sending shop

                // First we get shop from local db which has already payed
                string queryToGetShop = "SELECT id, client, traded_at, card, loan_sum, cash_sum, discount_sum, loan_dollar, discount_dollar, transfer, cash_dollar " +
                                        "FROM shop WHERE status_payment = 1 AND status_server = 0";
                TbSendShop.Clear();
                ObjDbAccess.readDatathroughAdapter(queryToGetShop, tbSendShop);
                // If that shop is exist, we send them to the server
                if (TbSendShop.Rows.Count > 0)
                {
                    // We get its count, and walk on for cycle
                    int rec_count = TbSendShop.Rows.Count;
                    string queryToGetCartList = string.Empty;

                    for (int i = 0; i < rec_count; i++)
                    {
                        try
                        {
                            // The cart model to send status of shop to server
                            string json = "{\"status\": \"processing\"}";

                            string response = await _cartService.Post(json);
                            if (response != "error")
                            {
                                var cart_response = JsonConvert.DeserializeObject<CartResponse>(response);
                                int cart_id = cart_response.id;

                                // the query to get cart list
                                queryToGetCartList = $"SELECT product, amount FROM cart WHERE shop = '{TbSendShop.Rows[i]["id"]}'";
                                TbSendCartItem.Clear();
                                ObjDbAccess.readDatathroughAdapter(queryToGetCartList, TbSendCartItem);

                                // The CartItem to get data from cart item table
                                List<Item> CartItemList = (from DataRow item in TbSendCartItem.Rows
                                                           select new Item()
                                                           {
                                                               product = Convert.ToInt32(item["product"]),
                                                               amount = Convert.ToDouble(item["amount"])

                                                           }).ToList();
                                CartItemModel cart_itemModel = new CartItemModel()
                                {
                                    cart = cart_id,
                                    items = CartItemList
                                };
                                var sa = JsonConvert.SerializeObject(cart_itemModel);
                                MessageView message = new MessageView()
                                {
                                    DataContext = new MessageViewModel("../../Images/message.Error.png", sa)
                                };
                                message.ShowDialog();
                                bool cart_item_response = await _cartItemService.Post(cart_itemModel);

                                if (cart_item_response)
                                {
                                    // The model to send server
                                    ShopModel model = new ShopModel()
                                    {
                                        _client = Convert.ToInt32(TbSendShop.Rows[i]["client"]),
                                        _traded_at = Convert.ToDateTime(TbSendShop.Rows[i]["traded_at"]),
                                        _card = Convert.ToDouble(TbSendShop.Rows[i]["card"]),
                                        _loan_sum = Convert.ToDouble(TbSendShop.Rows[i]["loan_sum"]),
                                        _cash_sum = Convert.ToDouble(TbSendShop.Rows[i]["cash_sum"]),
                                        _discount_sum = Convert.ToDouble(TbSendShop.Rows[i]["discount_sum"]),
                                        _loan_dollar = Convert.ToDouble(TbSendShop.Rows[i]["loan_dollar"]),
                                        _discount_dollar = Convert.ToDouble(TbSendShop.Rows[i]["discount_dollar"]),
                                        _transfer = Convert.ToDouble(TbSendShop.Rows[i]["transfer"]),
                                        _cash_dollar = Convert.ToDouble(TbSendShop.Rows[i]["cash_dollar"])
                                    };

                                    var json1 = JsonConvert.SerializeObject(model);
                                    MessageView message1 = new MessageView()
                                    {
                                        DataContext = new MessageViewModel("../../Images/message.Error.png", json1)
                                    };

                                    message1.ShowDialog();
                                    string shop_response = await _shopService.Post(model);

                                    if (shop_response != "error")
                                    {
                                        ShopResponse ShopResponse = JsonConvert.DeserializeObject<ShopResponse>(shop_response);

                                        CartModel cartModelFinished = new CartModel()
                                        {
                                            shop = ShopResponse.id,
                                            status = "finished"
                                        };
                                        var finalize = await _cartService.Patch(cart_id, cartModelFinished);

                                        if (finalize)
                                        {
                                            Title = "Savdo jo'natilmoqda...";
                                            MySqlCommand cmd = new MySqlCommand($"UPDATE shop SET status_server = 1 WHERE id = '{TbSendShop.Rows[0]["id"]}'");
                                            ObjDbAccess.executeQuery(cmd);
                                            cmd.Dispose();
                                        }
                                    }

                                    else
                                    {
                                        Title = "Server bilan bog'lanishda xatolik! shop create";
                                    }
                                }
                                else
                                {
                                    Title = "Server bilan bog'lanishda xatolik! cart item create";
                                }
                            }
                            else
                            {
                                Title = "Server bilan bog'lanishda xatolik! create cart";
                            }
                        }

                        catch(Exception ex)
                        {
                            Title = ex.Message;
                        }
                        
                    }
                }

                else
                {
                    Title = "Savdo jo'natilgan...";
                }

                #endregion

                finish_send = true;
            }

        }

        public void OpenInvoice()
        {
            RecieveFakturaView recieveFakturaView = new RecieveFakturaView();

            SelectedViewModel = new RecieveFakturaViewModel(this, recieveFakturaView);
        }

        #endregion

    }
}
