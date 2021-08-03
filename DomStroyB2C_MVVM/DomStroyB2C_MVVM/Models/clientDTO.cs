
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    public class clientDTO : INotifyPropertyChanged
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

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; OnPropertyChanged("FullName"); }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("Phone"); }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        private string card;

        public string Card
        {
            get { return card; }
            set { card = value; OnPropertyChanged("Card"); }
        }

        private double bonusSum;

        public double BonusSum
        {
            get { return bonusSum; }
            set { bonusSum = value; OnPropertyChanged("BonusSom"); }
        }

        private double bonusDollar;

        public double BonusDollar
        {
            get { return bonusDollar; }
            set { bonusDollar = value; OnPropertyChanged("BonusDollar"); }
        }


        #endregion

    }
}
