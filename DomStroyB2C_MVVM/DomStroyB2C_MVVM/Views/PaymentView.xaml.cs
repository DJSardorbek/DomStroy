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
using System.Windows.Shapes;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for PaymentView.xaml
    /// </summary>
    public partial class PaymentView : Window
    {
        public PaymentView()
        {
            InitializeComponent();
            comboCurrency.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMaxsimaze_Click(object sender, RoutedEventArgs e)
        {
            if (Height == 700)
            {
                Height = 850;
                Top -= 75;
                return;
            }
            else
            {
                Height = 700;
                Top += 75;
                return;
            }
        }
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch(i)
            {
                case 0 : stackNaqd.Visibility = Visibility.Visible; i++; break; 
                case 1: stackPlastik.Visibility = Visibility.Visible; i++; break; 
                case 2: stackXR.Visibility = Visibility.Visible; i =0; break;
            }
            
        }

        private void btnChangeCurrency_Click(object sender, RoutedEventArgs e)
        {
            if(txtCurrency.Visibility == Visibility.Collapsed)
            {
                txtCurrencyType.Text = "Dollar";
                txtCurrency.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                txtCurrencyType.Text = "So'm";
                txtCurrency.Visibility = Visibility.Collapsed;
                return;
            }
        }
    }
}
