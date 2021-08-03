using DomStroyB2C_MVVM.Commands;

using System.Windows.Input;


namespace DomStroyB2C_MVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        /// <summary>
        /// user_password and user_id of user
        /// </summary>
        public static string user_password = "";
        public static int user_id = 0;

        #region Constructor


        public MainWindowViewModel(MainWindow window)
        {
            this.window = window;
            GridVisibility = false;
            UpdateViewCommand = new UpdateViewCommand(this);

            BackMainMenuCommand = new RelayCommand(BackMainMenu);
            SelectedViewModel = new LoginViewModel(this, window);
        }

        #endregion


        #region private values

        private MainWindow window;

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }


        private bool _gVisibility;
        public bool GridVisibility
        {
            get { return _gVisibility; }
            set
            {
                _gVisibility = value;
                OnPropertyChanged("GridVisibility");
            }
        }

        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");

            }
        }

        #endregion


        #region Commands

        public ICommand UpdateViewCommand { get; set; }
        public ICommand BackMainMenuCommand { get; set; }

        #endregion

        #region Helper methods to Get and Post

        public void BackMainMenu()
        {
            this.SelectedViewModel = new MainViewModel(this, window);
            GridVisibility = true;
        }

        #endregion

    }
}
