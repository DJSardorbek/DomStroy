
using System;
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    /// <summary>
    /// Product model
    /// </summary>

   
    public class productDTO : INotifyPropertyChanged
    {
        #region INojifyPropertyChanged

        // Implemented INotifyPropertyChanged

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
            set { id = value;  OnPropertyChanged("Id"); }
        }

        private int product_id;

        public int Product_id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Product_id"); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string measurement;

        public string Measurement
        {
            get { return measurement; }
            set { measurement = value; OnPropertyChanged("Measurement"); }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged("Amount"); }
        }

        private int section;

        public int Section
        {
            get { return section; }
            set { section = value; OnPropertyChanged("Section"); }
        }

        private int branch;

        public int Branch
        {
            get { return branch; }
            set { branch = value; OnPropertyChanged("Branch"); }
        }

        private string  barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; OnPropertyChanged("Barcode"); }
        }

        private string producer;

        public string Producer
        {
            get { return producer; }
            set { producer = value; OnPropertyChanged("Producer"); }
        }

        private int deliver;

        public int Deliver
        {
            get { return deliver; }
            set { deliver = value; OnPropertyChanged("Deliver"); }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; OnPropertyChanged("Currency"); }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; OnPropertyChanged("Cost"); }
        }

        private double selling_price;

        public double Selling_price
        {
            get { return selling_price; }
            set { selling_price = value; OnPropertyChanged("Selling_price"); }
        }

        private string expire_date;

        public string Expire_date
        {
            get { return expire_date; }
            set { expire_date = value; OnPropertyChanged("Expire_date"); }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; OnPropertyChanged("Category"); }
        }

        private double ball;

        public double Ball
        {
            get { return ball; }
            set { ball = value; OnPropertyChanged("Ball"); }
        }

        #endregion
    }

}
