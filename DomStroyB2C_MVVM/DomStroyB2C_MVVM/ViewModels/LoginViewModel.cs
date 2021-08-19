
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using DomStroyB2C_MVVM.ViewModels.ModalViewModels;
using DomStroyB2C_MVVM.Views.Loading;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        /// <summary>
        /// Private ViewModal and View
        /// </summary>
        private MainWindowViewModel mainWindow;
        private MainWindow Window;

        #region Constructor
        /// <summary>
        /// Constructor that sets effect to the MainWindow when SignIn method is calling
        /// </summary>
        /// <param name="mainWindow"></param>
        /// <param name="window"></param>
        public LoginViewModel(MainWindowViewModel mainWindow, MainWindow window)
        {
            this.mainWindow = mainWindow;
            this.Window = window;
            UpdateViewCommand = new UpdateViewCommand(mainWindow);
            LoadingCommnad = new RelayCommand(SignInAsync);
            objDbContext = new DBAccess();
        }

        #endregion

        #region Commands

        public ICommand LoadingCommnad { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        #endregion

        #region Private Fields
        private DBAccess objDbContext;
        public DBAccess ObjDbContext
        {
            get { return objDbContext; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }

        private employeeDTO employee;
        public employeeDTO Employee
        {
            get { return employee; }
            set { employee = value; OnPropertyChanged("Employee"); }
        }



        #endregion 

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

            Window.Effect = myEffect;

            using (LoadingWindow lw = new LoadingWindow(Simulator))
            {
                lw.ShowDialog();
            }
            myEffect.Radius = 0;

            Window.Effect = myEffect;
        }
        #endregion

        #region SignIN
        // The Sign in function to enter the application
        public void SignInAsync()
        {
            #region No internet
            //MainWindowViewModel.user_password = Password;
            //MainWindowViewModel.user_id = Employee.data.id;
            //mainWindow.SelectedViewModel = new MainViewModel(mainWindow, Window);
            //mainWindow.GridVisibility = true;
            #endregion

            #region with internet
            try
            {
                

                //The url for post user password
                Uri url = new Uri("http://143.244.156.131/api-auth/");
                var strContent = "{\"password\": \"" + Password + "\"}";
                HttpContent content = new StringContent(strContent, Encoding.UTF8, "application/json");
                var task = Task.Run(async ()  => await PostUri(url, content));
                LoadAnimation();
                task.Wait();
                // If the response is not error
                if (task.Result != "error")
                {
                    string strResult = task.Result;
                    Employee = JsonConvert.DeserializeObject<employeeDTO>(strResult);

                    //Checking a user if he is not work in this branch
                    using (DataTable tbCheckBranch = new DataTable())
                    {
                        string queryCheckBranch = "select * from branch where id='" + Employee.data.branch.id + "'";
                        ObjDbContext.readDatathroughAdapter(queryCheckBranch, tbCheckBranch);
                        if (tbCheckBranch.Rows.Count == 0)
                        {
                            System.Windows.MessageBox.Show("Bunday ishchi mavjud emas!");
                            return;
                        }
                        else
                        {
                            // Getting data from localDb to compare with remote Db
                            using (DataTable tbStaff = new DataTable())
                            {
                                // Query to get data from local staff table
                                string queryStaff = "select * from staff where password='" + Password + "'";
                                objDbContext.readDatathroughAdapter(queryStaff, tbStaff);

                                // If this staff is new, we insert him to local Db
                                if (tbStaff.Rows.Count == 0)
                                {
                                    MySqlCommand cmdInsert = new MySqlCommand("insert into staff (id,first_name,token,password,role,section) " +
                                        "values('" + Employee.data.id + "', '" + Employee.data.first_name + "', '" + Employee.token + "', '" + Password + "' ,'" + Employee.data.role + "','"+Employee.data.section.id+"')");
                                    ObjDbContext.executeQuery(cmdInsert);
                                    cmdInsert.Dispose();
                                }

                                // If this staff is already inserted, We update his information
                                if (tbStaff.Rows.Count == 1)
                                {
                                    MySqlCommand cmdUpdate = new MySqlCommand("update staff set first_name='" + Employee.data.first_name + "', " +
                                                                "token='" + Employee.token + "', role='" + Employee.data.role + "', section= '"+Employee.data.section.id+"' " +
                                                                "where password='"+Password+"'");
                                    ObjDbContext.executeQuery(cmdUpdate);
                                    cmdUpdate.Dispose();
                                }

                                MainWindowViewModel.user_password = Password;
                                MainWindowViewModel.user_id = Employee.data.id;
                                MainWindowViewModel.user_token = Employee.token;
                                MainWindowViewModel.section = Employee.data.section.id;
                                mainWindow.SelectedViewModel = new MainViewModel(mainWindow, Window);
                                mainWindow.GridVisibility = true;
                                //LoginVisibility = false;
                            }
                        }
                    }
                }
                // If the response is error
                else
                {
                    MessageView message = new MessageView()
                    {
                        DataContext = new MessageViewModel("../../Images/message.Error.png", "Parol noto'g'ri kiritildi, qaytadan urinib ko'ring!")
                    };
                    message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", ex.Message)
                };
                message.ShowDialog();
            }
            #endregion
        }
        #endregion

        #region Helper methods

        /// <summary>
        /// The function it gets data from api
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<string> GetObject(string url)
        {
            using (HttpClient request = new HttpClient())
            {
                var content = await request.GetStringAsync(url);
                return content;
            }
        }

        /// <summary>
        /// The function it posts content to the api
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<string> PostUri(Uri url, HttpContent content)
        {
            var response = string.Empty;

            using (var client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage result = await client.PostAsync(url, content))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            using (HttpContent Rcontent = result.Content)
                            {
                                response = await Rcontent.ReadAsStringAsync();
                            }
                        }
                        else
                        {
                            response = "error";
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                return response;
            }
        }

        #endregion
    }
}
