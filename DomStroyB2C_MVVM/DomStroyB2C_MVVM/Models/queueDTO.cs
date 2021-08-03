using System;
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    public class queueDTO : INotifyPropertyChanged
    {
        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

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

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; OnPropertyChanged("Comment"); }
        }

        private string seller;

        public string Seller
        {
            get { return seller; }
            set { seller = value; OnPropertyChanged("Seller"); }
        }

        private double sum;

        public double Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged("Sum"); }
        }

        private double dollar;

        public double Dollar
        {
            get { return dollar; }
            set { dollar = value; OnPropertyChanged("Dollar"); }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged("Date"); }
        }

        #endregion
    }
}
