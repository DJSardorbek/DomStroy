using DomStroyB2C_MVVM.API.Debtor;
using DomStroyB2C_MVVM.API.Debtor.PaymentHistory;
using DomStroyB2C_MVVM.API.Debtor.PaymentHistory.PaymentService;
using DomStroyB2C_MVVM.Commands;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class DebtorsPayHistoryViewModel : BaseViewModel
    {
        #region Constructor
        public DebtorsPayHistoryViewModel(int client, List<ClientDetail> clientDetail, int index, MainWindowViewModel mainWindow)
        {
            this.client_id = client;
            this.index = index;
            ClientDetail1 = clientDetail;
            this.mainWindow = mainWindow;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            _paymentService = new PaymentService();
            PaginationByDefault();
            GetPaymentListAsync();
            NextCommand = new RelayCommand(NextPageAsync);
            PreviousCommand = new RelayCommand(PreviousPageAsync);
            BackToDebtorsCommand = new RelayCommand(BackToDebtors);
        }

        #endregion

        #region Private Fields

        private MainWindowViewModel mainWindow;

        private PaymentService _paymentService { get; set; }

        private PaymentHistory paymentList;

        public PaymentHistory PaymentList
        {
            get { return paymentList; }
            set { paymentList = value; OnPropertyChanged("PaymentList"); }
        }

        public int client_id { get; set; }

        public int index { get; set; }

        private List<ClientDetail> clientDetail;

        public List<ClientDetail> ClientDetail1
        {
            get { return clientDetail; }
            set { clientDetail = value; OnPropertyChanged("ClientDetail1"); }
        }

        #region Pagination

        /// <summary>
        /// The next page of product
        /// </summary>
        private object next;

        public object Next
        {
            get { return next; }
            set { next = value; OnPropertyChanged("Next"); }
        }

        /// <summary>
        /// The previous page of product
        /// </summary>
        private object previous;

        public object Previous
        {
            get { return previous; }
            set { previous = value; OnPropertyChanged("Previous"); }
        }

        /// <summary>
        /// left button of pagination of opacity
        /// </summary>
        private double leftOpacity;

        public double LeftOpacity
        {
            get { return leftOpacity; }
            set { leftOpacity = value; OnPropertyChanged("LeftOpacity"); }
        }

        /// <summary>
        /// left button of pagination of enabled property
        /// </summary>
        private bool leftEnabled;

        public bool LeftEnabled
        {
            get { return leftEnabled; }
            set { leftEnabled = value; OnPropertyChanged("LeftEnabled"); }
        }

        /// <summary>
        /// left button of pagination of opacity
        /// </summary>
        private double rightOpacity;

        public double RightOpacity
        {
            get { return rightOpacity; }
            set { rightOpacity = value; OnPropertyChanged("RightOpacity"); }
        }

        /// <summary>
        /// left button of pagination of enabled property
        /// </summary>
        private bool rightEnabled;

        public bool RightEnabled
        {
            get { return rightEnabled; }
            set { rightEnabled = value; OnPropertyChanged("RightEnabled"); }
        }

        /// <summary>
        /// The visibility of pagination
        /// </summary>
        private Visibility pageVisibility;

        public Visibility PageVisibility
        {
            get { return pageVisibility; }
            set { pageVisibility = value; OnPropertyChanged("PageVisibility"); }
        }

        #endregion

        #region Loading gif

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }

        #endregion

        #endregion

        #region Commands
        public ICommand UpdateViewCommand { get; set; }

        public RelayCommand NextCommand { get; set; }
        public RelayCommand PreviousCommand { get; set; }
        public RelayCommand BackToDebtorsCommand { get; set; }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get the payment list of client
        /// </summary>
        public async void GetPaymentListAsync()
        {
            LoadingVisibility = Visibility.Visible;
            
            PaymentList = await _paymentService.GetPaymentList(client_id);
            Next = PaymentList.next;
            Previous = PaymentList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            CheckPaginationIfItIsNull(Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to switch page of product list
        /// </summary>
        public async void NextPageAsync()
        {
            LoadingVisibility = Visibility.Visible;
            PaymentList = await _paymentService.PaymentPagination(Next.ToString());
            Next = PaymentList.next;
            Previous = PaymentList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            PaginationNextPrevious(Previous.ToString(), Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to switch page of product list
        /// </summary>
        public async void PreviousPageAsync()
        {
            LoadingVisibility = Visibility.Visible;
            PaymentList = await _paymentService.PaymentPagination(Previous.ToString());
            Next = PaymentList.next;
            Previous = PaymentList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            PaginationNextPrevious(Previous.ToString(), Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// After getting product list, checking pagination if it is not null
        /// </summary>
        /// <param name="next"></param>
        public void CheckPaginationIfItIsNull(string next)
        {
            if (!string.IsNullOrEmpty(next))
            {
                Next = next;
                PageVisibility = Visibility.Visible;
                RightEnabled = true;
                RightOpacity = 1;
            }
            else
            {
                PageVisibility = Visibility.Collapsed;
                RightEnabled = false;
                RightOpacity = 0.5;
            }
        }

        /// <summary>
        /// The function to check both previous and next are null or not
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="next"></param>
        public void PaginationNextPrevious(string previous, string next)
        {
            if (!string.IsNullOrEmpty(next))
            {
                RightEnabled = true;
                RightOpacity = 1;
            }
            else
            {
                RightEnabled = false;
                RightOpacity = 0.5;
            }

            if (!string.IsNullOrEmpty(previous))
            {
                LeftEnabled = true;
                LeftOpacity = 1;
            }
            else
            {
                LeftEnabled = false;
                LeftOpacity = 0.5;
            }
        }

        /// <summary>
        /// Pagination settings by default
        /// </summary>
        public void PaginationByDefault()
        {
            PageVisibility = Visibility.Collapsed;
            RightEnabled = false;
            RightOpacity = 0.5;

            LeftEnabled = false;
            leftOpacity = 0.5;
        }

        public void BackToDebtors()
        {
            DebtorsViewModel debtorsViewModel = new DebtorsViewModel(mainWindow);
            mainWindow.SelectedViewModel = debtorsViewModel;
            debtorsViewModel.Index = index;
            debtorsViewModel.FilterDebtors();
            mainWindow.GridVisibility = true;
        }

        #endregion

    }
}
