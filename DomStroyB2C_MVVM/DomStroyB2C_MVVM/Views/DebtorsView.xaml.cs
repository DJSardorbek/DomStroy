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
using DomStroyB2C_MVVM.Commands;
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
            debtorList = new List<Debtors>() 
            {
                new Debtors(){client = "Sodiqjonov Sardorbek", phone= "991234568", card = 12345, ball = 100, debtsom = 100000, debtdollar = 100 , lastdate = DateTime.Now},
                new Debtors(){client = "G'ulomqodirov Abdurahmon", phone= "991234568", card = 12345, ball = 100, debtsom = 100000, debtdollar = 100 , lastdate = DateTime.Now},
                new Debtors(){client = "Maxkamov Abubakir", phone= "991234568", card = 12345, ball = 100, debtsom = 100000, debtdollar = 100 , lastdate = DateTime.Now},
                new Debtors(){client = "Abduxoshimmov Xondamir", phone= "991234568", card = 12345, ball = 100, debtsom = 100000, debtdollar = 100 , lastdate = DateTime.Now}
            };

            dataGridClient.ItemsSource = debtorList;
        }

        public class Debtors
        {
            public string client { get; set; }
            public string phone { get; set; }
            public double card { get; set; }
            public double ball { get; set; }
            public double debtsom { get; set; }
            public double debtdollar { get; set; }
            public DateTime lastdate { get; set; }
        }

        public List<Debtors> debtorList;

        public void OpenPayment(object sender, RoutedEventArgs e)
        {
            DebtPaymentView debtPaymentView = new DebtPaymentView();
            debtPaymentView.Show();
        }
    }
}
