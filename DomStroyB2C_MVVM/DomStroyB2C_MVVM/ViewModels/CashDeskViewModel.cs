using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Input;
using System.Linq;
using System;
using DomStroyB2C_MVVM.Views;
using MySql.Data.MySqlClient;
using DomStroyB2C_MVVM.Views.ModalViews;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class CashDeskViewModel : BaseViewModel
    {
        #region Constructor

        public CashDeskViewModel(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            UpdateViewCommand = new UpdateViewCommand(viewModel);
            objDbAccess = new DBAccess();
            tbShop = new DataTable();
            ShopList = new List<shopDTO>();
            Shop = new shopDTO();
            GetShopList();
            openPaymentCommand = new RelayCommand(OpenPaymentView);
            cancelShopCommand = new RelayCommand(CancelShop);
        }

        #endregion

        #region Private Fields

        private MainWindowViewModel viewModel;

        /// <summary>
        /// The data table for shop
        /// </summary>
        private DataTable tbShop;

        public DataTable TbShop
        {
            get { return tbShop; }
        }

        /// <summary>
        /// The data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// Selected shop
        /// </summary>
        private shopDTO shop;

        public shopDTO Shop
        {
            get { return shop; }
            set { shop = value; OnPropertyChanged("Shop"); }
        }

        /// <summary>
        /// The list of shop
        /// </summary>
        private List<shopDTO> shopList;

        public List<shopDTO> ShopList
        {
            get { return shopList; }
            set { shopList = value; OnPropertyChanged("ShopList"); }
        }



        #endregion

        #region Commands

        private ICommand UpdateViewCommand { get; set; }

        /// <summary>
        /// The command to open open payment view
        /// </summary>
        private RelayCommand openPaymentCommand;

        public RelayCommand OpenPaymentCommand
        {
            get { return openPaymentCommand; }
        }

        private RelayCommand cancelShopCommand;

        public RelayCommand CancelShopCommand
        {
            get { return cancelShopCommand; }
        }


        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get product list
        /// </summary>
        public void GetShopList()
        {
            string queryToShop = "select shop.id, shop.comment, staff.first_name as seller, shop.total_sum, shop.total_dollar, shop.traded_at from shop " +
                "inner join staff on shop.seller = staff.id " +
                "where (shop.total_sum>0 or shop.total_dollar>0) and shop.debt=0 and shop.queue=0 and shop.book=0 and shop.status_payment=0 " +
                "and shop.id in(select distinct(shop) from cart inner join product on cart.product = product.product_id where product.section=" +
                "'"+MainWindowViewModel.section+"')";
            TbShop.Clear();
            ObjDbAccess.readDatathroughAdapter(queryToShop, TbShop);
            ConvertShopTableToList();

        }

        /// <summary>
        /// The function to cenvert shop datatable to list
        /// </summary>
        public void ConvertShopTableToList()
        {
            ShopList = (from DataRow dr in TbShop.Rows
                        select new shopDTO()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Comment = dr["comment"].ToString(),
                            Seller = dr["seller"].ToString(),
                            SumSom = Convert.ToDouble(dr["total_sum"]),
                            SumDollar = Convert.ToDouble(dr["total_dollar"]),
                            Date = Convert.ToDateTime(dr["traded_at"])
                        }).ToList();
        }

        /// <summary>
        /// The function to open payment view
        /// </summary>
        public void OpenPaymentView()
        {
            double total_sum = Shop.SumSom;
            int shop = Shop.Id;

            PaymentView paymentView = new PaymentView();

            PaymentViewModel paymentViewModel = new PaymentViewModel(paymentView);
            paymentViewModel.Total_sum = total_sum.ToString();
            paymentViewModel.Remembered_sum = total_sum.ToString();
            paymentViewModel.Shop = shop;

            paymentView.DataContext = paymentViewModel;

            paymentView.ShowDialog();

            GetShopList();
        }

        /// <summary>
        /// The function to cancel shop
        /// </summary>
        public void CancelShop()
        {
            if (TbShop.Rows.Count == 0) return;
            else
            {
                // Updating amount of product of product table
                DataTable tbProduct = new DataTable();
                MySqlCommand cmdUpdateProduct;
                double deletedAmount = 0, productAmount = 0, changedAmount = 0;

                // Getting cart list
                DataTable tbBasket = new DataTable();
                string queryToBasket = "select * from cart where shop='" + Shop.Id + "'";
                ObjDbAccess.readDatathroughAdapter(queryToBasket, tbBasket);
                int shop = 0;
                for (int i = 0; i < tbBasket.Rows.Count; i++)
                {
                    deletedAmount = double.Parse(tbBasket.Rows[i]["amount"].ToString());
                    string queryProduct = "select amount from product where product_id='" + tbBasket.Rows[i]["product"] + "'";
                    ObjDbAccess.readDatathroughAdapter(queryProduct, tbProduct);
                    productAmount = double.Parse(tbProduct.Rows[0]["amount"].ToString());
                    changedAmount = deletedAmount + productAmount;

                    cmdUpdateProduct = new MySqlCommand("update product set amount='" + DoubleToStr(changedAmount) + "' where product_id='" + tbBasket.Rows[i]["product"] + "'");
                    ObjDbAccess.executeQuery(cmdUpdateProduct);
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
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Success.png", "Tovarlar muvaffaqiyatli bekor qilindi!")
                };
                message.ShowDialog();

                GetShopList();
            }
        
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

        #endregion
    }
}
