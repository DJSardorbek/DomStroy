using DomStroyB2C_MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class MissedProductsViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommnad { get; set; }

        public MainWindowViewModel mainWindow;

        public MissedProductsViewModel(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
            UpdateViewCommnad = new UpdateViewCommand(mainWindow);
        }
    }
}
