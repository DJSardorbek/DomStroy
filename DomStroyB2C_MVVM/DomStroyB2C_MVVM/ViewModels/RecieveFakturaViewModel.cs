using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DomStroyB2C_MVVM.Commands;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class RecieveFakturaViewModel : BaseViewModel
    {
        private MainWindowViewModel viewModel;

        public ICommand UpdateViewCommand { get; set; }

        public RecieveFakturaViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);

        }
    }
}
