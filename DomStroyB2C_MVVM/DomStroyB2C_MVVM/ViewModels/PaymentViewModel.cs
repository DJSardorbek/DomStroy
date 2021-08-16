using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views.ModalViews;
using System.Data;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

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
            CashVisibility = Visibility.Collapsed;
            CreditCardVisibility = Visibility.Collapsed;
            TransferVisibility = Visibility.Collapsed;
            addClientCommand = new RelayCommand(OpenAddClientWindow);
            clientVisibilityCommand = new RelayCommand(SetClientVisibility);
            searchCommand = new RelayCommand(SearchClient);
            changeCurrencyCommand = new RelayCommand(ChangeCurrency);
            chooseClientCommand = new RelayCommand(ChooseClient);
            submitPaymentCommand = new RelayCommand(SubmitPayment);
            objDbAccess = new DBAccess();
            tbClient = new DataTable();
            GetClientList();
            Search = ClientList.First().FullName;
            ClientId = ClientList.First().Id;
            Loan_sum = ClientList.First().Loan_sum.ToString();
            Loan_dollar = ClientList.First().Loan_dollar.ToString();
            ClientInfoVisibility = Visibility.Visible;
            GetCurrency();
            CurrencyType = "So'm";
            CurrencyVisibility = Visibility.Collapsed;
            clearCashCommand = new RelayCommand(ClearCash);
            clearCreditCardComamnd = new RelayCommand(ClearCreditCard);
            clearTransferComamnd = new RelayCommand(ClearTransfer);
            Total_loan = "0";
            ReturnDate = DateTime.Now;
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

        /// <summary>
        /// The visibility value to bind client information
        /// </summary>
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
        /// The remembered sum of som
        /// </summary>
        private string remembered_sum;

        public string Remembered_sum
        {
            get { return remembered_sum; }
            set { remembered_sum = value; OnPropertyChanged("Remembered_sum"); }
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

        /// <summary>
        /// The visibility of currency
        /// </summary>
        private Visibility currencyVisibility;

        public Visibility CurrencyVisibility
        {
            get { return currencyVisibility; }
            set { currencyVisibility = value; OnPropertyChanged("CurrencyVisibility"); }
        }

        /// <summary>
        /// The id of choosen client
        /// </summary>
        private int clientId;

        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; OnPropertyChanged("ClientId"); }
        }

        /// <summary>
        /// The total sum of debt
        /// </summary>
        private string loan_sum;

        public string Loan_sum
        {
            get { return loan_sum; }
            set { loan_sum = value; OnPropertyChanged("Loan_sum"); }
        }

        /// <summary>
        /// The total dollar of debt
        /// </summary>
        private string loan_dollar;

        public string Loan_dollar
        {
            get { return loan_dollar; }
            set { loan_dollar = value; OnPropertyChanged("Loan_dollar"); }
        }

        /// <summary>
        /// The shop which doing payment now
        /// </summary>
        private int shop;

        public int Shop
        {
            get { return shop; }
            set { shop = value; OnPropertyChanged("Shop"); }
        }

        /// <summary>
        /// Payment type of cash
        /// </summary>
        private string cash;

        public string Cash
        {
            get { return cash; }
            set { cash = value; OnPropertyChanged("Cash"); }
        }

        /// <summary>
        /// Payment type of credit card
        /// </summary>
        private string creditCard;

        public string CreditCard
        {
            get { return creditCard; }
            set { creditCard = value; OnPropertyChanged("CreditCard"); }
        }

        /// <summary>
        /// Payment type of transfer
        /// </summary>
        private string transfer;

        public string Transfer
        {
            get { return transfer; }
            set { transfer = value; OnPropertyChanged("Transfer"); }
        }

        /// <summary>
        /// The type of payment
        /// </summary>
        private int paymentType;

        public int PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; OnPropertyChanged("PaymentType"); }
        }

        /// <summary>
        /// The visibility of cash
        /// </summary>
        private Visibility cashVisibility;

        public Visibility CashVisibility
        {
            get { return cashVisibility; }
            set { cashVisibility = value; OnPropertyChanged("CashVisibility"); }
        }

        /// <summary>
        /// The visibility of credit_card
        /// </summary>
        private Visibility creditCardVisibility;

        public Visibility CreditCardVisibility
        {
            get { return creditCardVisibility; }
            set { creditCardVisibility = value; OnPropertyChanged("CreditCardVisibility"); }
        }

        /// <summary>
        /// The visibility of transfer
        /// </summary>
        private Visibility transferVisibility;

        public Visibility TransferVisibility
        {
            get { return transferVisibility; }
            set { transferVisibility = value; OnPropertyChanged("TransferVisibility"); }
        }

        /// <summary>
        /// The summa that payed by client
        /// </summary>
        private string payedSumma;

        public string PayedSumma
        {
            get { return payedSumma; }
            set { payedSumma = value; OnPropertyChanged("PayedSumma"); }
        }

        private string total_loan;

        public string Total_loan
        {
            get { return total_loan; }
            set { total_loan = value; OnPropertyChanged("Total_loan"); }
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

        /// <summary>
        /// The command to choose client
        /// </summary>
        private RelayCommand chooseClientCommand;

        public RelayCommand ChooseClientCommand
        {
            get { return chooseClientCommand; }
        }

        private RelayCommand submitPaymentCommand;

        public RelayCommand SubmitPaymentCommand
        {
            get { return submitPaymentCommand; }
        }

        /// <summary>
        /// The command to clear cash
        /// </summary>
        private RelayCommand clearCashCommand;

        public RelayCommand ClearCashCommand
        {
            get { return clearCashCommand; }
        }

        /// <summary>
        /// The command to clear credit_card
        /// </summary>
        private RelayCommand clearCreditCardComamnd;

        public RelayCommand ClearCreditCardCommand
        {
            get { return clearCreditCardComamnd; }
        }

        /// <summary>
        /// The command to clear transfer
        /// </summary>
        private RelayCommand clearTransferComamnd;

        public RelayCommand ClearTransferCommand
        {
            get { return clearTransferComamnd; }
        }

        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; OnPropertyChanged("ReturnDate"); }
        }


        #endregion

        #region Helper functions

        /// <summary>
        /// The function to open add client window
        /// </summary>
        public void OpenAddClientWindow()
        {
            CliantAddView cliantAddView = new CliantAddView();
            cliantAddView.DataContext = new ClientAddViewModel(cliantAddView);
            cliantAddView.ShowDialog();

        }

        /// <summary>
        /// The function to set visibility to clientDataGrid
        /// </summary>
        public void SetClientVisibility()
        {
            if (ClientDataGrid == Visibility.Visible)
            {
                ClientDataGrid = Visibility.Collapsed;
                if (ClientId == 1)
                {
                    ClientInfoVisibility = Visibility.Visible;
                    //CalendarVisibility = Visibility.Visible;
                }
                else
                {
                    ClientInfoVisibility = Visibility.Visible;
                    CalendarVisibility = Visibility.Visible;
                }

                return;
            }
            else
            {
                ClientDataGrid = Visibility.Visible;
                ClientInfoVisibility = Visibility.Collapsed;
                CalendarVisibility = Visibility.Collapsed;
                return;
            }

        }

        /// <summary>
        /// The function to get client list
        /// </summary>
        public void GetClientList()
        {
            string queryCLient = "SELECT id, CONCAT(first_name, ' ', last_name) AS full_name, phone_1, address, loan_sum, loan_dollar FROM client ORDER BY id";
            TbClient.Clear();
            ObjDbAccess.readDatathroughAdapter(queryCLient, TbClient);
            ConvertClientTableToList();


        }

        /// <summary>
        /// The function to convert clientDataTable to list
        /// </summary>
        public void ConvertClientTableToList()
        {
            ClientList = (from DataRow dr in TbClient.Rows
                          select new clientDTO()
                          {
                              Id = Convert.ToInt32(dr["id"]),
                              FullName = dr["full_name"].ToString(),
                              Phone = dr["phone_1"].ToString(),
                              Address = dr["address"].ToString(),
                              Loan_sum = Convert.ToDouble(dr["loan_sum"]),
                              Loan_dollar = Convert.ToDouble(dr["loan_dollar"])
                          }).ToList();
        }

        /// <summary>
        /// The function to search client from client list
        /// </summary>
        public void SearchClient()
        {
            if (Search != "")
            {
                string querySearchClient = "SELECT id, CONCAT(first_name, ' ', last_name) AS full_name, phone_1, address, loan_sum, loan_dollar FROM client " +
                    "WHERE first_name LIKE '%" + Search + "%' OR last_name LIKE '%" + Search + "%'";
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
            using (DataTable tbCurrency = new DataTable())
            {
                ObjDbAccess.readDatathroughAdapter(queryToCurrency, tbCurrency);
                if (!string.IsNullOrEmpty(tbCurrency.Rows[0]["real_currency"].ToString()))
                {
                    Currency = tbCurrency.Rows[0]["real_currency"].ToString();
                }
                else
                {
                    Currency = "0";
                }
            }
        }

        /// <summary>
        /// The function to change currency
        /// </summary>
        public void ChangeCurrency()
        {
            if (CurrencyType == "So'm")
            {
                double _dTotalSum = double.Parse(Remembered_sum);
                double _dCurrency = double.Parse(Currency);
                double _dResult = _dTotalSum / _dCurrency;
                _dResult = Math.Round(_dResult, 3);
                Total_sum = _dResult.ToString();
                CurrencyType = "Dollar";
                CurrencyVisibility = Visibility.Visible;

                // We will clear payed sum to restart
                Cash = string.Empty;
                CashVisibility = Visibility.Collapsed;
                CreditCard = string.Empty;
                CreditCardVisibility = Visibility.Collapsed;
                Transfer = string.Empty;
                TransferVisibility = Visibility.Collapsed;
                Total_loan = "0";

                return;
            }
            else
            {
                Total_sum = Remembered_sum;
                CurrencyType = "So'm";
                CurrencyVisibility = Visibility.Collapsed;

                // We will clear payed sum to restart
                Cash = string.Empty;
                CashVisibility = Visibility.Collapsed;
                CreditCard = string.Empty;
                CreditCardVisibility = Visibility.Collapsed;
                Transfer = string.Empty;
                TransferVisibility = Visibility.Collapsed;
                Total_loan = "0";

                return;
            }
        }

        /// <summary>
        /// The function to choose client
        /// </summary>
        public void ChooseClient()
        {
            ClientId = Client.Id;
            Loan_sum = Client.Loan_sum.ToString();
            Loan_dollar = Client.Loan_dollar.ToString();
            Search = Client.FullName;
            ClientDataGrid = Visibility.Collapsed;
            GetClientList();
            ClientInfoVisibility = Visibility.Visible;
            if (ClientId != 1)
                CalendarVisibility = Visibility.Visible;

            CompyuteLoanSum();

        }

        /// <summary>
        /// The function to submit payment
        /// </summary>
        public void SubmitPayment()
        {
            // First we will check payment type

            // if the payment type is cash
            if (PaymentType == 0)
            {
                if (CheckPayedSumma())
                {
                    Cash = PayedSumma; CashVisibility = Visibility.Visible; PayedSumma = "";
                    CompyuteLoanSum();
                }
            }

            // if the payment type is credit_card
            if (PaymentType == 1)
            {
                if (CheckPayedSumma())
                {
                    CreditCardVisibility = Visibility.Visible; CreditCard = PayedSumma; PayedSumma = "";
                    CompyuteLoanSum();
                }
            }

            // if the payment type is transfer
            if (PaymentType == 2)
            {
                if (CheckPayedSumma())
                {
                    Transfer = PayedSumma; TransferVisibility = Visibility.Visible; PayedSumma = "";
                    CompyuteLoanSum();
                }
            }
        }

        /// <summary>
        /// The function to check payed if it is higher
        /// </summary>
        /// <returns></returns>
        public bool CheckPayedSumma()
        {
            double cash = 0, credit_card = 0, transfer = 0;
            double total_sum = 0;
            if (!string.IsNullOrEmpty(Cash))
                cash = double.Parse(Cash);
            if (!string.IsNullOrEmpty(CreditCard))
                credit_card = double.Parse(CreditCard);
            if (!string.IsNullOrEmpty(Transfer))
                transfer = double.Parse(Transfer);

            total_sum = cash + credit_card + transfer;
            bool return_value = true;
            if (string.IsNullOrEmpty(PayedSumma))
            {
                return false;
            }
            switch (PaymentType)
            {
                // if the payment type is cash
                case 0:
                    //if the payment is higher than total_sum
                    if (double.Parse(payedSumma) + total_sum - cash > double.Parse(Total_sum))
                    {
                        // We will display error message
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Error.png", "To'lov summasi oritqcha kiritib yuborildi!")
                        };
                        message.ShowDialog();
                        return_value = false;
                    }
                    break;

                case 1:
                    //if the payment is higher than total_sum
                    if (double.Parse(payedSumma) + total_sum - credit_card > double.Parse(Total_sum))
                    {
                        // We will display error message
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Error.png", "To'lov summasi oritqcha kiritib yuborildi!")
                        };
                        message.ShowDialog();
                        return_value = false;
                    }
                    break;

                case 2:
                    //if the payment is higher than total_sum
                    if (double.Parse(payedSumma) + total_sum - transfer > double.Parse(Total_sum))
                    {
                        // We will display error message
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Error.png", "To'lov summasi oritqcha kiritib yuborildi!")
                        };
                        message.ShowDialog();
                        return_value = false;
                    }
                    break;

            }

            return return_value;
        }

        /// <summary>
        /// The function to clear cash 
        /// </summary>
        public void ClearCash()
        {
            Cash = string.Empty;
            CashVisibility = Visibility.Collapsed;
            CompyuteLoanSum();
        }

        // The function to clear credit_card
        public void ClearCreditCard()
        {
            CreditCard = string.Empty;
            CreditCardVisibility = Visibility.Collapsed;
            CompyuteLoanSum();
        }

        // The function to clear transfer
        public void ClearTransfer()
        {
            Transfer = string.Empty;
            TransferVisibility = Visibility.Collapsed;
            CompyuteLoanSum();
        }

        // The function to compyute loan sum of client
        public void CompyuteLoanSum()
        {
            if (ClientId != 1)
            {
                double cash = 0, credit_card = 0, transfer = 0;
                double total_sum = 0, total_loan = 0;
                if (!string.IsNullOrEmpty(Cash))
                    cash = double.Parse(Cash);
                if (!string.IsNullOrEmpty(CreditCard))
                    credit_card = double.Parse(CreditCard);
                if (!string.IsNullOrEmpty(Transfer))
                    transfer = double.Parse(Transfer);

                total_sum = cash + credit_card + transfer;
                if (double.Parse(Total_sum) > total_sum)
                {
                    total_loan = double.Parse(Total_sum) - total_sum;
                    Total_loan = total_loan.ToString();
                }
                else
                {
                    Total_loan = "0";
                }
            }
        }

        /// <summary>
        /// The function to finish payment
        /// </summary>
        public void FinalizePayment()
        {
            // the total sum of shopping
            double total_sum = 0;
            total_sum = double.Parse(Total_sum);

            // the total payed sum
            double cash = 0, credit_card = 0, transfer = 0;
            double total_payment = 0;
            if (!string.IsNullOrEmpty(Cash))
                cash = double.Parse(Cash);
            if (!string.IsNullOrEmpty(CreditCard))
                credit_card = double.Parse(CreditCard);
            if (!string.IsNullOrEmpty(Transfer))
                transfer = double.Parse(Transfer);
            total_payment = cash + credit_card + transfer;

            // If the client is not simple
            if (ClientId != 1)
            {
                // we add total loan sum to payed sum
                double total_loan = double.Parse(Total_loan);
                total_payment += total_loan;
            }

            // If payment is not equal to total sum, we display error message
            if (total_payment != total_sum)
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", "To'lov summasi to'liq to'lanmadi!")
                };
                message.ShowDialog();
                return;
            }

            // if every this is ok, we finalize payment
            else
            {
                MySqlCommand cmd;
                string cash_sum = "0", cash_dollar = "0";
                if(CurrencyType == "So'm")
                {
                    cash_sum = Cash.ToString();
                    cash_sum = DoubleToStr(cash_sum);
                }
                else
                {
                    cash_dollar = Cash.ToString();
                    cash_dollar = DoubleToStr(cash_dollar);
                }
                // If the client is simple
                if (ClientId == 1)
                {

                    cmd = new MySqlCommand($"UPDATE shop set client='{ClientId}', card='{CreditCard}', transfer='{Transfer}', cash_sum='{cash_sum}', cash_dollar='{cash_dollar}', ");
                }
            }
        }

        public string DoubleToStr(string s)
        {
            if(s.Contains(','))
            {
                s = s.Replace(',', '.');
            }
            return s;
        }
        #endregion
    }
}
