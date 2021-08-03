
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    public class cartDTO : INotifyPropertyChanged
    {
        #region Implement InotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Fields

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private int product;

        public int Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged("Product"); }
        }

        private string name;

        public string  Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string producer;

        public string Producer
        {
            get { return producer; }
            set { producer = value; OnPropertyChanged("Producer"); }
        }

        private string measurement;

        public string Measurement
        {
            get { return measurement; }
            set { measurement = value; OnPropertyChanged("Measurement"); }
        }

        private double selling_price;

        public double Selling_price
        {
            get { return selling_price; }
            set { selling_price = value; OnPropertyChanged("Selling_price"); }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; OnPropertyChanged("Currency"); }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged("Amount"); }
        }

        private double sum;

        public double Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged("Sum"); }
        }

        private int shop;

        public int Shop
        {
            get { return shop; }
            set { shop = value; OnPropertyChanged("Shop"); }
        }


        #endregion
    }
}
