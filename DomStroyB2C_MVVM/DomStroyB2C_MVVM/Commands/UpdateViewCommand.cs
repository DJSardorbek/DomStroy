using DomStroyB2C_MVVM.ViewModels;

using System;

using System.Windows.Input;

namespace DomStroyB2C_MVVM.Commands
{
    public class UpdateViewCommand : ICommand
    {

        /// <summary>
        /// Event handler
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// ViewModel of MainWindow
        /// </summary>
        public MainWindowViewModel viewModel;

        /// <summary>
        /// The command to switch windows
        /// </summary>
        /// <param name="viewModel"></param>

        public UpdateViewCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        /// <summary>
        /// Can execute method that allows to execute method
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>

        public bool CanExecute(object parameter)
        {
            return true;
        }


        #region Execute Method

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Loading")
            {
                viewModel.SelectedViewModel = new LoadingViewModel(viewModel);
            }


            if(parameter.ToString() == "Sale")
            {
                viewModel.GridVisibility = true;
                viewModel.SelectedViewModel = new SaleViewModel(viewModel);
            }
            if (parameter.ToString() == "ClientOrder")
            {
                viewModel.GridVisibility = false;
                viewModel.SelectedViewModel = new ClientOrderViewModel(viewModel);
            }
            if (parameter.ToString() == "ProductResidue")
            {
                viewModel.SelectedViewModel = new ProductResidueViewModel(viewModel);
            }
            if (parameter.ToString() == "RecieveFaktura")
            {
                viewModel.SelectedViewModel = new RecieveFakturaViewModel(viewModel);
            }
            if (parameter.ToString() == "SeeFaktura")
            {
                viewModel.SelectedViewModel = new SeeFakturaViewModel(viewModel);
            }
            if (parameter.ToString() == "Debtors")
            {
                viewModel.SelectedViewModel = new DebtorsViewModel(viewModel);
            }
            if (parameter.ToString() == "DebtorsPayHistory")
            {
                viewModel.SelectedViewModel = new DebtorsPayHistoryViewModel(viewModel);
            }
            if (parameter.ToString() == "FakturaReport")
            {
                viewModel.SelectedViewModel = new FakturaReportViewModel(viewModel);
            }
            if (parameter.ToString() == "Orders")
            {
                viewModel.SelectedViewModel = new OrdersViewModel(viewModel);
            }
            if (parameter.ToString() == "Report")
            {
                viewModel.SelectedViewModel = new ReportViewModel(viewModel);
            }
            if (parameter.ToString() == "ProductRetun")
            {
                viewModel.SelectedViewModel = new ProductReturnViewModel(viewModel);
            }
            if (parameter.ToString() == "CashDesk")
            {
                viewModel.SelectedViewModel = new CashDeskViewModel(viewModel);
            }
            if (parameter.ToString() == "Queue")
            {
                viewModel.SelectedViewModel = new QueueViewModel(viewModel);
            }
            if (parameter.ToString() == "ProductMovement")
            {
                viewModel.SelectedViewModel = new ProductMovementViewModel(viewModel);
            }
            if (parameter.ToString() == "Inventory")
            {
                viewModel.GridVisibility = true;
                viewModel.SelectedViewModel = new InventoryViewModel(viewModel);
            }
            if (parameter.ToString() == "DoingInventory")
            {
                viewModel.GridVisibility = false;
                viewModel.SelectedViewModel = new DoingInventoryViewModel(viewModel);
            }
            if (parameter.ToString() == "MissedProducts")
            {
                viewModel.GridVisibility = false;
                viewModel.SelectedViewModel = new MissedProductsViewModel(viewModel);
            }
            if (parameter.ToString() == "Settings")
            {
                viewModel.GridVisibility = true;
                viewModel.SelectedViewModel = new SettingViewModel(viewModel);
            }

            if (parameter.ToString() == "SeeEmployee")
            {
                viewModel.GridVisibility = false;
                viewModel.SelectedViewModel = new SeeEmployeeViewModel(viewModel);
            }
        }

        #endregion

    }
}
