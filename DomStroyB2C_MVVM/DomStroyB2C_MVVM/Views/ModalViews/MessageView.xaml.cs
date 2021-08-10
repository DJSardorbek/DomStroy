using System.Windows;

namespace DomStroyB2C_MVVM.Views.ModalViews
{
    /// <summary>
    /// Interaction logic for MessageView.xaml
    /// </summary>
    public partial class MessageView : Window
    {
        public MessageView()
        {
            InitializeComponent();
            btnOk.Focus();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
