using DomStroyB2C_MVVM.Commands;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for DebtorsView.xaml
    /// </summary>
    public partial class DebtorsView : UserControl
    {
        public DebtorsView()
        {
            InitializeComponent();
        }

        public void OpenPayment(object sender, RoutedEventArgs e)
        {
            DebtPaymentView debtPaymentView = new DebtPaymentView();
            debtPaymentView.Show();
        }
    }
}
