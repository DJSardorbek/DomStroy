using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Constructor

        public MainViewModel(MainWindowViewModel mainWindow, MainWindow window)
        {
            this.mainWindow = mainWindow;
            this.Window = window;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            BackLoginCommand = new RelayCommand(BackLogin);
            openInvoiceCommand = new RelayCommand(OpenInvoice);
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to switch view
        /// </summary>
        public ICommand UpdateViewCommand { get; set; }

        /// <summary>
        /// The command to restart login
        /// </summary>
        public ICommand BackLoginCommand { get; set; }

        /// <summary>
        /// The command to open recieve view
        /// </summary>
        private RelayCommand openInvoiceCommand;

        public RelayCommand OpenInvoiceCommand
        {
            get { return openInvoiceCommand; }
        }

        #endregion

        #region Private Fields

        private MainWindowViewModel mainWindow;
        private MainWindow Window;

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to back login view
        /// </summary>
        public void BackLogin()
        {
            mainWindow.SelectedViewModel = new LoginViewModel(mainWindow, Window);
            mainWindow.GridVisibility = false;

        }

        /// <summary>
        /// The function to open Invoice view
        /// </summary>
        public void OpenInvoice()
        {
            RecieveFakturaView recieveFakturaView = new RecieveFakturaView();

            mainWindow.SelectedViewModel = new RecieveFakturaViewModel(mainWindow, recieveFakturaView);
        }

        #endregion
    }
}
