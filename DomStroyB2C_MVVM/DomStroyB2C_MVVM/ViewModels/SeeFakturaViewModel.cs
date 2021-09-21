using System.Collections.Generic;
using System.Windows.Input;
using DomStroyB2C_MVVM.API.InvoiceItem_sended;
using DomStroyB2C_MVVM.API.Invoce_sended;
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
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class SeeFakturaViewModel : BaseViewModel
    {
        #region Constructor

        public SeeFakturaViewModel(MainWindowViewModel viewModel, SeeFakturaView view, Result invoice)
        {
            LoadingVisibility = Visibility.Collapsed;

            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);

            this.Invoice = invoice;
            this.Id = invoice.id;
            this.Recieve_name = invoice.name;
            this.InvoiceItemView = view;

            _invoiceItemService = new InvoiceItem_sendedService();
            GetInvoiceItemListAsync();
            ObjDbAccess = new DBAccess();
            backToInvoiceCommand = new RelayCommand(ComeBackToInvoice);

            SelectAllCommand = new RelayCommand(SelectAll);
            UnSelectAllCommand = new RelayCommand(UnSelectAll);

            RecieveInvoiceCommand = new RelayCommand(RecieveInvoiceAsync);

            TestCommand = new RelayCommand(Test);
            accept_all = false;

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

        public string Recieve_name { get; set; }
        public DBAccess ObjDbAccess { get; set; }

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
        /// The selected invoice
        /// </summary>
        private Result invoice;

        public Result Invoice
        {
            get { return invoice; }
            set { invoice = value; OnPropertyChanged("Invoice"); }
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

        /// <summary>
        /// The visibility variable to loadin gif animation
        /// </summary>
        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }

        private bool _accept_all;

        public bool accept_all
        {
            get { return _accept_all; }
            set { _accept_all = value; OnPropertyChanged("accept_all"); }
        }


        #endregion

        #region Public Fields

        public static bool invoice_item = false;

        public static string Expanse { get; set; }

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

        public RelayCommand TestCommand { get; set; }

        public RelayCommand SelectAllCommand { get; set; }
        public RelayCommand UnSelectAllCommand { get; set; }

        public RelayCommand RecieveInvoiceCommand { get; set; }

        #endregion

        #region Helper Methods

        public void Test()
        {
            int count = 0;
            foreach(var item in InvoiceItemList)
            {
                if (item.enabled && item.accepted)
                { count++; }
            }
            MessageBox.Show($"{InvoiceItem.accepted.ToString()} count : {count}");


        }

        /// <summary>
        /// The function to get invoice item list
        /// </summary>
        public async void GetInvoiceItemListAsync()
        {
            //LoadingView loading = new LoadingView();
            try
            {
                LoadingVisibility = Visibility.Visible;
                var content = await _invoiceItemService.GetAll(Id);
                
                InvoiceItemList = content.ToList();
                LoadingVisibility = Visibility.Collapsed;
                SetStatus();

            }
            catch(Exception ex)
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

        public void ComeBackToInvoice()
        {
            RecieveFakturaView recieveFakturaView = new RecieveFakturaView();

            RecieveFakturaViewModel recieveFakturaViewModel = new RecieveFakturaViewModel(viewModel, recieveFakturaView);

            viewModel.SelectedViewModel = recieveFakturaViewModel;

            viewModel.GridVisibility = true;
        }

        public void SetStatus()
        {
            if(InvoiceItemList.Count>0)
            foreach(var item in InvoiceItemList)
            {
                switch(item.status)
                {
                        case "send": item.accepted = false; item.enabled = true;
                        break;
                        case "accepted": item.accepted = true; item.enabled = false;
                        break;
                        default: item.accepted = false; item.enabled = true;
                        break;
                }
            }
        }

        public async void RecieveInvoiceAsync()
        {
            try
            {
                //loading.Show();
                LoadingVisibility = Visibility.Visible;
                // First we get invoice item list it is done here
                //var content = await _invoiceItemService.GetAll(Invoice.id);
                //InvoiceItemList = content.ToList();

                // if the invoice item list is not null
                if (InvoiceItemList.Count > 0)
                {
                    InvoiceExpanseView expanseView = new InvoiceExpanseView();
                    expanseView.ShowDialog();
                    MessageBox.Show(Expanse);
                    // now we accept invoice

                    

                    // invoice_id
                    int id = Invoice.id;
                    
                    // invoice_list
                    List<int> invoice_list = new List<int>();

                    // recieved invoice items
                    List<InvoiceItem_sended> recieved_items = new List<InvoiceItem_sended>();

                    foreach (var item in InvoiceItemList)
                    {
                        if(item.enabled && item.accepted)
                        {
                            // add invoiceitem_id to invoice_list
                            invoice_list.Add(item.id);

                            // add invoiceitem to recived_items
                            recieved_items.Add(item);

                        }
                    }

                    Invoice_accept model = new Invoice_accept()
                    {
                        invoice_id = id,
                        invoice_list = invoice_list,
                        expense = Convert.ToDouble(Expanse)
                    };
                    string json = JsonConvert.SerializeObject(model);
                    MessageBox.Show(json);
                    var response = await _invoiceItemService.Post(id, model);
                    // if accept has successfuly done, we recieve products
                    if (response)
                    {
                        // Variables to get product information
                        string product_amount = string.Empty, queryToGetProduct = string.Empty;
                        double pr_amount = 0, in_amount = 0;
                        DataTable tbProduct = new DataTable();

                        MySqlCommand cmd;
                        foreach (var item in recieved_items)
                        {
                            // Query to get product
                            queryToGetProduct = $"SELECT amount, cost, selling_price, barcode, expire_date FROM product WHERE barcode = '{item.product.barcode}'";
                            tbProduct.Clear();
                            ObjDbAccess.readDatathroughAdapter(queryToGetProduct, tbProduct);

                            // if that product is exist, we update it
                            if (tbProduct.Rows.Count > 0)
                            {
                                //first we check the product if it's expire_date is not equal to new one
                                if (item.expire_date != null)
                                {
                                    //if expire_date is equal to new one, we update product amount, selling_price, cost
                                    if (item.expire_date.ToString() == tbProduct.Rows[0]["expire_date"].ToString())
                                    {
                                        product_amount = tbProduct.Rows[0]["amount"].ToString();
                                        pr_amount = double.Parse(product_amount);

                                        in_amount = item.amount;
                                        pr_amount += in_amount;
                                        product_amount = DoubleToStr(pr_amount.ToString());

                                        // The command to update product amount, cost, selling_price
                                        cmd = new MySqlCommand($"UPDATE product SET amount = '{product_amount}', cost = '{DoubleToStr(item.product.cost.ToString())}', " +
                                                               $"selling_price = '{DoubleToStr(item.selling_price.ToString())}' WHERE barcode = '{item.product.barcode}'");
                                        ObjDbAccess.executeQuery(cmd);
                                        cmd.Dispose();
                                    }
                                    //else if expire_date is not equal, but amount 0 we update product
                                    else if (item.expire_date.ToString() != tbProduct.Rows[0]["expire_date"].ToString()
                                        && double.Parse(tbProduct.Rows[0]["amount"].ToString()) == 0)
                                    {
                                        product_amount = tbProduct.Rows[0]["amount"].ToString();
                                        pr_amount = double.Parse(product_amount);

                                        in_amount = item.amount;
                                        pr_amount += in_amount;
                                        product_amount = DoubleToStr(pr_amount.ToString());

                                        // The command to update product amount, cost, selling_price
                                        cmd = new MySqlCommand($"UPDATE product SET amount = '{product_amount}', cost = '{DoubleToStr(item.product.cost.ToString())}', " +
                                                               $"selling_price = '{DoubleToStr(item.selling_price.ToString())}', expire_date = '{item.expire_date}' " +
                                                               $"WHERE barcode = '{item.product.barcode}'");
                                        ObjDbAccess.executeQuery(cmd);
                                        cmd.Dispose();
                                    }
                                    //else if expire_date is not equal and amount is not 0 we insert new product
                                    else
                                    {
                                        string section = "1", expire_date = "";
                                        int outInt;
                                        if (int.TryParse(Invoice.section.id.ToString(), out outInt)) { section = Invoice.section.id.ToString(); }
                                        if (item.expire_date != null) { expire_date = item.expire_date.ToString(); }
                                        cmd = new MySqlCommand("INSERT INTO product " +
                                            "(id, product_id, name, measurement, amount, section, branch, barcode, producer, deliver, currency, cost, selling_price, expire_date, category, ball) VALUES " +
                                            $"('{SetProductId()}', '{item.product.id}', '{item.product.name}', '{item.product.measurement}', '{item.amount}', '{section}', '{Invoice.to_branch.id}', " +
                                            $"'{item.product.barcode}', " +
                                            $"'{item.product.producer}', '{Invoice.deliver}', '{item.product.currency}', '{item.product.cost}', '{item.selling_price}', '{expire_date}', " +
                                            $"'{SetCategoryId(item.product.category.id, item.product.category.name)}', '{item.product.ball}')");
                                        ObjDbAccess.executeQuery(cmd);
                                        cmd.Dispose();
                                    }
                                }
                                //else if expire_date doesn't exist we update product
                                else
                                {
                                    product_amount = tbProduct.Rows[0]["amount"].ToString();
                                    pr_amount = double.Parse(product_amount);

                                    in_amount = item.amount;
                                    pr_amount += in_amount;
                                    product_amount = DoubleToStr(pr_amount.ToString());

                                    // The command to update product amount, cost, selling_price
                                    cmd = new MySqlCommand($"UPDATE product SET amount = '{product_amount}', cost = '{DoubleToStr(item.product.cost.ToString())}', " +
                                                           $"selling_price = '{DoubleToStr(item.selling_price.ToString())}' WHERE barcode = '{item.product.barcode}'");
                                    ObjDbAccess.executeQuery(cmd);
                                    cmd.Dispose();
                                }
                            }
                            // else if that product doesn't exist we insert it
                            else
                            {
                                string section = "1", expire_date = "";
                                int outInt;
                                if (int.TryParse(Invoice.section.id.ToString(), out outInt)) { section = Invoice.section.id.ToString(); }
                                if (item.expire_date != null) { expire_date = item.expire_date.ToString(); }
                                cmd = new MySqlCommand("INSERT INTO product " +
                                    "(id, product_id, name, measurement, amount, section, branch, barcode, producer, deliver, currency, cost, selling_price, expire_date, category, ball) VALUES " +
                                    $"('{SetProductId()}', '{item.product.id}', '{item.product.name}', '{item.product.measurement}', '{item.amount}', '{section}', '{Invoice.to_branch.id}', " +
                                    $"'{item.product.barcode}', " +
                                    $"'{item.product.producer}', '{Invoice.deliver}', '{item.product.currency}', '{item.product.cost}', '{item.selling_price}', '{expire_date}', " +
                                    $"'{SetCategoryId(item.product.category.id, item.product.category.name)}', '{item.product.ball}')");
                                ObjDbAccess.executeQuery(cmd);
                                cmd.Dispose();
                            }
                        }

                        //loading.Close();
                        LoadingVisibility = Visibility.Collapsed;
                        // now we display message do display that invoice recieved successfully
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Success.png", "Faktura muvaffaqiyatli qabul qilindi!")
                        };
                        message.ShowDialog();

                        //GetInvoiceListAsync();
                        ComeBackToInvoice();
                    }
                    // else if accept has not done, we display error message
                    else
                    {
                        //loading.Close();
                        LoadingVisibility = Visibility.Collapsed;
                        MessageView message = new MessageView()
                        {
                            DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
                        };

                        message.ShowDialog();
                    }
                }
                // else if invoice item list is null
                else
                {
                    //loading.Close();
                    LoadingVisibility = Visibility.Collapsed;
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan bog'lanishda xatolik!")
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

        // The function to convert double to string
        public string DoubleToStr(string s)
        {
            if (s.Contains(','))
            {
                s = s.Replace(',', '.');
            }
            return s;
        }

        /// <summary>
        /// The function to set id to product table
        /// </summary>
        /// <returns></returns>
        public int SetProductId()
        {
            int id = 1;
            string query = "SELECT id FROM product ORDER BY id DESC LIMIT 1";
            using (DataTable tb = new DataTable())
            {
                ObjDbAccess.readDatathroughAdapter(query, tb);
                //if table contains a row
                if (tb.Rows.Count == 1)
                {
                    id = Convert.ToInt32(tb.Rows[0]["id"].ToString());
                }
            }
            return id;
        }

        /// <summary>
        /// The function to set category to product
        /// </summary>
        /// <param name="category_id"></param>
        /// <param name="category_name"></param>
        /// <returns></returns>
        public int SetCategoryId(int category_id, string category_name)
        {
            int id = 1;
            string query = $"SELECT id FROM category WHERE id = '{category_id}'";
            using (DataTable tb = new DataTable())
            {
                ObjDbAccess.readDatathroughAdapter(query, tb);
                //if table contains a row
                if (tb.Rows.Count == 1)
                {
                    id = category_id;
                }
                //else if table doesn't exist a row
                else
                {
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO category (id, name) VALUES('{category_id}', '{category_name}')");
                    ObjDbAccess.executeQuery(cmd);
                    cmd.Dispose();
                    id = category_id;
                }
            }
            return id;
        }

        public void SelectAll()
        {
            accept_all = true;
            foreach (var item in InvoiceItemList)
            {
                if(item.enabled)
                {
                    item.accepted = true;
                }
            }
        }

        public void UnSelectAll()
        {
            accept_all = false;
            foreach (var item in InvoiceItemList)
            {
                if (item.enabled)
                {
                    item.accepted = false;
                }
            }
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
