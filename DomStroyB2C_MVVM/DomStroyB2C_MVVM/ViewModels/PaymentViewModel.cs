using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views.ModalViews;
using System.Data;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        #region Constructor

        public PaymentViewModel()
        {
            ClientDataGrid = Visibility.Collapsed;
            CalendarVisibility = Visibility.Collapsed;
            ClientInfoVisibility = Visibility.Collapsed;
            addClientCommand = new RelayCommand(OpenAddClientWindow);
            clientVisibilityCommand = new RelayCommand(SetClientVisibility);
            searchCommand = new RelayCommand(SearchClient);
            changeCurrencyCommand = new RelayCommand(ChangeCurrency);
            objDbAccess = new DBAccess();
            tbClient = new DataTable();
            GetClientList();
            GetCurrency();
            Search = "";
            Total_sum = "2120000";
            CurrencyType = "So'm";
            CurrencyVisibility = Visibility.Collapsed;
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The Visibility value to bind clientDataGrid
        /// </summary>
        private Visibility clientDataGrid;

        public Visibility ClientDataGrid
        {
            get { return clientDataGrid; }
            set { clientDataGrid = value; OnPropertyChanged("ClientDataGrid"); }
        }

        /// <summary>
        /// The visibility value to bind calendar
        /// </summary>
        private Visibility calendarVisibility;

        public Visibility CalendarVisibility
        {
            get { return calendarVisibility; }
            set { calendarVisibility = value; OnPropertyChanged("CalendarVisibility"); }
        }

        private Visibility clientInfoVisibility;

        public Visibility ClientInfoVisibility
        {
            get { return clientInfoVisibility; }
            set { clientInfoVisibility = value; OnPropertyChanged("ClientInfoVisibility"); }
        }


        /// <summary>
        /// The choosen client
        /// </summary>
        private clientDTO client;

        public clientDTO Client
        {
            get { return client; }
            set { client = value; OnPropertyChanged("Client"); }
        }

        /// <summary>
        /// The list of client
        /// </summary>
        private List<clientDTO> clientList;

        public List<clientDTO> ClientList
        {
            get { return clientList; }
            set { clientList = value; OnPropertyChanged("ClientList"); }
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
        /// The client datatable
        /// </summary>
        private DataTable tbClient;

        public DataTable TbClient
        {
            get { return tbClient; }
        }

        /// <summary>
        /// The text of txtSearch
        /// </summary>
        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged("Search"); }
        }

        /// <summary>
        /// The currency
        /// </summary>
        private string curreny;

        public string Currency
        {
            get { return curreny; }
            set { curreny = value; OnPropertyChanged("Currency"); }
        }

        /// <summary>
        /// The total sum
        /// </summary>
        private string total_sum;

        public string Total_sum
        {
            get { return total_sum; }
            set { total_sum = value; OnPropertyChanged("Total_sum"); }
        }

        /// <summary>
        /// The currency type
        /// </summary>
        private string currencyType;

        public string CurrencyType
        {
            get { return currencyType; }
            set { currencyType = value; OnPropertyChanged("CurrencyType"); }
        }

        private Visibility currencyVisibility;

        public Visibility CurrencyVisibility
        {
            get { return currencyVisibility; }
            set { currencyVisibility = value;  OnPropertyChanged("CurrencyVisibility"); }
        }


        #endregion

        #region Commands

        /// <summary>
        /// The command for add new client
        /// </summary>
        private RelayCommand addClientCommand;

        public RelayCommand AddClientCommand
        {
            get { return addClientCommand; }
        }

        /// <summary>
        /// The command to set clientGrid visibility
        /// </summary>
        private RelayCommand clientVisibilityCommand;

        public RelayCommand ClientVisibilityCommand
        {
            get { return clientVisibilityCommand; }
        }

        /// <summary>
        /// The command to search client from client list
        /// </summary>
        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }

        private RelayCommand changeCurrencyCommand;

        public RelayCommand ChangeCurrencyCommand
        {
            get { return changeCurrencyCommand; }
        }


        #endregion

        #region Helper functions

        /// <summary>
        /// The function to open add client window
        /// </summary>
        public void OpenAddClientWindow()
        {
            CliantAddView cliantAddView = new CliantAddView()
            {
                DataContext = new ClientAddViewModel()
            };
            cliantAddView.ShowDialog();
           
        }

        /// <summary>
        /// The function to set visibility to clientDataGrid
        /// </summary>
        public void SetClientVisibility()
        {
            if(ClientDataGrid == Visibility.Visible)
            {
                ClientDataGrid = Visibility.Collapsed;
                return;
            }
            else
            {
                ClientDataGrid = Visibility.Visible;
                return;
            }
            
        }

        /// <summary>
        /// The function to get client list
        /// </summary>
        public void GetClientList()
        {
            string queryCLient = "select c.id, concat(c.first_name, ' ', c.last_name) as full_name, c.phone_1, c.address, ds.card, ds.bonus_sum, ds.bonus_dollar " +
                "from client as c inner join discountcard as ds on c.discount_card = ds.id";
            TbClient.Clear();
            ObjDbAccess.readDatathroughAdapter(queryCLient, TbClient);
            ConvertClientTableToList();
        }

        /// <summary>
        /// The function to convert clientDataTable to list
        /// </summary>
        public void  ConvertClientTableToList()
        {
            ClientList = (from DataRow dr in TbClient.Rows
                          select new clientDTO()
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
        /// The function to search client from client list
        /// </summary>
        public void SearchClient()
        {
            if (Search != "")
            {
                string querySearchClient = "select c.id, concat(c.first_name, ' ', c.last_name) as full_name, c.phone_1, c.address, ds.card, ds.bonus_sum, ds.bonus_dollar " +
                    "from client as c inner join discountcard as ds on c.discount_card = ds.id " +
                    "where c.first_name like '%" + Search + "%' or c.last_name like '%"+Search+"%'";
                TbClient.Clear();
                ObjDbAccess.readDatathroughAdapter(querySearchClient, TbClient);
                ConvertClientTableToList();
                ClientDataGrid = Visibility.Visible;
            }
            else
            {
                GetClientList();
                ClientDataGrid = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// The function to get currency
        /// </summary>
        public void GetCurrency()
        {
            string queryToCurrency = "select * from currency";
            using(DataTable tbCurrency = new DataTable())
            {
                ObjDbAccess.readDatathroughAdapter(queryToCurrency, tbCurrency);
                if(!string.IsNullOrEmpty(tbCurrency.Rows[0]["real_currency"].ToString()))
                {
                    Currency = tbCurrency.Rows[0]["real_currency"].ToString();
                }
                else
                {
                    Currency = "0";
                }
            }
        }

        public void ChangeCurrency()
        {
            if(CurrencyType == "So'm")
            {
                double _dTotalSum = double.Parse(Total_sum);
                double _dCurrency = double.Parse(Currency);
                double _dResult = _dTotalSum / _dCurrency;
                _dResult = Math.Round(_dResult, 3);
                Total_sum = _dResult.ToString();
                CurrencyType = "Dollar";
                CurrencyVisibility = Visibility.Visible;
                return;
            }
            else
            {
                double _dTotalSum = double.Parse(Total_sum);
                double _dCurrency = double.Parse(Currency);
                double _dResult = _dTotalSum * _dCurrency;
                _dResult = Math.Round(_dResult, 3);
                Total_sum = _dResult.ToString();
                CurrencyType = "So'm";
                CurrencyVisibility = Visibility.Collapsed;
                return;
            }
        }

        #endregion
    }
}
