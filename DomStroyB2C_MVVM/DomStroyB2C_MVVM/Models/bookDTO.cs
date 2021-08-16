
using System;
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    class bookDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Implement INotifyPropertyChanged

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Fields

        private int chek;

        public int Chek
        {
            get { return chek; }
            set { chek = value; OnPropertyChanged("Chek"); }
        }

        private string seller;

        public string Seller
        {
            get { return seller; }
            set { seller = value; OnPropertyChanged("Seller"); }
        }

        private string client;

        public string Client
        {
            get { return client; }
            set { client = value; OnPropertyChanged("Client"); }
        }

        private string phone_1;

        public string Phone_1
        {
            get { return phone_1; }
            set { phone_1 = value; OnPropertyChanged("Phone_1"); }
        }

        private DateTime traded_at;

        public DateTime Traded_at
        {
            get { return traded_at; }
            set { traded_at = value; OnPropertyChanged("Traded_at"); }
        }

        private string arrival_date;

        public string Arrival_date
        {
            get { return arrival_date; }
            set { arrival_date = value; OnPropertyChanged("Arrival_date"); }
        }

        private double sumSom;

        public double SumSom
        {
            get { return sumSom; }
            set { sumSom = value; OnPropertyChanged("SumSom"); }
        }

        private double sumDollar;

        public double SumDollar
        {
            get { return sumDollar; }
            set { sumDollar = value; OnPropertyChanged("SumDollar"); }
        }

        #endregion
    }
}
