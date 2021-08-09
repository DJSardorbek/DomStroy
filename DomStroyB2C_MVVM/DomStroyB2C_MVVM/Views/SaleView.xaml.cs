using DomStroyB2C_MVVM.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for SaleView.xaml
    /// </summary>
    public partial class SaleView : UserControl
    {
        public SaleView()
        {
            InitializeComponent();
            //this.DataContext = new SaleViewModel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //PaymentView view = new PaymentView();

            //view.ShowDialog();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (GridSearch.Visibility == Visibility.Visible)
            {
                if (e.Key == Key.Down)
                {
                    dataGridProduct.SelectedIndex = 0;
                    var u = e.OriginalSource as UIElement;
                    e.Handled = true;
                    u.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
                }
            }

            if (GridSearch.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Down)
                {
                    dataGridBasket.SelectedIndex = 0;
                    var u = e.OriginalSource as UIElement;
                    e.Handled = true;
                    u.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));

                }

            }
        }

        private void UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                txtSearch.Focus();

                txtSearch.Clear();
            }
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                txtSearch.Focus();
                txtSearch.Clear();

            }
        }
    }
}
