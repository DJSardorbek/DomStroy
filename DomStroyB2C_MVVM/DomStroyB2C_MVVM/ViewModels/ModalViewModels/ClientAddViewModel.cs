using DomStroyB2C_MVVM.API.Client;
using DomStroyB2C_MVVM.API.Client.ClientService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views.Loading;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace DomStroyB2C_MVVM.ViewModels.ModalViewModels
{
    class ClientAddViewModel : BaseViewModel
    {
        #region Constructor

        public ClientAddViewModel(CliantAddView cliantAddView)
        {
            LoadingVisibility = Visibility.Collapsed;
            this.cliantAddView = cliantAddView;
            _clientService = new ClientService();
            postClientCommand = new RelayCommand(PostClient);
            objDbAccess = new DBAccess();
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

        private CliantAddView cliantAddView { get; set; }

        /// <summary>
        /// Data Access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// The visibility variable to loadin gif animation
        /// </summary>
        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
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
            try
            {
                LoadingVisibility = Visibility.Visible;

                ClientModel model = new ClientModel()
                {
                    _branch = MainWindowViewModel.branch,
                    _firstName = FirstName,
                    _lastName = LastName,
                    _address = Address,
                    _phone_1 = Phone_1,
                    _phone_2 = Phone_2,
                    _returnDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    _birthDay = DateTimeConverter(BirthDate)
                };

                string response = await clientService.Post(model);

                LoadingVisibility = Visibility.Collapsed;

                if (response != "error")
                {
                    // The response from server
                    ClientResponseModel r = JsonConvert.DeserializeObject<ClientResponseModel>(response);

                    // The command to add new client
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO client (id,first_name,last_name,phone_1,phone_2,address,birth_date,discount_card,return_date,loan_sum,loan_dollar,ball) " +
                    $"VALUES({r.id}, '{r.first_name}', '{r.last_name}', '{r.phone_1}', '{r.phone_2}', '{r.address}', '{r.birth_date}', 1, '{r.return_date}', '{r.loan_sum}', '{r.loan_dollar}', '{r.ball}')");
                    ObjDbAccess.executeQuery(cmd);
                    cmd.Dispose();

                    // Message for display client added successfully
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Success.png", "Mijoz muvaffaqiyatli qo'shildi!")
                    };
                    message.ShowDialog();
                    cliantAddView.Close();
                }

                else
                {
                    // Message for display error
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Error.png", "Server bilan xatolik yuz berdi!")
                    };
                    message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoadingVisibility = Visibility.Collapsed;
                myEffect.Radius = 0;
                // Message for display error
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", ex.Message)
                };
                message.ShowDialog();

            }
        }

        public string DateTimeConverter(string date)
        {
            string[] _date = date.Split('.');
            string day = string.Empty, month = string.Empty, year = string.Empty;

            day = _date[0];
            month = _date[1];
            year = _date[2];

            return year + '-' + month + '-' + day;
        }

        #region Loadin animation
        // An effect that sets effect to the usercontrol ui
        BlurEffect myEffect = new BlurEffect();


        // Command that runs LoadAnimation function
        private ICommand loading { get; set; }

        public ICommand Loading
        {
            get { return loading; }
        }

        // A function that sets time to showing loading window
        void Simulator()
        {

            for (int i = 0; i < 80; i++)

                Thread.Sleep(5);
        }

        // A function that shows loading window
        public void LoadAnimation()
        {
            myEffect.Radius = 10;

            cliantAddView.Effect = myEffect;

            using (LoadingWindow lw = new LoadingWindow(Simulator))
            {
                lw.ShowDialog();
            }
            myEffect.Radius = 0;

            cliantAddView.Effect = myEffect;
        }
        #endregion

        #endregion
    }
}
