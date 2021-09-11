using DomStroyB2C_MVVM.API.Product_residue;
using DomStroyB2C_MVVM.API.Product_residue.ProductService;
using System.Collections.Generic;
using System.Windows;

namespace DomStroyB2C_MVVM.ViewModels
{
    class TovarQoldiqViewModel : BaseViewModel
    {
        #region Constructor

        public TovarQoldiqViewModel()
        {
            LoadingVisibility = Visibility.Collapsed;
            _branchProductService = new BranchProductService();
            GetBranchProductListAsync();
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
        /// The branch product service to do crud operations
        /// </summary>
        private BranchProductService _branchProductService { get; set; }

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }


        #endregion

        #region Commands

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get branch product list
        /// </summary>
        public async void GetBranchProductListAsync()
        {
            LoadingVisibility = Visibility.Visible;
            ProductList = await _branchProductService.GetAll();
            LoadingVisibility = Visibility.Collapsed;
        }


        #endregion
    }
}
