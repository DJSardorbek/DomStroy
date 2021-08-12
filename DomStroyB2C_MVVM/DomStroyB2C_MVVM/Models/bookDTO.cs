
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




        #endregion
    }
}
