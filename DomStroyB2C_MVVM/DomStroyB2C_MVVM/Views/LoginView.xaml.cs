
using System.Windows;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();

        }


        private void asd_Loaded(object sender, RoutedEventArgs e)
        {
            Password.Focus();

        }
    }
}
