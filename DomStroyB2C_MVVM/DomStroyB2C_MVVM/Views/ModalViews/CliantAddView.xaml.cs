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

namespace DomStroyB2C_MVVM.Views.ModalViews
{
    /// <summary>
    /// Interaction logic for CliantAddView.xaml
    /// </summary>
    public partial class CliantAddView : Window
    {
        public CliantAddView()
        {
            InitializeComponent();
            txtFirstName.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
