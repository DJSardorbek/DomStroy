using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class QueueNavbatlarViewModel : BaseViewModel
    {
        #region Constructor

        public QueueNavbatlarViewModel()
        {
            objDbAccess = new DBAccess();
            tbQueue = new DataTable();
            GetQueueList();
            cancelShopCommand = new RelayCommand(CancelShop);
            takeToBasketCommand = new RelayCommand(TakeToBasket);
        }

        #endregion

        #region Commands

        /// <summary>
        /// The command to take shop to basket
        /// </summary>
        private RelayCommand takeToBasketCommand;

        public RelayCommand TakeToBasketCommand
        {
            get { return takeToBasketCommand; }
        }

        /// <summary>
        /// The command to cancel shop
        /// </summary>
        private RelayCommand cancelShopCommand;

        public RelayCommand CancelShopCommand
        {
            get { return cancelShopCommand; }
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The queue to be selected
        /// </summary>
        private queueDTO queue;

        public queueDTO Queue
        {
            get { return queue; }
            set { queue = value; OnPropertyChanged("Queue"); }
        }

        /// <summary>
        /// The queue list
        /// </summary>
        private List<queueDTO> queueList;

        public List<queueDTO> QueueList
        {
            get { return queueList; }
            set { queueList = value; OnPropertyChanged("QueueList"); }
        }

        /// <summary>
        /// Data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// The data table of queue list
        /// </summary>
        private DataTable tbQueue;

        public DataTable TbQueue
        {
            get { return tbQueue; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get queue list
        /// </summary>
        public void GetQueueList()
        {
            string queryToQueue = "select sh.id, sh.comment, st.first_name, sh.total_sum, sh.total_dollar, sh.traded_at from shop as sh " +
                "inner join staff  as st on sh.seller = st.id " +
                "where sh.queue = 1";
            TbQueue.Clear();
            ObjDbAccess.readDatathroughAdapter(queryToQueue, TbQueue);
            ConvertQueueTableToList();

        }

        /// <summary>
        /// The function to convert queue data table to list
        /// </summary>
        public void ConvertQueueTableToList()
        {
            QueueList = (from DataRow dr in TbQueue.Rows
                         select new queueDTO()
                         {
                             Chek = Convert.ToInt32(dr["id"]),
                             Comment = dr["comment"].ToString(),
                             Seller = dr["first_name"].ToString(),
                             Sum = Convert.ToDouble(dr["total_sum"]),
                             Dollar = Convert.ToDouble(dr["total_dollar"]),
                             Date = Convert.ToDateTime(dr["traded_at"])
                         }).ToList();
        }

        /// <summary>
        /// The function to cancel shop
        /// </summary>
        public void CancelShop()
        {
            if (TbQueue.Rows.Count == 0) return;
            else
            {
                // Updating amount of product of product table
                DataTable tbProduct = new DataTable();
                MySqlCommand cmdUpdateProduct;
                double deletedAmount = 0, productAmount = 0, changedAmount = 0;
                
                // Getting cart list
                DataTable tbBasket = new DataTable();
                string queryToBasket = "select * from cart where shop='" + Queue.Chek + "'";
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

                MessageBox.Show("Tovarlar bekor qilindi!", "Xabar", MessageBoxButton.OK, MessageBoxImage.Information);
                GetQueueList();

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

        /// <summary>
        /// The function to take shop to basket
        /// </summary>
        public void TakeToBasket()
        {
            int shop = GetShop();
            if(shop != 0)
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
                MySqlCommand cmd = new MySqlCommand($"update shop set queue=0, traded_at='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where id={Queue.Chek}");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                // The command to update shop to set current shop
                cmd = new MySqlCommand($"update shopid set shop={Queue.Chek} where password='{MainWindowViewModel.user_password}'");
                ObjDbAccess.executeQuery(cmd);
                cmd.Dispose();

                SaleViewModel.started_shop = true;
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.success.png", "Tovarlar korzinkaga muvaffaqiyatli o'tkazildi!")
                };
                message.ShowDialog();
                GetQueueList();
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

        #endregion

    }
}
