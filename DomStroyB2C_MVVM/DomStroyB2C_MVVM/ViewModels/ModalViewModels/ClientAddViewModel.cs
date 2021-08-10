
using DomStroyB2C_MVVM.API.Client;
using DomStroyB2C_MVVM.API.Client.ClientService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views.ModalViews;
using System;

namespace DomStroyB2C_MVVM.ViewModels.ModalViewModels
{
    class ClientAddViewModel : BaseViewModel
    {
        #region Constructor

        public ClientAddViewModel()
        {
            _clientService = new ClientService();
            postClientCommand = new RelayCommand(PostClient);
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// First Name 
        /// </summary>
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }

        /// <summary>
        /// Last Name
        /// </summary>
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }

        /// <summary>
        /// Address
        /// </summary>
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        /// <summary>
        /// Phone number 1
        /// </summary>
        private string phone_1;

        public string Phone_1
        {
            get { return phone_1; }
            set { phone_1 = value; OnPropertyChanged("Phone_1"); }
        }

        /// <summary>
        /// Phone number 2
        /// </summary>
        private string phone_2;

        public string Phone_2
        {
            get { return phone_2; }
            set { phone_2 = value; OnPropertyChanged("Phone_2"); }
        }

        /// <summary>
        /// The date of return debt back
        /// </summary>
        private string returnDate;

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; OnPropertyChanged("ReturnDate"); }
        }

        /// <summary>
        /// Birth Date
        /// </summary>
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        /// <summary>
        /// Client service
        /// </summary>
        private ClientService _clientService;

        public ClientService clientService
        {
            get { return _clientService; }
        }

        #endregion

        #region Commands

        private RelayCommand postClientCommand;

        public RelayCommand PostClientCommand
        {
            get { return postClientCommand; }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to post client
        /// </summary>
        public async void PostClient()
        {
            ClientModel model = new ClientModel()
            {
                _firstName = FirstName,
                _lastName = LastName,
                _address = Address,
                _phone_1 = Phone_1,
                _phone_2 = Phone_2,
                _returnDate = DateTime.Now.ToString("yyyy-MM-dd"),
                _birthDay = BirthDate
            };
             
            string reponse = await clientService.Post(model);
            if(reponse !="error")
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Success.png", "Mijoz muvaffaqiyatli qo'shildi!")
                };
                message.ShowDialog();
            }
        }

        #endregion
    }
}
