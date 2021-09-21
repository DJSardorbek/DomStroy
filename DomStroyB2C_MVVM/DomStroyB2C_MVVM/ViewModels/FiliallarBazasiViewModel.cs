using DomStroyB2C_MVVM.API.Branch;
using DomStroyB2C_MVVM.API.Branch.BranchService;
using DomStroyB2C_MVVM.API.Product_residue;
using DomStroyB2C_MVVM.API.Product_residue.ProductService;
using DomStroyB2C_MVVM.Commands;
using System.Collections.Generic;
using System.Windows;

namespace DomStroyB2C_MVVM.ViewModels
{
    class FiliallarBazasiViewModel : BaseViewModel
    {
        #region Constructor

        public FiliallarBazasiViewModel()
        {
            LoadingVisibility = Visibility.Collapsed;
            _branchProductService = new BranchProductService();
            _branchService = new BranchService();
            PaginationByDefault(); // done
            GetBranchesAsync(); // done
            FilterCommand = new RelayCommand(FilterBranchAsync); // done
            SearchCommand = new RelayCommand(SearchBranchProductAsync); // done
            NextCommand = new RelayCommand(NextPageAsync);
            PreviousCommand = new RelayCommand(PreviousPageAsync);
            Index = -1;
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The list of branch product
        /// </summary>
        private BranchProduct productList;

        public BranchProduct ProductList
        {
            get { return productList; }
            set { productList = value; OnPropertyChanged("ProductList"); }
        }

        /// <summary>
        /// The selected product
        /// </summary>
        private Result product;

        public Result Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged("Product"); }
        }

        /// <summary>
        /// The selected item
        /// </summary>
        private Branch branch;

        public Branch Branch
        {
            get { return branch; }
            set { branch = value; OnPropertyChanged("Branch"); }
        }

        /// <summary>
        /// The list of branches
        /// </summary>
        private List<Branch> branches;

        public List<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged("Branches"); }
        }

        /// <summary>
        /// The branch product service to do crud operations
        /// </summary>
        private BranchProductService _branchProductService { get; set; }

        public BranchService _branchService { get; set; }

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }

        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; OnPropertyChanged("Index"); }
        }

        /// <summary>
        /// search
        /// </summary>
        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged("Search"); }
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

        #endregion

        #region Commands

        public RelayCommand FilterCommand { get; set; }

        public RelayCommand SearchCommand { get; set; }

        public RelayCommand NextCommand { get; set; }
        public RelayCommand PreviousCommand { get; set; }


        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get branch product list
        /// </summary>
        public async void GetBranchProductListAsync()
        {
            LoadingVisibility = Visibility.Visible;
            ProductList = await _branchProductService.GetAll();
            Next = ProductList.next;
            Previous = ProductList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            CheckPaginationIsItIsNull(Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to filter branch product
        /// </summary>
        public async void FilterBranchAsync()
        {
            LoadingVisibility = Visibility.Visible;
            ProductList = await _branchProductService.FilterByBranch(Branch.id.ToString());
            Next = ProductList.next;
            Previous = ProductList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            CheckPaginationIsItIsNull(Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The function to search branch product
        /// </summary>
        public async void SearchBranchProductAsync()
        {
            //if the text of search is not null, we search product
            if (!string.IsNullOrEmpty(Search) && Search.Length > 2 && Index!=-1)
            {
                LoadingVisibility = Visibility.Visible;
                ProductList = await _branchProductService.SearchProductByBranch(Branch.id.ToString(),Search);
                LoadingVisibility = Visibility.Collapsed;
            }
            //else we show the list of products
            else
            {
                FilterBranchAsync();
            }
        }

        /// <summary>
        /// After getting product list, checking pagination if it is not null
        /// </summary>
        /// <param name="next"></param>
        public void CheckPaginationIsItIsNull(string next)
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
        /// The function to switch page of product list
        /// </summary>
        public async void NextPageAsync()
        {
            LoadingVisibility = Visibility.Visible;
            ProductList = await _branchProductService.ProductPagination(Next.ToString());
            Next = ProductList.next;
            Previous = ProductList.previous;
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
            ProductList = await _branchProductService.ProductPagination(Previous.ToString());
            Next = ProductList.next;
            Previous = ProductList.previous;
            if (Next == null) { Next = ""; }
            if (Previous == null) { Previous = ""; }
            PaginationNextPrevious(Previous.ToString(), Next.ToString());
            LoadingVisibility = Visibility.Collapsed;
        }

        public async void GetBranchesAsync()
        {
            LoadingVisibility = Visibility.Visible;
            Branches = await _branchService.GetAll();
            LoadingVisibility = Visibility.Collapsed;
        }

        #endregion
    }
}
