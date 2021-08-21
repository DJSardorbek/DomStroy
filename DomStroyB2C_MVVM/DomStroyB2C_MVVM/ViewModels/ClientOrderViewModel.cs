using System.Data;
using System.Windows.Input;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using DomStroyB2C_MVVM.Views.ModalViews;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using MySql.Data.MySqlClient;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class ClientOrderViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        private MainWindowViewModel mainWindow { get; set; }

        #region Constructor

        public ClientOrderViewModel(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
            tbClient = new DataTable();
            objDbAccess = new DBAccess();
            GetClients();
            addClientCommand = new RelayCommand(AddClient);
            takeOrderCommand = new RelayCommand(TakeClientToOrder);
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            ArrivalDate = DateTime.Now;
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// client to choose
        /// </summary>
        private clientOrderDTO client;

        public clientOrderDTO Client
        {
            get { return client; }
            set { client = value; OnPropertyChanged("Client"); }
        }

        /// <summary>
        /// List of clients
        /// </summary>
        private List<clientOrderDTO> clients;

        public List<clientOrderDTO> Clients
        {
            get { return clients; }
            set { clients = value; OnPropertyChanged("Clients"); }
        }

        /// <summary>
        /// DataTable for clients
        /// </summary>
        private DataTable tbClient;

        public DataTable TbClient
        {
            get { return tbClient; }
        }

        /// <summary>
        /// Data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// Arrival date of client
        /// </summary>
        private DateTime arrivalDate;

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; OnPropertyChanged("ArrivalDate"); }
        }

        private string arrivalTime;

        public string ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; OnPropertyChanged("ArrivalTime"); }
        }

        /// <summary>
        /// The sum of som of products
        /// </summary>
        private double sumSom;

        public double SumSom
        {
            get { return sumSom; }
            set { sumSom = value; OnPropertyChanged("SumSom"); }
        }

        /// <summary>
        /// The sum of dollar of products
        /// </summary>
        private double sumDollar;

        public double SumDollar
        {
            get { return sumDollar; }
            set { sumDollar = value; OnPropertyChanged("SumDollar"); }
        }

        /// <summary>
        /// The id of shop
        /// </summary>
        private int shop;

        public int Shop
        {
            get { return shop; }
            set { shop = value; OnPropertyChanged("Shop"); }
        }


        #endregion

        #region Commands

        /// <summary>
        /// The command to add a new client
        /// </summary>
        private RelayCommand addClientCommand;

        public RelayCommand AddClientCommand
        {
            get { return addClientCommand; }
        }

        /// <summary>
        /// The command to take client to order
        /// </summary>
        private RelayCommand takeOrderCommand;

        public RelayCommand TakeOrderCommand
        {
            get { return takeOrderCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get cart list from cart table
        /// </summary>
        public void GetClients()
        {
            string queryClient = "SELECT c.id, concat(c.first_name, ' ', c.last_name) AS full_name, c.phone_1,c.address, dc.card, dc.bonus_sum, dc.bonus_dollar " +
                                  "FROM client as c INNER JOIN discountcard as dc WHERE c.discount_card = dc.id";
            tbClient.Clear();
            ObjDbAccess.readDatathroughAdapter(queryClient, tbClient);
            ConvertClientTableToList();
        }

        /// <summary>
        /// The function to convert Client data table to list
        /// </summary>
        public void ConvertClientTableToList()
        {
            Clients = (from DataRow dr in TbClient.Rows
                       select new clientOrderDTO()
                       {
                           Id = Convert.ToInt32(dr["id"]),
                           FullName = dr["full_name"].ToString(),
                           Phone = dr["phone_1"].ToString(),
                           Address = dr["address"].ToString(),
                           Card = dr["card"].ToString(),
                           BonusSum = Convert.ToDouble(dr["bonus_sum"]),
                           BonusDollar = Convert.ToDouble(dr["bonus_dollar"])
                       }).ToList();
        }

        /// <summary>
        /// The function to open Client add view
        /// </summary>
        public void AddClient()
        {
            CliantAddView clientAddView = new CliantAddView();
            clientAddView.DataContext = new ClientAddViewModel(clientAddView);
            clientAddView.ShowDialog();

            GetClients();
        }

        public void TakeClientToOrder()
        {
            if(String.IsNullOrEmpty(ArrivalTime))
            {
                MessageView messageError = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", "Kelish vaqtini kiriting!")
                };
                messageError.ShowDialog();
                return;
            }

            // first we find shop and sum
            Shop = GetShop();
            SumSomDollar();

            // now we update shop table
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string arrivalDateTime = $"{ArrivalDate.ToString("yyyy-MM-dd")} {ArrivalTime}";
            int selectedClientId = Client.Id;
            MySqlCommand cmdShop = new MySqlCommand("UPDATE shop SET book=1, comment='" + arrivalDateTime + "', traded_at='" + currentDate + "', total_sum='" + SumSom + "', total_dollar='" + SumDollar + "', client='"+selectedClientId+"' WHERE id='" + Shop + "'");
            ObjDbAccess.executeQuery(cmdShop);
            cmdShop.Dispose();

            // now we update shopid table
            MySqlCommand cmdShopId = new MySqlCommand("UPDATE shopid SET shop=0 WHERE password='" + MainWindowViewModel.user_password + "'");
            ObjDbAccess.executeQuery(cmdShopId);
            cmdShopId.Dispose();

            // message for display the shop moved to order successfully
            MessageView message = new MessageView()
            {
                DataContext = new MessageViewModel("../../Images/message.Success.png", "Tovarlar buyurtmaga muvaffaqilyatli o'tkazildi!")
            };
            message.ShowDialog();

            mainWindow.SelectedViewModel = new SaleViewModel(mainWindow);

        }

        /// <summary>
        /// The function to compute sum of total products
        /// </summary>
        public void SumSomDollar()
        {
            using (DataTable tbSum = new DataTable())
            {

                string sum = "sum"/*, dollar = "$"*/;

                string querySumSom = "SELECT SUM(cart.sum) FROM cart " +
                    "INNER JOIN product ON cart.product = product.product_id " +
                    "INNER JOIN shop ON cart.shop = shop.id " +
                    "WHERE product.currency='" + sum + "' AND cart.shop='" + GetShop() + "'";
                objDbAccess.readDatathroughAdapter(querySumSom, tbSum);

                if (!string.IsNullOrEmpty(tbSum.Rows[0]["SUM(cart.sum)"].ToString()))
                {
                    SumSom = double.Parse(tbSum.Rows[0]["SUM(cart.sum)"].ToString());
                }
                else
                {
                    SumSom = 0;
                }
                tbSum.Clear();

                //string querySumDollar = "select sum(cart.sum) from cart " +
                //    "inner join product on cart.product = product.product_id " +
                //    "inner join shop on cart.shop = shop.id " +
                //    "where product.currency='" + dollar + "' and cart.shop='" + GetShop() + "'";
                //if (tbSum.Rows.Count == 1)
                //{
                //    SumDollar = double.Parse(tbSum.Rows[0]["sum(cart.sum)"].ToString());
                //}
                //tbSum.Clear();
            }
        }

        /// <summary>
        /// The method to get shop id
        /// </summary>
        public int GetShop()
        {
            int shop = 0;
            using (DataTable tbShopId = new DataTable())
            {
                string queryShopId = "SELECT shopid.shop FROM shopid INNER JOIN staff ON shopid.password = staff.password " +
                    "WHERE staff.password='" + MainWindowViewModel.user_password + "'";
                ObjDbAccess.readDatathroughAdapter(queryShopId, tbShopId);
                if (tbShopId.Rows.Count > 0)
                    shop = Convert.ToInt32(tbShopId.Rows[0]["shop"]);
                else
                    shop = 0;
            }
            return shop;
        }
        #endregion
    }
}
