using System.Collections.Generic;
using System.Windows.Input;
using DomStroyB2C_MVVM.API.InvoiceItem_sended;
using DomStroyB2C_MVVM.API.InvoiceItem_sended.InvoiceItemService;
using DomStroyB2C_MVVM.Commands;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media.Effects;
using System.Threading;
using DomStroyB2C_MVVM.Views.Loading;
using DomStroyB2C_MVVM.Views;
using System;
using DomStroyB2C_MVVM.Views.ModalViews;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using LoadingView = DomStroyB2C_MVVM.Views.ModalViews.LoadingView;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class SeeFakturaViewModel : BaseViewModel
    {
        #region Constructor

        public SeeFakturaViewModel(MainWindowViewModel viewModel, SeeFakturaView view, int Id)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);

            this.Id = Id;
            this.InvoiceItemView = view;

            _invoiceItemService = new InvoiceItem_sendedService();
            GetInvoiceItemListAsync();
            backToInvoiceCommand = new RelayCommand(ComeBackToInvoice);


        }

        #endregion

        #region Private Filds

        /// <summary>
        /// The main window view model
        /// </summary>
        private MainWindowViewModel viewModel;

        /// <summary>
        /// invoice item service to do crud operations
        /// </summary>
        private InvoiceItem_sendedService _invoiceItemService { get; set; }

        /// <summary>
        /// The invoice item view
        /// </summary>
        private SeeFakturaView InvoiceItemView { get; set; }

        /// <summary>
        /// Invoice id 
        /// </summary>
        private int Id { get; set; }

        /// <summary>
        /// Invoice item
        /// </summary>
        private InvoiceItem_sended invoiceItem;

        public InvoiceItem_sended InvoiceItem
        {
            get { return invoiceItem; }
            set { invoiceItem = value; OnPropertyChanged("InvoiceItem"); }
        }

        /// <summary>
        /// The list of invoice
        /// </summary>
        private List<InvoiceItem_sended> invoiceItemList;

        public List<InvoiceItem_sended> InvoiceItemList
        {
            get { return invoiceItemList; }
            set { invoiceItemList = value; OnPropertyChanged("InvoiceItemList"); }
        }


        #endregion

        #region Public Fields

        public static bool invoice_item = false;

        #endregion

        #region Commands

        /// <summary>
        /// The command to switch views
        /// </summary>
        private ICommand UpdateViewCommand { get; set; }

        /// <summary>
        /// The command to come back invoice view
        /// </summary>
        private RelayCommand backToInvoiceCommand;

        public RelayCommand BackToInvoiceCommand
        {
            get { return backToInvoiceCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get invoice item list
        /// </summary>
        public async void GetInvoiceItemListAsync()
        {
            LoadingView loading = new LoadingView();
            try
            {
                loading.Show();
                var content = await _invoiceItemService.GetAll(Id);
                
                InvoiceItemList = content.ToList();
                loading.Close();
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

        public void ComeBackToInvoice()
        {
            RecieveFakturaView recieveFakturaView = new RecieveFakturaView();

            RecieveFakturaViewModel recieveFakturaViewModel = new RecieveFakturaViewModel(viewModel, recieveFakturaView);

            viewModel.SelectedViewModel = recieveFakturaViewModel;

            viewModel.GridVisibility = true;
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

            InvoiceItemView.Effect = myEffect;

            using (LoadingWindow lw = new LoadingWindow(Simulator))
            {
                lw.ShowDialog();
            }
            myEffect.Radius = 0;

            InvoiceItemView.Effect = myEffect;
        }
        #endregion
    }
}
