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
    /// Interaction logic for DebtPaymentView.xaml
    /// </summary>
    public partial class DebtPaymentView : Window
    {
        public DebtPaymentView()
        {
            InitializeComponent();
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
    }
}
