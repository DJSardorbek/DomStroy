using DomStroyB2C_MVVM.Commands;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class QueueViewModel : BaseViewModel
    {
        private ICommand UpdateViewCommand { get; set; }

        private MainWindowViewModel viewModel;

        public QueueViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
        }
    }
}
