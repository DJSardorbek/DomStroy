using DomStroyB2C_MVVM.API.Debtor.DoingPayment;
using DomStroyB2C_MVVM.API.Debtor.DoingPayment.DoingPaymentService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views;
using DomStroyB2C_MVVM.Views.ModalViews;
using System;
using System.Data;
using System.Windows;

namespace DomStroyB2C_MVVM.ViewModels
{
    class DebtPaymentViewModel : BaseViewModel
    {
        #region Constructor

        public DebtPaymentViewModel(int client_id, string client_name, string total_sum, string total_dollar, DebtPaymentView view)
        {
            LoadingVisibility = Visibility.Collapsed;
            CashSumVisibility = Visibility.Collapsed;
            CashDollarVisibility = Visibility.Collapsed;
            CreditCardVisibility = Visibility.Collapsed;
            TransferVisibility = Visibility.Collapsed;

            this._view = view;

            this.client_id = client_id;
            this.Client_name = client_name;
            Total_sum = total_sum;
            Total_dollar = total_dollar;
            objDbAccess = new DBAccess();
            _doingPaymentService = new DoingPaymentService();
            GetCurrency();
            submitPaymentCommand = new RelayCommand(SubmitPayment);
            clearCashSumCommand = new RelayCommand(ClearCashSum);
            clearCashDollarCommand = new RelayCommand(ClearCashDollar);
            clearCreditCardComamnd = new RelayCommand(ClearCreditCard);
            clearTransferComamnd = new RelayCommand(ClearTransfer);
            finalizePaymentCommand = new RelayCommand(FinalizePaymentAsync);

        }

        #endregion

        #region Private Fields

        public DebtPaymentView _view { get; set; }

        private DoingPaymentService _doingPaymentService { get; set; }

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }

        public int client_id { get; set; }

        private string client_name;

        public string Client_name
        {
            get { return client_name; }
            set { client_name = value; OnPropertyChanged("Client_name"); }
        }


        /// <summary>
        /// Payment type of cash sum
        /// </summary>
        private string cashSum;

        public string CashSum
        {
            get { return cashSum; }
            set { cashSum = value; OnPropertyChanged("CashSum"); }
        }

        /// <summary>
        /// Payment type of cash dolar
        /// </summary>
        private string cashDollar;

        public string CashDollar
        {
            get { return cashDollar; }
            set { cashDollar = value; OnPropertyChanged("CashDollar"); }
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
        /// The summa that payed by client
        /// </summary>
        private string payedSumma;

        public string PayedSumma
        {
            get { return payedSumma; }
            set { payedSumma = value; OnPropertyChanged("PayedSumma"); }
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
        /// The total sum
        /// </summary>
        private string total_dollar;

        public string Total_dollar
        {
            get { return total_dollar; }
            set { total_dollar = value; OnPropertyChanged("Total_dollar"); }
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
        /// The type of payment
        /// </summary>
        private int paymentType;

        public int PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; OnPropertyChanged("PaymentType"); }
        }

        /// <summary>
        /// The visibility of cash sum
        /// </summary>
        private Visibility cashSumVisibility;

        public Visibility CashSumVisibility
        {
            get { return cashSumVisibility; }
            set { cashSumVisibility = value; OnPropertyChanged("CashSumVisibility"); }
        }

        /// <summary>
        /// The visibility of cash dollar
        /// </summary>
        private Visibility cashDollarVisibility;

        public Visibility CashDollarVisibility
        {
            get { return cashDollarVisibility; }
            set { cashDollarVisibility = value; OnPropertyChanged("CashDollarVisibility"); }
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
        /// The data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to clear cash sum
        /// </summary>
        private RelayCommand clearCashSumCommand;

        public RelayCommand ClearCashSumCommand
        {
            get { return clearCashSumCommand; }
        }

        /// <summary>
        /// The command to clear cash dollar
        /// </summary>
        private RelayCommand clearCashDollarCommand;

        public RelayCommand ClearCashDollarCommand
        {
            get { return clearCashDollarCommand; }
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

        private RelayCommand submitPaymentCommand;

        public RelayCommand SubmitPaymentCommand
        {
            get { return submitPaymentCommand; }
        }

        /// <summary>
        /// The command to finalize payment
        /// </summary>
        private RelayCommand finalizePaymentCommand;

        public RelayCommand FinalizePaymentCommand
        {
            get { return finalizePaymentCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to submit payment
        /// </summary>
        public void SubmitPayment()
        {
            // First we will check payed summa is null or not
            if (string.IsNullOrEmpty(PayedSumma)) return;

            // if the payment type is cash sum
            if (PaymentType == 0)
            {
                CashSum = PayedSumma; CashSumVisibility = Visibility.Visible; PayedSumma = "";
            }

            // if the payment type is cash dollar
            if (PaymentType == 1)
            {
                CashDollar = PayedSumma; CashDollarVisibility = Visibility.Visible; PayedSumma = "";
            }

            // if the payment type is credit_card
            if (PaymentType == 2)
            {
                CreditCardVisibility = Visibility.Visible; CreditCard = PayedSumma; PayedSumma = "";
            }

            // if the payment type is transfer
            if (PaymentType == 3)
            {
                Transfer = PayedSumma; TransferVisibility = Visibility.Visible; PayedSumma = "";
            }
        }

        /// <summary>
        /// The function to clear cash sum
        /// </summary>
        public void ClearCashSum()
        {
            CashSum = string.Empty;
            CashSumVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to clear cash dollar
        /// </summary>
        public void ClearCashDollar()
        {
            CashDollar = string.Empty;
            CashSumVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to clear credit_card
        /// </summary>
        public void ClearCreditCard()
        {
            CreditCard = string.Empty;
            CreditCardVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to clear transfer
        /// </summary>
        public void ClearTransfer()
        {
            Transfer = string.Empty;
            TransferVisibility = Visibility.Collapsed;
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
        /// The function to finalize to do payment
        /// </summary>
        private async void FinalizePaymentAsync()
        {
            bool payed_sum_is_extra = CheckPaymentIfItIsExtra();

            // if payed summa is not extra, we finalize doing payment
            if(payed_sum_is_extra == false)
            {
                LoadingVisibility = Visibility.Visible;

                DoingPayment model = new DoingPayment();

                model.staff = MainWindowViewModel.user_id;
                model.branch = MainWindowViewModel.branch;
                model.client = client_id;
                model.paid_at = DateTime.Now.ToString("yyyy-MM-dd");

                // card
                if (!string.IsNullOrEmpty(CreditCard)) { model.card = double.Parse(CreditCard); }
                else { model.card = 0; }

                // cash_sum
                if (!string.IsNullOrEmpty(CashSum)) { model.cash_sum = double.Parse(CashSum); }
                else { model.cash_sum = 0; }

                // cash_dollar
                if (!string.IsNullOrEmpty(CashDollar)) { model.cash_dollar = double.Parse(CashDollar); }
                else { model.cash_dollar = 0; }

                // discount_sum & dollar
                model.discount_sum = 0; model.discount_dollar = 0;

                //transfer
                if (!string.IsNullOrEmpty(Transfer)) { model.transfer = double.Parse(Transfer); }
                else { model.transfer = 0; }

                // from_ball
                model.from_ball = 0;

                //comment
                model.comment = "none";

                //payment_for_loan
                model.payment_for_loan = true;

                try
                {
                    bool result = await _doingPaymentService.Post(model);

                    if (result)
                    {
                        LoadingVisibility = Visibility.Collapsed;
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("/Images/message.Success.png", "To'lov muvaffaqqiyatli amalga oshirildi!")
                        };
                        message.ShowDialog();
                        _view.Close();
                    }

                    else
                    {
                        LoadingVisibility = Visibility.Collapsed;
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("/Images/message.Error.png", "Server bilan bog'lanishda xatolik")
                        };
                        message.ShowDialog();

                    }
                }
                catch (Exception ex)
                {

                    LoadingVisibility = Visibility.Collapsed;
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("/Images/message.Error.png", ex.Message)
                    };
                    message.ShowDialog();
                }
            }

            // else if payed summa is extra, we display error message
            else
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("/Images/message.Error.png", "To'lov summasi ortiqcha kiritildi!")
                };
                message.ShowDialog();
                return;
            }
        }

        /// <summary>
        /// The function to check payed sum if it is extra
        /// </summary>
        /// <returns></returns>
        public bool CheckPaymentIfItIsExtra()
        {
            bool result = true;

            // to prevent paying extra, we sum all loan sum in the same currency so'm
            double cash_sum = 0, cash_dollar = 0, card = 0, transfer = 0;
            double total_sum = 0, total_dollar = 0, all_loan_sum = 0, payed_sum = 0;

            //cash_sum
            if (!string.IsNullOrEmpty(CashSum)) { cash_sum = double.Parse(CashSum); }

            //cash_dollar
            if (!string.IsNullOrEmpty(CashDollar)) { cash_dollar = double.Parse(CashDollar); }

            //card
            if (!string.IsNullOrEmpty(CreditCard)) { card = double.Parse(CreditCard); }

            //transfer
            if (!string.IsNullOrEmpty(Transfer)) { transfer = double.Parse(Transfer); }

            //payed_sum
            payed_sum = cash_sum + (cash_dollar * double.Parse(Currency)) + card + transfer;

            //total_sum
            if (!string.IsNullOrEmpty(Total_sum)) { total_sum = double.Parse(Total_sum); }

            //total_dollar
            if (!string.IsNullOrEmpty(Total_dollar)) { total_dollar = double.Parse(Total_dollar); }

            //all_loan_sum
            all_loan_sum = total_sum + (total_dollar * double.Parse(Currency));

            if (all_loan_sum >= payed_sum) { result = false; }

            return result;
        }
        #endregion
    }
}
