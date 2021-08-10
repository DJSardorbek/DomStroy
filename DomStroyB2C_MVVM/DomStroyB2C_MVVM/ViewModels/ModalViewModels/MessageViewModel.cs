
namespace DomStroyB2C_MVVM.ViewModels.ModalViewModels
{
    class MessageViewModel : BaseViewModel
    {
        #region Constructor

        public MessageViewModel(string image, string message)
        {
            Image = image;
            Message = message;
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// Image value
        /// </summary>
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged("Image"); }
        }

        /// <summary>
        /// Message value
        /// </summary>
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #endregion
    }

}
