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
            addClientCommand = new RelayCommand(OpenAddClientWindow);
            clientVisibilityCommand = new RelayCommand(SetClientVisibility);
            searchCommand = new RelayCommand(SearchClient);
            objDbAccess = new DBAccess();
            tbClient = new DataTable();
            GetClientList();
            Search = "";
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The Visibility valur to bind clientDataGrid
        /// </summary>
        private Visibility clientDataGrid;

        public Visibility ClientDataGrid
        {
            get { return clientDataGrid; }
            set { clientDataGrid = value; OnPropertyChanged("ClientDataGrid"); }
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

        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged("Search"); }
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

        #endregion
    }
}
