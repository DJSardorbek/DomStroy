
using DomStroyB2C_MVVM.ViewModels;
using System;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.Commands
{
    /// <summary>
    /// Base command that runs actions
    /// </summary>
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action mAction;
        private RelayCommand cancelInvoice;

        /// <summary>
        /// The constructor that sets value to mAction
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        public RelayCommand(RelayCommand cancelInvoice)
        {
            this.cancelInvoice = cancelInvoice;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
