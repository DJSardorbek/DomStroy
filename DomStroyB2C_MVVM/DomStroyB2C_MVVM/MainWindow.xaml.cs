using DomStroyB2C_MVVM.ViewModels;
using DomStroyB2C_MVVM.Views.Loading;
using DomStroyB2C_MVVM.Views.ModalViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DomStroyB2C_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel(this);
        }

        #region LeftMenu
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex  = 0;
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 1;
        }

        private void btnChas_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 2;
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 3;
        }

        private void btnQueue_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 4;
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 5;
        }

        private void btnDebtor_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 6;
        }

        private void btnProductResidue_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 7;
        }

        private void btnRecieveFaktura_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 8;
        }

        private void btnFakturaReport_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 9;
        }

        private void btnPeremisheniya_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 10;
        }

        private void btnVozvrat_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 11;
        }

        private void btnOtkaz_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 12;
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            ListView.SelectedIndex = 13;
        }
        #endregion

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoadingView view = new LoadingView();
            view.ShowDialog();
        }
    }
}
