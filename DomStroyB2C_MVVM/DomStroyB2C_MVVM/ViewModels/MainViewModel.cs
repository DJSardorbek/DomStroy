using DomStroyB2C_MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }

        public ICommand BackLoginCommand { get; set; }

        private MainWindowViewModel mainWindow;
        private MainWindow Window;

        public MainViewModel(MainWindowViewModel mainWindow, MainWindow window)
        {
            this.mainWindow = mainWindow;
            this.Window = window;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            BackLoginCommand = new RelayCommand(BackLogin);
        }

        public void BackLogin()
        {
            mainWindow.SelectedViewModel = new LoginViewModel(mainWindow, Window);
            mainWindow.GridVisibility = false;

        }
    }
}
