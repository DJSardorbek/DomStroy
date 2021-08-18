using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;
using DomStroyB2C_MVVM.API.Invoce_sended;
using DomStroyB2C_MVVM.API.Invoce_sended.Invoice_sendedService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views;
using DomStroyB2C_MVVM.Views.Loading;
using DomStroyB2C_MVVM.Views.ModalViews;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class RecieveFakturaViewModel : BaseViewModel
    {
        #region Constructor

        public RecieveFakturaViewModel(MainWindowViewModel viewModel, RecieveFakturaView invoice_view)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);

            this.Invoice_view = invoice_view;

            _invoiceService = new Invoice_sendedService();
            
            GetInvoiceListAsync();

            openInvoiceItemCommand = new RelayCommand(OpenInvoiceItem);

            cancelInvoiceCommand = new RelayCommand(CancelInvoiceAsync);

        }

        #endregion

        #region Private Fields

        /// <summary>
        /// Main window's view model
        /// </summary>
        private MainWindowViewModel viewModel;

        private RecieveFakturaView Invoice_view { get; set; }

        /// <summary>
        /// The invoice servise to do crud operation
        /// </summary>
        private Invoice_sendedService _invoiceService { get; set; }

        /// <summary>
        /// The list of invoice
        /// </summary>
        private List<Invoice_sendedModel> invoiceList;

        public List<Invoice_sendedModel> InvoiceList
        {
            get { return invoiceList; }
            set { invoiceList = value; OnPropertyChanged("InvoiceList"); }
        }

        /// <summary>
        /// The selected invoice
        /// </summary>
        private Invoice_sendedModel invoice;

        public Invoice_sendedModel Invoice
        {
            get { return invoice; }
            set { invoice = value; OnPropertyChanged("Invoice"); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to switch view
        /// </summary>
        public ICommand UpdateViewCommand { get; set; }

        /// <summary>
        /// The command to open invoice item view
        /// </summary>
        private RelayCommand openInvoiceItemCommand;

        public RelayCommand OpenInvoiceItemCommand
        {
            get { return openInvoiceItemCommand; }
        }

        private RelayCommand cancelInvoiceCommand;

        public RelayCommand CancelInvoiceCommand
        {
            get { return cancelInvoiceCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get invoice list
        /// </summary>
        public async void GetInvoiceListAsync()
        {
            Views.ModalViews.LoadingView loading = new Views.ModalViews.LoadingView();
            
            try
            {
                loading.Show();
                var response = await _invoiceService.GetAll();
                loading.Close();
                InvoiceList = response.ToList();
                
            }
            catch(Exception ex)
            {
                loading.Close();

                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", ex.Message)
                };
                message.ShowDialog();
            }
            
        }

        /// <summary>
        /// The function to open invoice item view
        /// </summary>
        public void OpenInvoiceItem()
        {
            SeeFakturaView seeFakturaView = new SeeFakturaView();

            SeeFakturaViewModel seeFakturaViewModel = new SeeFakturaViewModel(viewModel, seeFakturaView, Invoice.id);

            viewModel.SelectedViewModel = seeFakturaViewModel;
            viewModel.GridVisibility = false;
        }

        public async void CancelInvoiceAsync()
        {
            CancelInvoice cancelInvoice = new CancelInvoice()
            {
                id = Invoice.id,
                status = "cancelled"
            };

            var response = await _invoiceService.Post(cancelInvoice);

            if(response)
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Success.png", "Faktura muvaffaqiyatli bekor qilindi!")
                };

                message.ShowDialog();

                GetInvoiceListAsync();
            }

            else
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
                };

                message.ShowDialog();
            }
        }

        #endregion
    }
}
