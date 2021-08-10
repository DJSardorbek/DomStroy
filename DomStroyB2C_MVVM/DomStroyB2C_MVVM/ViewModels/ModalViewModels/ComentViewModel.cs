
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views.ModalViews;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.ViewModels.ModalViewModels
{
    public class ComentViewModel : BaseViewModel
    {
        #region Constructor

        public ComentViewModel(int shop, double sumSom, double sumDollar, ComentView comentView)
        {
            this.shop = shop;
            this.sumSom = sumSom;
            this.sumDollar = sumDollar;
            this.comentView = comentView;
            objDbAccess = new DBAccess();
            submitOrderCommand = new RelayCommand(Submit);
        }

        #endregion

        #region Command

        private RelayCommand submitOrderCommand;

        public RelayCommand SubmitOrderCommand
        {
            get { return submitOrderCommand; }
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// shop
        /// </summary>
        private int shop;

        private double sumSom;

        private double sumDollar;

        private ComentView comentView;

        /// <summary>
        /// Data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; OnPropertyChanged("Comment"); }
        }



        #endregion

        #region Helper methods

        /// <summary>
        /// The function to update shop
        /// </summary>
        public void Submit()
        {
            // first we update shop table
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            MySqlCommand cmdShop = new MySqlCommand("update shop set queue=1, comment='" + Comment + "', traded_at='"+currentDate+"', total_sum='"+sumSom+"', total_dollar='"+sumDollar+"' where id='" + shop + "'");
            ObjDbAccess.executeQuery(cmdShop);
            cmdShop.Dispose();

            // now we update shopid table
            MySqlCommand cmdShopId = new MySqlCommand("update shopid set shop=0 where password='" + MainWindowViewModel.user_password + "'");
            ObjDbAccess.executeQuery(cmdShopId);
            cmdShopId.Dispose();
            comentView.Close();
            MessageView message = new MessageView()
            {
                DataContext = new MessageViewModel("../../Images/message.Success.png", "Tovarlar navbatga muvaffaqiyatli o'tkazildi!")
            };
            message.ShowDialog();
        }

        #endregion
    }
}
