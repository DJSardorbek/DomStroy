using DomStroyB2C_MVVM.Commands;
using System.Windows;

namespace DomStroyB2C_MVVM.Views.ModalViews
{
    /// <summary>
    /// Interaction logic for BasketView.xaml
    /// </summary>
    public partial class BasketView : Window
    {
        public BasketView()
        {
            InitializeComponent();
            txtAmount.Focus();
            //btnSubmit.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtAmount_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                btnSubmit.Focus();
        }
    }

}
