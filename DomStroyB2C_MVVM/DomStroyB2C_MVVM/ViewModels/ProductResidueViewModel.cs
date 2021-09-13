using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DomStroyB2C_MVVM.API.Product_residue.ProductService;
using DomStroyB2C_MVVM.Commands;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class ProductResidueViewModel : BaseViewModel
    {
        #region Constructor
        public ProductResidueViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
            _branchProductService = new BranchProductService();
        }

        #endregion

        #region Private Fields

        private MainWindowViewModel viewModel;

        /// <summary>
        /// The index of Tab Control
        /// </summary>
        private int tabIndex;

        public int TabIndex
        {
            get { return tabIndex; }
            set { tabIndex = value; OnPropertyChanged("TabIndex"); }
        }

        private BranchProductService _branchProductService { get; set; }

        #endregion

        #region Commands

        private ICommand UpdateViewCommand;

        #endregion

        #region Helper Methods
        /// <summary>
        /// The function to search
        /// </summary>
        public void Search()
        {
            switch (TabIndex)
            {
                case 0:


                break;
            }

        }

        #endregion

    }
}
