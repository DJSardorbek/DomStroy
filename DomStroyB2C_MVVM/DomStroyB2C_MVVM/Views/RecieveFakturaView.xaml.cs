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
    /// Interaction logic for RecieveFakturaView.xaml
    /// </summary>
    public partial class RecieveFakturaView : UserControl
    {
        public RecieveFakturaView()
        {
            InitializeComponent();

            fakturaList = new List<Faktura>()
            {
                new Faktura(){name = "Faktura 1", filial = "Andijon", sana = DateTime.Now, som = 12000000, dollar = 1000},
                new Faktura(){name = "Faktura 2", filial = "Farg'ona", sana = DateTime.Now, som = 15000000, dollar = 500},
                new Faktura(){name = "Faktura 3", filial = "Toshkent", sana = DateTime.Now, som = 150000, dollar = 750},
                new Faktura(){name = "Faktura 4", filial = "Samarqand", sana = DateTime.Now, som = 3000000, dollar = 600}
            };

            dataGridFaktura.ItemsSource = fakturaList;
        }

        public class Faktura
        {
            public string name { get; set; }
            public string filial { get; set; }
            public DateTime sana { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
        }

        public List<Faktura> fakturaList;
    }
}
