using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DomStroyB2C_MVVM.API.Invoce_sended;
using DomStroyB2C_MVVM.API.Invoce_sended.Invoice_sendedService;
using DomStroyB2C_MVVM.API.InvoiceItem_sended;
using DomStroyB2C_MVVM.API.InvoiceItem_sended.InvoiceItemService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class RecieveFakturaViewModel : BaseViewModel
    {
        #region Constructor

        public RecieveFakturaViewModel(MainWindowViewModel viewModel, RecieveFakturaView invoice_view)
        {
            LoadingVisibility = Visibility.Collapsed;

            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);

            this.Invoice_view = invoice_view;

            _invoiceService = new Invoice_sendedService();

            
            _invoiceItemService = new InvoiceItem_sendedService();


            GetInvoiceListAsync();

            openInvoiceItemCommand = new RelayCommand(OpenInvoiceItem);

            cancelInvoiceCommand = new RelayCommand(CancelInvoiceAsync);

            ObjDbAccess = new DBAccess();

            recieveInvoiceCommand = new RelayCommand(RecieveInvoiceAsync);

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

        /// <summary>
        /// invoice item service 
        /// </summary>
        private InvoiceItem_sendedService _invoiceItemService { get; set; }

        private List<InvoiceItem_sended> invoiceItemList;

        public List<InvoiceItem_sended> InvoiceItemList
        {
            get { return invoiceItemList; }
            set { invoiceItemList = value; OnPropertyChanged("InvoiceItemList"); }
        }

        /// <summary>
        /// Data access
        /// </summary>
        public DBAccess ObjDbAccess { get; set; }

        /// <summary>
        /// The visibility variable to loadin gif animation
        /// </summary>
        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
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

        /// <summary>
        /// The command to cancel invoice 
        /// </summary>
        private RelayCommand cancelInvoiceCommand;
        
        public RelayCommand CancelInvoiceCommand
        {
            get { return cancelInvoiceCommand; }
        }

        /// <summary>
        /// The command to recieve invoice
        /// </summary>
        private RelayCommand recieveInvoiceCommand;

        public RelayCommand RecieveInvoiceCommand
        {
            get { return recieveInvoiceCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get invoice list
        /// </summary>
        public async void GetInvoiceListAsync()
        {
            //Views.ModalViews.LoadingView loading = new Views.ModalViews.LoadingView();

            try
            {
                //loading.Show();
                LoadingVisibility = Visibility.Visible;
                var response = await _invoiceService.GetAll();
                LoadingVisibility = Visibility.Collapsed;
                //loading.Close();
                InvoiceList = response.ToList();

                // if the invoice list is null
                if(InvoiceList.Count == 0)
                {
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Warning.png", "Hech qanday faktura topilmadi!")
                    };
                    message.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                //loading.Close();
                LoadingVisibility = Visibility.Collapsed;
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

        /// <summary>
        /// The function to cancel invoice
        /// </summary>
        public async void CancelInvoiceAsync()
        {
            Views.ModalViews.LoadingView loading = new Views.ModalViews.LoadingView();
            try
            {
                int id = Invoice.id;

                Invoice_status model = new Invoice_status()
                {
                    status = "cancelled"
                };

                loading.Show();
                var response = await _invoiceService.Patch(id, model);
                loading.Close();
                if (response)
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
                    loading.Close();
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
                    };

                    message.ShowDialog();
                }
            }
            catch (Exception ex)
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
        /// The fucntion to recieve invoice
        /// </summary>
        public async void RecieveInvoiceAsync()
        {
            Views.ModalViews.LoadingView loading = new Views.ModalViews.LoadingView();
            try
            {
                loading.Show();

                // First we get invoice item list
                var content = await _invoiceItemService.GetAll(Invoice.id);
                InvoiceItemList = content.ToList();

                // if the invoice item list is not null
                if (InvoiceList.Count > 0)
                {
                    // now we accept invoice
                    int id = Invoice.id;
                    Invoice_status model = new Invoice_status()
                    {
                        status = "accepted"
                    };
                    var response = await _invoiceService.Patch(id, model);
                    // if accept has successfuly done, we recieve products
                    if (response)
                    {
                        // Variables to get product information
                        string product_amount = string.Empty, queryToGetProduct = string.Empty;
                        double pr_amount = 0, in_amount = 0;
                        DataTable tbProduct = new DataTable();

                        MySqlCommand cmd;
                        foreach (var item in invoiceItemList)
                        {
                            // Query to get product
                            queryToGetProduct = $"SELECT amount, cost, selling_price, barcode FROM product WHERE barcode = '{item.product.barcode}'";
                            tbProduct.Clear();
                            ObjDbAccess.readDatathroughAdapter(queryToGetProduct, tbProduct);

                            // if that product is exist, we update it
                            if (tbProduct.Rows.Count > 0)
                            {
                                product_amount = tbProduct.Rows[0]["amount"].ToString();
                                pr_amount = double.Parse(product_amount);

                                in_amount = item.amount;
                                pr_amount += in_amount;
                                product_amount = DoubleToStr(pr_amount.ToString());

                                // The command to update product amount, cost, selling_price
                                cmd = new MySqlCommand($"UPDATE product set amount = '{product_amount}', cost = '{DoubleToStr(item.product.cost.ToString())}', " +
                                                       $"selling_price = '{DoubleToStr(item.selling_price.ToString())}' WHERE barcode = '{item.product.barcode}'");
                                ObjDbAccess.executeQuery(cmd);
                                cmd.Dispose();
                            }
                            // else if that product doesn't exist we insert it
                            else
                            {
                                string section = "1", expire_date = "";
                                if (Invoice.section != null) { section = Invoice.section.ToString(); }
                                if (item.product.expire_date != null) { expire_date = item.product.expire_date.ToString(); }
                                cmd = new MySqlCommand("INSERT INTO product " +
                                    "(product_id, name, measurement, amount, section, branch, barcode, producer, deliver, currency, cost, selling_price, expire_date, category, ball) VALUES " +
                                    $"('{item.product.id}', '{item.product.name}', '{item.product.measurement}', '{item.amount}', '{section}', '{Invoice.to_branch.id}', '{item.product.barcode}', " +
                                    $"'{item.product.producer}', '{Invoice.deliver}', '{item.product.currency}', '{item.product.cost}', '{item.selling_price}', '{expire_date}', '{item.product.category.id}', '{item.product.ball}')");
                                ObjDbAccess.executeQuery(cmd);
                                cmd.Dispose();
                            }
                        }

                        loading.Close();

                        // now we display message do display that invoice recieved successfully
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Success.png", "Faktura muvaffaqiyatli qabul qilindi!")
                        };
                        message.ShowDialog();

                        GetInvoiceListAsync();
                    }
                    // else if accept has not done, we display error message
                    else
                    {
                        loading.Close();
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
                        };

                        message.ShowDialog();
                    }
                }
                // else if status is bad, we display error message
                else
                {
                    loading.Close();
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
                    };

                    message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                loading.Close();
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", ex.Message)
                };

                message.ShowDialog();
            }
        }

        public string DoubleToStr(string s)
        {
            if(s.Contains(','))
            {
                s = s.Replace(',', '.');
            }
            return s;
        }

        #endregion
    }
}
