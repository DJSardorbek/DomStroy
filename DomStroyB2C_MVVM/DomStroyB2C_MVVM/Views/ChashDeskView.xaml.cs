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
    /// Interaction logic for ChashDeskView.xaml
    /// </summary>
    public partial class ChashDeskView : UserControl
    {
        public ChashDeskView()
        {
            InitializeComponent();

            cashList = new List<Cash>()
            {
                new Cash{ id =1, client = "Maxkamov Abubakir", saler = "Sardorbek", som = 1562300, dollar = 50, date = DateTime.Now},
                new Cash{ id =1, client = "Hamdamov Dilmurod", saler = "Sardorbek", som = 1562300, dollar = 50, date = DateTime.Now}
            };

            dataGridCash.ItemsSource = cashList;
        }

        public class Cash
        {
            public int id { get; set; }
            public string client { get; set; }
            public string saler { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
            public DateTime date { get; set; }
        }

        public List<Cash> cashList;
    }
}
