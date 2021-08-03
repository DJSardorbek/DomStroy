using DomStroyB2C_MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class InventoryViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }

        private MainWindowViewModel mainWindow;

        public InventoryViewModel(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
        }
    }
}
