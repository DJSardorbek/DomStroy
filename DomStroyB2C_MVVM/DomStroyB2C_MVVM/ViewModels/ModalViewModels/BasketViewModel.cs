
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class BasketViewModel : BaseViewModel
    {
        #region Constructor
        /// <summary>
        /// The constructor that sets property to ui
        /// </summary>
        /// <param name="product"></param>
        public BasketViewModel(productDTO product, int shop)
        {
            this.product = product;
            this.shop = shop;
            objContext = new DBAccess();
            submitCommand = new RelayCommand(SetProduct);
        }

        #endregion

        #region Private fields
        /// <summary>
        /// The product to add basket
        /// </summary>
        private productDTO product;

        public productDTO Product
        {
            get { return product; }
        }

        /// <summary>
        /// The amount to add basket
        /// </summary>
        private string enter_amount;

        public string Enter_amount
        {
            get { return enter_amount; }
            set { enter_amount = value; OnPropertyChanged("Enter_amount"); }
        }

        /// <summary>
        /// The DbContext that allows to connect db
        /// </summary>
        private DBAccess objContext;

        public DBAccess ObjContext
        {
            get { return objContext; }
        }

        /// <summary>
        /// The shop 
        /// </summary>
        private int shop;

        public int Shop
        {
            get { return shop; }
        }


        #endregion

        #region Commands

        /// <summary>
        /// The command that adds product to cart table
        /// </summary>
        private RelayCommand submitCommand;

        public RelayCommand SubmitCommand
        {
            get { return submitCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to set product to cart table
        /// </summary>
        public void SetProduct()
        {
            // Checking amount if it is null
            if(Enter_amount == string.Empty)
            {
                System.Windows.MessageBox.Show("Miqdorni kiriting!");
                return;
            }

            // Checking amount if it contains(',')
            if(Enter_amount.Contains(","))
            {
                // Switching (,) to (.)
                Enter_amount.Replace(",", ".");
            }

            // Checking product amount if it is not enough
            if(Product.Amount < double.Parse(Enter_amount))
            {
                System.Windows.MessageBox.Show("Sotish miqdori ko'p kiritildi!");
                return;
            }

            // The price of product
            double sellingPrice = Product.Selling_price;


            //// Checking the currency if it is dollar
            //if(Product.Currency == "$")
            //{
            //    using(DataTable tbGetCurrency = new DataTable())
            //    {
            //        string queryGetCurrency = "select selling_currency from currency";
            //        ObjContext.readDatathroughAdapter(queryGetCurrency, tbGetCurrency);
            //        double sellingCurrency = double.Parse(tbGetCurrency.Rows[0]["selling_currency"].ToString());
            //        sellingPrice = sellingCurrency * sellingPrice;
            //    }
            //}


            // Compyuting sum of product
            double enteredAmount = double.Parse(Enter_amount);
            double sum = enteredAmount * sellingPrice;

            // Inserting product to cart table
            string queryInsert = "insert into cart (product, amount, sum, shop) " +
                "values('" + Product.Product_id + "', '" + Enter_amount + "', '" + DoubleToStr(sum) + "', '"+Shop+"')";
            MySqlCommand cmdInsertCart = new MySqlCommand(queryInsert);
            objContext.executeQuery(cmdInsertCart);
            cmdInsertCart.Dispose();

            // Compyuting result amount of product
            double productAmount = Product.Amount;
            double resultAmount = productAmount - enteredAmount;

            // Updating the amount of product table
            string queryToUpdateProduct = "update product set amount='" + DoubleToStr(resultAmount) + "' where product.product_id='" + Product.Product_id + "'";
            MySqlCommand cmdUpdateProduct = new MySqlCommand(queryToUpdateProduct);
            ObjContext.executeQuery(cmdUpdateProduct);
            cmdUpdateProduct.Dispose();
        }

        /// <summary>
        /// The function to convert double value to string
        /// </summary>
        /// <param name="doubleValue"></param>
        /// <returns></returns>
        public string DoubleToStr(double doubleValue)
        {
            string str = doubleValue.ToString();
            if(str.Contains(","))
            {
                str.Replace(",", ".");
            }
            return str;
        }
        #endregion
    }
}
