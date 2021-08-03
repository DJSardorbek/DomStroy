using System.Windows;

namespace DomStroyB2C_MVVM.Views.ModalViews
{
    /// <summary>
    /// Interaction logic for ComentView.xaml
    /// </summary>
    public partial class ComentView : Window
    {
        public ComentView()
        {
            InitializeComponent();
            txtComment.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
