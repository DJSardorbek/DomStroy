using DomStroyB2C_MVVM.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace DomStroyB2C_MVVM.Views.ModalViews
{
    /// <summary>
    /// Interaction logic for InvoiceExpanseView.xaml
    /// </summary>
    public partial class InvoiceExpanseView : Window
    {
        public InvoiceExpanseView()
        {
            InitializeComponent();
            txtComment.Focus();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtComment.Text))
            {
                SeeFakturaViewModel.Expanse = "0";
            }
            else
            {
                SeeFakturaViewModel.Expanse = txtComment.Text;
            }
            Close();
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnSubmit_Click(sender, e);
                
            }
        }
    }
}
