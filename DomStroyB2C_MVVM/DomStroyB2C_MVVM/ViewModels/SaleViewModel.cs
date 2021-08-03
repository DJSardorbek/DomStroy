using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using System;
using System.Data;
using System.Windows.Input;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class SaleViewModel : BaseViewModel
    {
        #region Switching windows
        // The command, it switches views
        public ICommand UpdateViewCommand { get; set; }

        // A value inherite from MainWindowViewModel
        private MainWindowViewModel mainWindow;

        #endregion

        #region Constructor

        /// <summary>
        /// constructor for switching views
        /// </summary>
        public SaleViewModel(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            ObjDbAccess = new DBAccess();
            started_shop = GetShop() > 0;
            ProductList = new List<productDTO>();
            BasketList = new List<cartDTO>();
            searchCommand = new RelayCommand(SearchProduct);
            moveBasket = new RelayCommand(GetToBasket);
            deleteCartCommand = new RelayCommand(DeleteCart);
            updateCartProductCommand = new RelayCommand(ChangeCartProduct);
            cancelShopCommand = new RelayCommand(CancelShop);
            moveOrderCommand = new RelayCommand(AddOrder);
            TbProduct = new DataTable();
            TbBasket = new DataTable();
            ProductGridVisibility = Visibility.Hidden;
            GetProductFirst();
            GetBasketList();
            SumSomDollar();
        }
        #endregion

        #region Private Fields

        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged("Search");}
        }

        /// <summary>
        /// The collaction of product list
        /// </summary>
        private List<productDTO> productList;

        public List<productDTO> ProductList
        {
            get { return productList; }
            set { productList = value; OnPropertyChanged("ProductList"); }
        }

        /// <summary>
        /// The product which is going to join product list
        /// </summary>
        private productDTO product;

        public productDTO Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged("Product"); }
        }

        /// <summary>
        /// The collaction of basket list
        /// </summary>
        private List<cartDTO> basketList;

        /// <summary>
        /// The basket which is going to change
        /// </summary>
        public List<cartDTO> BasketList
        {
            get { return basketList; }
            set { basketList = value; OnPropertyChanged("BasketList"); }
        }

        private cartDTO basket;

        public cartDTO Basket
        {
            get { return basket; }
            set { basket = value; OnPropertyChanged("Basket"); }
        }


        /// <summary>
        /// The message to display progress
        /// </summary>
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
            set { objDbAccess = value; }
        }

        private DataTable tbProduct;

        public DataTable TbProduct
        {
            get { return tbProduct; }
            set { tbProduct = value; }
        }

        private DataTable tbBasket;

        public DataTable TbBasket
        {
            get { return tbBasket; }
            set { tbBasket = value; }
        }


        private Visibility productGridVisibility;
        public Visibility ProductGridVisibility
        {
            get { return productGridVisibility; }
            set { productGridVisibility = value; OnPropertyChanged("ProductGridVisibility"); }
        }

        /// <summary>
        /// Total sum of som
        /// </summary>
        private double sumSom;

        public double SumSom
        {
            get { return sumSom; }
            set { sumSom = value; OnPropertyChanged("SumSom"); }
        }

        /// <summary>
        /// Total sum of dollar
        /// </summary>
        private double sumDollar;

        public double SumDollar
        {
            get { return sumDollar; }
            set { sumDollar = value; OnPropertyChanged("SumDollar"); }
        }


        #endregion

        #region Commands
        /// <summary>
        /// The command for inserting new product
        /// </summary>
        private RelayCommand moveBasket;
        public RelayCommand MoveBasket
        {
            get { return moveBasket; }
        }

        /// <summary>
        /// The command for updating product
        /// </summary>
        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }


        /// <summary>
        /// The command for search product
        /// </summary>

        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }


        private RelayCommand moveOrderCommand;

        public RelayCommand MoveOrderCommand
        {
            get { return moveOrderCommand; }
        }


        /// <summary>
        /// The command it updates cart and product tables
        /// </summary>
        private RelayCommand updateCartProductCommand;

        public RelayCommand UpdateCartProductCommand
        {
            get { return updateCartProductCommand; }
        }

        /// <summary>
        /// The command it deletes product from cart
        /// </summary>
        private RelayCommand deleteCartCommand;

        public RelayCommand DeleteCartCommand
        {
            get { return deleteCartCommand; }
        }
        
        /// <summary>
        /// The command it cancels shop
        /// </summary>
        private RelayCommand cancelShopCommand;

        public RelayCommand CancelShopCommand
        {
            get { return cancelShopCommand; }
        }

        #endregion

        #region Public Fields

        /// <summary>
        /// The value to know is the shop started or not
        /// </summary>
        public static bool started_shop = false;

        #endregion

        #region Helper Functions

        // The function that gets first product from database
        public void GetProductFirst()
        {
            string queryProduct = "select product.*, category.name as category_name from product " +
                                  "inner join category on product.category=category.id limit 1";
            tbProduct.Clear();
            ObjDbAccess.readDatathroughAdapter(queryProduct, tbProduct);

            ConvertProductTableToList();

            tbProduct.Dispose();
        }

        // The function that searchs product
        public void SearchProduct()
        {
            if (Search.Length > 1)
            {
                string querySearchProduct = "select product.*, category.name as category_name from product " +
                                            "inner join category on product.category=category.id " +
                                            "where product.name like '%" + Search + "%' " +
                                            "or product.barcode like '%" + Search + "%' " +
                                            "or product.producer like '" + Search + "%' ";
                tbProduct.Clear();
                ObjDbAccess.readDatathroughAdapter(querySearchProduct, tbProduct);

                ConvertProductTableToList();
                ProductGridVisibility = Visibility.Visible;
            }
            else
            {
                ProductGridVisibility = Visibility.Hidden;
                GetProductFirst();
            }
        }

        // The function it converts DataTable to List
        public void ConvertProductTableToList()
        {
            ProductList = (from DataRow pr in tbProduct.Rows
                           select new productDTO()
                           {
                               Id = Convert.ToInt32(pr["id"]),
                               Product_id = Convert.ToInt32(pr["product_id"]),
                               Name = pr["name"].ToString(),
                               Measurement = pr["measurement"].ToString(),
                               Amount = Convert.ToDouble(pr["amount"]),
                               Section = Convert.ToInt32(pr["section"]),
                               Branch = Convert.ToInt32(pr["branch"]),
                               Barcode = pr["barcode"].ToString(),
                               Producer = pr["producer"].ToString(),
                               Deliver = Convert.ToInt32(pr["deliver"]),
                               Currency = pr["currency"].ToString(),
                               Cost = Convert.ToDouble(pr["cost"]),
                               Selling_price = Convert.ToDouble(pr["selling_price"]),
                               Expire_date = pr["expire_date"].ToString(),
                               Category = pr["category_name"].ToString(),
                               Ball = Convert.ToDouble(pr["ball"])
                           }).ToList();
        }

        // The Method to get data from cart table
        public void GetBasketList()
        {
            int shop = GetShop();
            //using(DataTable tbShopId = new DataTable())
            //{
            //    string queryShopId = "select shopid.shop from shopid inner join staff on shopid.password = staff.password " +
            //        "where staff.password='"+MainWindowViewModel.user_password+"'";
            //    ObjDbAccess.readDatathroughAdapter(queryShopId, tbShopId);
            //    shop = Convert.ToInt32(tbShopId.Rows[0]["shop"]);
            //}
            string queryBasket = "select cart.*, product.name, product.producer, product.measurement, product.selling_price, product.currency from cart " +
                "inner join product on cart.product = product.product_id " +
                "where cart.shop ='" + shop + "' order by cart.id";
            tbBasket.Clear();
            objDbAccess.readDatathroughAdapter(queryBasket, TbBasket);

            ConvertBasketTableToList();

            TbBasket.Dispose();
        }

        // The converter that converts BasketTable to List
        public void ConvertBasketTableToList()
        {
            BasketList = (from DataRow b in TbBasket.Rows
                          select new cartDTO()
                          {
                              Id = Convert.ToInt32(b["id"]),
                              Product = Convert.ToInt32(b["product"]),
                              Name = b["name"].ToString(),
                              Producer = b["producer"].ToString(),
                              Measurement = b["measurement"].ToString(),
                              Selling_price = Convert.ToDouble(b["selling_price"]),
                              Currency = b["currency"].ToString(),
                              Amount = Convert.ToDouble(b["amount"]),
                              Sum = Convert.ToDouble(b["sum"]),
                              Shop = Convert.ToInt32(b["shop"])
                          }).ToList();
        }

        // The method that opens basket window
        public void GetToBasket()
        {
            if (Product != null)
            {
                Start_shop();
                int shop = GetShop();
                BasketView basketView = new BasketView()
                {
                    DataContext = new BasketViewModel(Product, shop)
                };
                basketView.ShowDialog();
                Search = string.Empty;
                GetBasketList();
                SumSomDollar();
            }
            //System.Windows.MessageBox.Show(Product.Name.ToString());
        }

        // The method to get shop id
        public int GetShop()
        {
            int shop = 0;
            using (DataTable tbShopId = new DataTable())
            {
                string queryShopId = "select shopid.shop from shopid inner join staff on shopid.password = staff.password " +
                    "where staff.password='"+MainWindowViewModel.user_password+"'";
                ObjDbAccess.readDatathroughAdapter(queryShopId, tbShopId);
                if (tbShopId.Rows.Count > 0)
                    shop = Convert.ToInt32(tbShopId.Rows[0]["shop"]);
                else
                    shop = 0;
            }
            return shop;
        }

        // Create a shop if the shop is not started
        public void Start_shop()
        {
            if(started_shop == false)
            {
                // Creating new shop
                MySqlCommand cmdCreate = new MySqlCommand("insert into shop (seller, client, card, transfer, cash_sum, cash_dollar, loan_sum, loan_dollar, " +
                    "discount_sum, discount_dollar, traded_at, status_server, status_payment, queue, debt, book, total_sum, total_dollar) " +
                    "values('"+MainWindowViewModel.user_id+"', 1, 0, 0, 0, 0, 0, 0, 0, 0, '"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"', 0, 0, 0, 0, 0, 0, 0)");
                ObjDbAccess.executeQuery(cmdCreate);
                cmdCreate.Dispose();
                
                // Getting the shop which is just created
                int new_shop = 0;
                using(DataTable tbGetNewShopId = new DataTable())
                {
                    string queryGetNewShopId = "select id from shop order by id desc limit 1";
                    ObjDbAccess.readDatathroughAdapter(queryGetNewShopId, tbGetNewShopId);
                    new_shop = Convert.ToInt32(tbGetNewShopId.Rows[0]["id"]);
                }

                // After creating shop, we insert shop to shopid table
                int id = 1;
                using(DataTable tbShopId = new DataTable())
                {
                    string queryToGetShopId = "select * from shopid order by id desc limit 1";
                    ObjDbAccess.readDatathroughAdapter(queryToGetShopId, tbShopId);
                    if(tbShopId.Rows.Count == 1)
                    {
                        id = Convert.ToInt32(tbShopId.Rows[0]["id"]) + 1;
                    }
                }

                using (DataTable tbStaffShop = new DataTable())
                {
                    // Getting employee's shopid
                    string queryToGetStaffShop = "select * from shopid where password='"+MainWindowViewModel.user_password+"'";
                    ObjDbAccess.readDatathroughAdapter(queryToGetStaffShop, tbStaffShop);

                    // If this employee doesn't have shopid, we insert new shopid for him
                    if(tbStaffShop.Rows.Count == 0)
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into shopid (id, shop, password) " +
                            "values('"+id+"', '" + new_shop + "', '" + MainWindowViewModel.user_password + "')");
                        objDbAccess.executeQuery(cmd);
                        cmd.Dispose();
                    }

                    // If this employee has, we update it to new one
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("update shopid set shop='" + new_shop + "' where password='" + MainWindowViewModel.user_password + "'");
                        objDbAccess.executeQuery(cmd);
                        cmd.Dispose();
                    }
                }
                started_shop = true;
            }
        }

        /// <summary>
        /// The function to compute sum of total products
        /// </summary>
        public void SumSomDollar()
        {
            using(DataTable tbSum = new DataTable())
            {

                string sum = "sum"/*, dollar = "$"*/;

                string querySumSom = "select sum(cart.sum) from cart " +
                    "inner join product on cart.product = product.product_id " +
                    "inner join shop on cart.shop = shop.id " +
                    "where product.currency='" + sum + "' and cart.shop='" + GetShop() + "'";
                objDbAccess.readDatathroughAdapter(querySumSom, tbSum);

                if(!string.IsNullOrEmpty(tbSum.Rows[0]["sum(cart.sum)"].ToString()))
                {
                    SumSom = double.Parse(tbSum.Rows[0]["sum(cart.sum)"].ToString());
                }
                else
                {
                    SumSom = 0;
                }
                tbSum.Clear();

                //string querySumDollar = "select sum(cart.sum) from cart " +
                //    "inner join product on cart.product = product.product_id " +
                //    "inner join shop on cart.shop = shop.id " +
                //    "where product.currency='" + dollar + "' and cart.shop='" + GetShop() + "'";
                //if (tbSum.Rows.Count == 1)
                //{
                //    SumDollar = double.Parse(tbSum.Rows[0]["sum(cart.sum)"].ToString());
                //}
                //tbSum.Clear();
            }
        }

        /// <summary>
        /// The function that update product and cart tables
        /// </summary>
        public void ChangeCartProduct()
        {
            try
            {
                // changed amount of cart
                double enteredAmount = double.Parse(DoubleToStr(Basket.Amount));

                // Checking amount if it is not correct
                if(enteredAmount <=0)
                {
                    System.Windows.MessageBox.Show("Noto'g'ri miqdor kiritildi!");
                    GetBasketList();
                    return;
                }

                // changed sum of cart
                double changedSum = enteredAmount * Basket.Selling_price;
                
                // the amount of product of product table
                double productAmount = 0;
                // the amount of product of cart table
                double productCartAmount = 0;
                using(DataTable tbProduct = new DataTable())
                {
                    string queryProduct = "select amount from product where product_id='" + Basket.Product + "'";
                    ObjDbAccess.readDatathroughAdapter(queryProduct, tbProduct);
                    productAmount = double.Parse(tbProduct.Rows[0]["amount"].ToString());
                    
                    tbProduct.Clear();
                    string queryBasketAmount = "select amount from cart where id='" + Basket.Id + "'";
                    ObjDbAccess.readDatathroughAdapter(queryBasketAmount, tbProduct);
                    productCartAmount = double.Parse(tbProduct.Rows[0]["amount"].ToString());
                }

                // Checking amount if it is not enough
                if (enteredAmount > productAmount + productCartAmount)
                {
                    System.Windows.MessageBox.Show("Noto'g'ri miqdor kiritildi!");
                    GetBasketList();
                    return;
                }

                // changed amount of product
                double changedAmount = productAmount - enteredAmount + productCartAmount;

                // The command it updates product table
                MySqlCommand cmdUpdateProduct = new MySqlCommand("update product set amount='" + DoubleToStr(changedAmount) + "' where product.product_id='" + Basket.Product + "'");
                objDbAccess.executeQuery(cmdUpdateProduct);
                cmdUpdateProduct.Dispose();

                // The command it updates cart table
                MySqlCommand cmd = new MySqlCommand("update cart set sum='" + DoubleToStr(changedSum) + "', amount='" + DoubleToStr(enteredAmount) + "' where cart.id='" + Basket.Id + "'");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                SumSomDollar();
                GetBasketList();
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            //System.Windows.MessageBox.Show(Basket.Amount.ToString());
        }

        /// <summary>
        /// The function to convert double value to string
        /// </summary>
        /// <param name="doubleValue"></param>
        /// <returns></returns>
        public string DoubleToStr(double doubleValue)
        {
            string str = doubleValue.ToString();
            if (str.Contains(","))
                str.Replace(",", ".");
            return str; 
        }

        /// <summary>
        /// The function to delete product from cart
        /// </summary>
        public void DeleteCart()
        {
            // Delete product from cart
            MySqlCommand cmdDeleteCart = new MySqlCommand("delete from cart where id='" + Basket.Id + "'");
            objDbAccess.executeQuery(cmdDeleteCart);
            cmdDeleteCart.Dispose();

            // Getting deleted amount
            double deletedAmount = Basket.Amount;
            double productAmount = 0;
            using(DataTable tbProduct = new DataTable())
            {
                string queryProduct = "select amount from product where product_id='" + Basket.Product + "'";
                ObjDbAccess.readDatathroughAdapter(queryProduct, tbProduct);
                productAmount = double.Parse(tbProduct.Rows[0]["amount"].ToString());
            }

            // compute changed amount of product
            double changedAmount = productAmount + deletedAmount;

            // Updating product to the changed amount
            MySqlCommand cmdDeleteProduct = new MySqlCommand("update product set amount='" + DoubleToStr(changedAmount) + "' where product_id='" + basket.Product + "'");
            ObjDbAccess.executeQuery(cmdDeleteProduct);
            cmdDeleteProduct.Dispose();

            GetBasketList();
            SumSomDollar();
        }

        /// <summary>
        /// The function to cancel shop
        /// </summary>
        public void CancelShop()
        {
            if (tbBasket.Rows.Count == 0) return;
            else
            {
                // Updating amount of product of product table
                DataTable tbProduct = new DataTable();
                MySqlCommand cmdUpdateProduct;
                double deletedAmount = 0, productAmount = 0, changedAmount = 0;
                int shop = 0;
                for(int i = 0; i < tbBasket.Rows.Count; i++)
                {
                    deletedAmount = double.Parse(tbBasket.Rows[i]["amount"].ToString());
                    string queryProduct = "select amount from product where product_id='" + tbBasket.Rows[i]["product"] + "'";
                    ObjDbAccess.readDatathroughAdapter(queryProduct, tbProduct);
                    productAmount = double.Parse(tbProduct.Rows[0]["amount"].ToString());
                    changedAmount = deletedAmount + productAmount;

                    cmdUpdateProduct = new MySqlCommand("update product set amount='" + DoubleToStr(changedAmount) + "' where product_id='"+tbBasket.Rows[i]["product"]+"'");
                    objDbAccess.executeQuery(cmdUpdateProduct);
                    tbProduct.Clear();
                    cmdUpdateProduct.Dispose();
                    shop = int.Parse(tbBasket.Rows[i]["shop"].ToString());
                }

                // The command it deletes shop from cart table
                MySqlCommand cmd = new MySqlCommand("delete from cart where shop='" + shop + "'");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                // The command it deletes shop from shop table
                cmd = new MySqlCommand("delete from shop where id='" + shop + "'");
                objDbAccess.executeQuery(cmd);
                cmd.Dispose();

                // The command it updates shop of shopid table
                cmd = new MySqlCommand("update shopid set shop=0 where password='" + MainWindowViewModel.user_password + "'");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                MessageBox.Show("Tovarlar bekor qilindi!");
                started_shop = false;
                GetBasketList();
                SumSomDollar();
            }
        }

        /// <summary>
        /// The function to move client to order list
        /// </summary>
        public void AddOrder()
        {
            int shop = GetShop();
            if (shop != 0 && BasketList.Count > 0)
            {
                ComentView commentView = new ComentView();
                commentView.DataContext = new ComentViewModel(shop, SumSom, SumDollar,commentView);
                commentView.ShowDialog();

                if (GetShop() == 0)
                {
                    started_shop = false;
                    GetBasketList();
                    SumSomDollar();
                }
            }
            else
                return;
        }
    }
    #endregion
}
