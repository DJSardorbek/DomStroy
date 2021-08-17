using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;
using DomStroyB2C_MVVM.API.Invoce_sended;
using DomStroyB2C_MVVM.API.Invoce_sended.Invoice_sendedService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views;
using DomStroyB2C_MVVM.Views.Loading;

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

        public ICommand UpdateViewCommand { get; set; }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get invoice list
        /// </summary>
        public async void GetInvoiceListAsync()
        {
            var response = await _invoiceService.GetAll();
            LoadAnimation();
            InvoiceList = response.ToList();
        }

        #endregion

        #region Loadin animation
        // An effect that sets effect to the usercontrol ui
        BlurEffect myEffect = new BlurEffect();


        // Command that runs LoadAnimation function
        private ICommand loading { get; set; }

        public ICommand Loading
        {
            get { return loading; }
        }

        // A function that sets time to showing loading window
        void Simulator()
        {

            for (int i = 0; i < 80; i++)

                Thread.Sleep(5);
        }

        // A function that shows loading window
        public void LoadAnimation()
        {
            myEffect.Radius = 10;

            Invoice_view.Effect = myEffect;

            using (LoadingWindow lw = new LoadingWindow(Simulator))
            {
                lw.ShowDialog();
            }
            myEffect.Radius = 0;

            Invoice_view.Effect = myEffect;
        }
        #endregion
    }
}
