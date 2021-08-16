using DomStroyB2C_MVVM.ViewModels;
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
            comboCurrency.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridClient.Visibility == Visibility.Visible)
            {
                if (e.Key == Key.Down)
                {
                    dataGridClient.SelectedIndex = 0;
                    var u = e.OriginalSource as UIElement;
                    e.Handled = true;
                    u.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
                }
            }
        }

        private void comboCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtPayedSumma.Focus();
        }
    }
}
