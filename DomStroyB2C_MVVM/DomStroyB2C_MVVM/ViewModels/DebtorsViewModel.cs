using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using DomStroyB2C_MVVM.API.Debtor;
using DomStroyB2C_MVVM.API.Debtor.DebtorService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class DebtorsViewModel : BaseViewModel
    {
        #region Constructor
        public DebtorsViewModel(MainWindowViewModel viewModel)
        {
            LoadingVisibility = Visibility.Collapsed;
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
            PaginationByDefault();
            _debtorService = new DebtorService();
            FilterCommand = new RelayCommand(FilterDebtors);
            NextCommand = new RelayCommand(NextPageAsync);
            PreviousCommand = new RelayCommand(PreviousPageAsync);
            SearchCommand = new RelayCommand(SearchDebtorAsync);
            DisplayPaymentHistoryCommand = new RelayCommand(DisplayClientPaymentHistory);
            DoingPaymentCommand = new RelayCommand(DoingPayment);
            Index = -1;
        }

        #endregion

        #region Private Fields

        public MainWindowViewModel viewModel;

        private DebtorService _debtorService { get; set; }

        private Debtor debtors;

        public Debtor Debtors
        {
            get { return debtors; }
            set { debtors = value; OnPropertyChanged("Debtors"); }
        }

        private Result debtor;

        public Result Debtor
        {
            get { return debtor; }
            set { debtor = value; OnPropertyChanged("Debtor"); }
        }

        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged("Search"); }
        }


        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; OnPropertyChanged("Index"); }
        }

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

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }


        #endregion

        #region Commands
        public ICommand UpdateViewCommand { get; set; }

        public RelayCommand FilterCommand { get; set; }
        public RelayCommand PaymentCommand { get; set; }
        public RelayCommand NextCommand { get; set; }
        public RelayCommand PreviousCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand DisplayPaymentHistoryCommand { get; set; }
        public RelayCommand DoingPaymentCommand { get; set; }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to filter debtors list
        /// </summary>
        public async void FilterDebtors()
        {
            LoadingVisibility = Visibility.Visible;
            string status = string.Empty;
            switch (Index)
            {
                case 0: status = "imminent_payment"; break;
                case 1: status = "missed_payment"; break;
            }
            Debtors = await _debtorService.FilterDebtor(status);
            Next = Debtors.next;
            Previous = Debtors.previous;
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
            Debtors = await _debtorService.DebtorPagination(Next.ToString());
            Next = Debtors.next;
            Previous = Debtors.previous;
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
            Debtors = await _debtorService.DebtorPagination(Previous.ToString());
            Next = Debtors.next;
            Previous = Debtors.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            PaginationNextPrevious(Previous.ToString(), Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to do payment
        /// </summary>
        public void DoingPayment()
        {
            DebtPaymentView debtPayment = new DebtPaymentView();

            DebtPaymentViewModel debtPaymentViewModel = new DebtPaymentViewModel
            (Debtor.id, Debtor.first_name, Debtor.loan_sum.ToString(), Debtor.loan_dollar.ToString(), debtPayment);

            debtPayment.DataContext = debtPaymentViewModel;

            debtPayment.ShowDialog();

            FilterDebtors();
        }

        /// <summary>
        /// The function to display client payment history
        /// </summary>
        public void DisplayClientPaymentHistory()
        {
            DebtorsPayHistoryView payHistoryView = new DebtorsPayHistoryView();
            string discount_card = string.Empty;
            try
            {
                discount_card = Debtor.discount_card.card;
            }
            catch(Exception)
            {
                 discount_card = "none";
            }

            List<ClientDetail> clientDetail = new List<ClientDetail>();

            ClientDetail detail = new ClientDetail()
            {
                first_name = Debtor.first_name,
                address = Debtor.address,
                discount_card = discount_card,
                phone_1 = Debtor.phone_1
            };

            clientDetail.Add(detail);

            DebtorsPayHistoryViewModel payHistoryViewModel = new DebtorsPayHistoryViewModel(Debtor.id, clientDetail,Index, viewModel);

            payHistoryView.DataContext = payHistoryViewModel;

            viewModel.SelectedViewModel = payHistoryViewModel;

            viewModel.GridVisibility = false;
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
        /// The function to search debtors
        /// </summary>
        public async void SearchDebtorAsync()
        {
            //if the text of search is not null, we search product
            if (!string.IsNullOrEmpty(Search) && Search.Length > 2 && Index!=-1)
            {
                LoadingVisibility = Visibility.Visible;
                string status = string.Empty;
                switch (Index)
                {
                    case 0: status = "imminent_payment"; break;
                    case 1: status = "missed_payment"; break;
                }
                Debtors = await _debtorService.SearchDebtor(status,Search);
                LoadingVisibility = Visibility.Collapsed;
            }
            //else we show the list of products
            else
            {
                FilterDebtors();
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

        #endregion
    }
}
