
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

        private double loan_sum;

        public double Loan_sum
        {
            get { return loan_sum; }
            set { loan_sum = value; OnPropertyChanged("Loan_sum"); }
        }

        private double loan_dollar;

        public double Loan_dollar
        {
            get { return loan_dollar; }
            set { loan_dollar = value; OnPropertyChanged("Loan_dollar"); }
        }

        #endregion

    }
}
