using DomStroyB2C_MVVM.Commands;
using System.Data;
using System.Windows.Input;
using System.Windows.Threading;
using System;
using DomStroyB2C_MVVM.API.Shop.ShopService;
using DomStroyB2C_MVVM.API.Shop;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DomStroyB2C_MVVM.Views;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

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

            _shopService = new ShopService();

            openInvoiceCommand = new RelayCommand(OpenInvoice);
        }

        #endregion

        #region Private values

        private MainWindow window;

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }


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

        private DataTable tbSendShop;

        public DataTable TbSendShop
        {
            get { return tbSendShop; }
        }

        private ShopService _shopService { get; set; }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

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

                string queryToGetShop = "SELECT id, client, traded_at, card, loan_sum, cash_sum, discount_sum, loan_dollar, discount_dollar, transfer, cash_dollar " +
                                        "FROM shop WHERE status_payment = 1 AND status_server = 0";
                TbSendShop.Clear();
                ObjDbAccess.readDatathroughAdapter(queryToGetShop, tbSendShop);
                if (TbSendShop.Rows.Count > 0)
                {
                    int rec_count = TbSendShop.Rows.Count;
                    for (int i = 0; i < rec_count; i++)
                    {
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

                        bool response = await _shopService.Post(model);

                        if (response)
                        {
                            Title = "Savdo jo'natilmoqda...";
                            MySqlCommand cmd = new MySqlCommand($"UPDATE shop SET status_server = 1 WHERE id = '{TbSendShop.Rows[0]["id"]}'");
                            ObjDbAccess.executeQuery(cmd);
                            cmd.Dispose();
                        }

                        else
                        {
                            Title = "Server bilan bog'lanishda xatolik!";
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
