using System;
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    public class shopDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region ImplementInotifyprepertyChanged
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Fields

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id");}
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

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged("Date"); }
        }

        #endregion
    }

}
