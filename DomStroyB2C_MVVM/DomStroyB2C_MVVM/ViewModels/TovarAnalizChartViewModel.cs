
using System.Collections.Generic;

namespace DomStroyB2C_MVVM.ViewModels
{
    class TovarAnalizChartViewModel : BaseViewModel
    {
        #region Constructor

        public TovarAnalizChartViewModel()
        {
            GetProductList();
        }

        #endregion

        
        /// <summary>
        /// An example class
        /// </summary>
        public class ProductAnalize
        {
            public double amount { get; set; }

            public string month { get; set; }
        }

        #region Private Fields

        private List<ProductAnalize> products;

        public List<ProductAnalize> Products
        {
            get { return products; }
            set { products = value; OnPropertyChanged("Products"); }
        }


        #endregion

        #region Commands

        #endregion

        #region Helper Methods

        public void GetProductList()
        {
            Products = new List<ProductAnalize>()
            {
                new ProductAnalize() {amount = 100, month="Yanvar"},
                new ProductAnalize() {amount = 158, month="Fevral"},
                new ProductAnalize() {amount = 65, month="Mart"},
                new ProductAnalize() {amount = 256, month="Aprel"},
                new ProductAnalize() {amount = 158, month="May"},
                new ProductAnalize() {amount = 500, month="Iyun"},
                new ProductAnalize() {amount = 600, month="Iyul"},
                new ProductAnalize() {amount = 850, month="Avgust"},
                new ProductAnalize() {amount = 70, month="Sentabr"},
                new ProductAnalize() {amount = 53, month="Oktabr"},
                new ProductAnalize() {amount = 140, month="Noyabr"},
                new ProductAnalize() {amount = 35, month="Dekabr"}
            };

        }

        #endregion
    }
}
