using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DomStroyB2C_MVVM.Commands;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class SeeFakturaViewModel : BaseViewModel
    {
        private ICommand UpdateViewCommand { get; set; }

        private MainWindowViewModel viewModel;

        public SeeFakturaViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
        }
    }
}
