using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DomStroyB2C_MVVM.Commands;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class DoingInventoryViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }

        private MainWindowViewModel mainWindow;

        public DoingInventoryViewModel(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
        }
    }
}
