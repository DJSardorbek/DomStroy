using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DomStroyB2C_MVVM.ViewModels
{
    class QueueBuyurtmalarViewModel : BaseViewModel
    {
        #region Constructor

        public QueueBuyurtmalarViewModel()
        {
            objDbAccess = new DBAccess();
            tbBookTable = new DataTable();
            GetBookedList();
            cancelBookCommand = new RelayCommand(CancelBook);
            takeBookToBasketCommand = new RelayCommand(TakeToBasket);
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The booked shop
        /// </summary>
        private bookDTO book;

        public bookDTO Book
        {
            get { return book; }
            set { book = value; OnPropertyChanged("Book"); }
        }

        /// <summary>
        /// The list of booked shop
        /// </summary>
        private List<bookDTO> bookList;

        public List<bookDTO> BookList
        {
            get { return bookList; }
            set { bookList = value; OnPropertyChanged("BookList"); }
        }

        /// <summary>
        /// The data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        private DataTable tbBookTable;

        public DataTable TbBookTable
        {
            get { return tbBookTable; }
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to cancel book
        /// </summary>
        private RelayCommand cancelBookCommand;

        public RelayCommand CancelBookCommand
        {
            get { return cancelBookCommand; }
        }

        /// <summary>
        /// The command to take book to sale
        /// </summary>
        private RelayCommand takeBookToBasketCommand;

        public RelayCommand TakeBookToBasketCommand
        {
            get { return takeBookToBasketCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get list of booked shops
        /// </summary>
        public void GetBookedList()
        {
            string queryToGetBookedShop = "SELECT shop.id, staff.first_name, CONCAT(client.first_name, ' ', client.last_name) AS client_name, client.phone_1, shop.traded_at, shop.comment, shop.total_sum, shop.total_dollar " +
                "FROM shop INNER JOIN staff ON shop.seller = staff.id INNER JOIN client ON shop.client = client.id " +
                "WHERE shop.book = 1";
            TbBookTable.Clear();
            ObjDbAccess.readDatathroughAdapter(queryToGetBookedShop, TbBookTable);
            ConvertBookTableToList();
        }

        /// <summary>
        /// The function to convert book data table to list
        /// </summary>
        public void ConvertBookTableToList()
        {
            BookList = (from DataRow dr in TbBookTable.Rows
                        select new bookDTO()
                        {
                            Chek = Convert.ToInt32(dr["id"]),
                            Seller = dr["first_name"].ToString(),
                            Client = dr["client_name"].ToString(),
                            Phone_1 = dr["phone_1"].ToString(),
                            Traded_at = Convert.ToDateTime(dr["traded_at"]),
                            Arrival_date = dr["comment"].ToString(),
                            SumSom = Convert.ToDouble(dr["total_sum"]),
                            SumDollar = Convert.ToDouble(dr["total_dollar"])
                        }).ToList();
        }

        /// <summary>
        /// The function to cancel book
        /// </summary>
        public void CancelBook()
        {
            if (TbBookTable.Rows.Count == 0) return;
            else
            {
                // Updating amount of product of product table
                DataTable tbProduct = new DataTable();
                MySqlCommand cmdUpdateProduct;
                double deletedAmount = 0, productAmount = 0, changedAmount = 0;

                // Getting cart list
                DataTable tbBasket = new DataTable();
                string queryToBasket = "select * from cart where shop='" + Book.Chek + "'";
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
                    DataContext = new MessageViewModel("../../Images/message.success.png", "Tovarlar muvaffaqiyatli bekor qilindi!")
                };

                message.ShowDialog();
                GetBookedList();
            }
        }

        /// <summary>
        /// The function to take shop to basket
        /// </summary>
        public void TakeToBasket()
        {
            int shop = GetShop();
            if (shop != 0)
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.warning.png", "Korzinka bo'sh emas, iltimos korzinkani tekshiring!")
                };
                message.ShowDialog();
                return;
            }
            else
            {
                // The command to update shop queu to zero to move sale window
                MySqlCommand cmd = new MySqlCommand($"update shop set book=0, traded_at='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where id={Book.Chek}");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                // The command to update shop to set current shop
                cmd = new MySqlCommand($"update shopid set shop={Book.Chek} where password='{MainWindowViewModel.user_password}'");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                SaleViewModel.started_shop = true;
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.success.png", "Tovarlar korzinkaga muvaffaqiyatli o'tkazildi!")
                };
                message.ShowDialog();
                GetBookedList();
            }
        }

        /// <summary>
        /// The method to get shop id
        /// </summary>
        public int GetShop()
        {
            int shop = 0;
            using (DataTable tbShopId = new DataTable())
            {
                string queryShopId = "select shopid.shop from shopid inner join staff on shopid.password = staff.password " +
                    "where staff.password='" + MainWindowViewModel.user_password + "'";
                ObjDbAccess.readDatathroughAdapter(queryShopId, tbShopId);
                if (tbShopId.Rows.Count > 0)
                    shop = Convert.ToInt32(tbShopId.Rows[0]["shop"]);
                else
                    shop = 0;
            }
            return shop;
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
