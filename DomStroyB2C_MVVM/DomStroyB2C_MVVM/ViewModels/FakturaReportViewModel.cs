﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DomStroyB2C_MVVM.Commands;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class FakturaReportViewModel : BaseViewModel
    {
        private ICommand UpdateViewCommand { get; set; }
        private MainWindowViewModel viewModel;

        public FakturaReportViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
        }
    }
}
