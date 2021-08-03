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
    /// Interaction logic for InventoryView.xaml
    /// </summary>
    public partial class InventoryView : UserControl
    {
        public InventoryView()
        {
            InitializeComponent();

            inventories = new List<Inventory>()
            {
                new Inventory() { id =1, branch = "Andijon filial", date= DateTime.Now, old_quan = 20, new_quan = 25, diff_som = 250000, diff_dollar = 50, checker = "Jahongir", condition = "Jarayonda"},
                new Inventory() { id =2, branch = "Namangan filial", date= DateTime.Now, old_quan = 20, new_quan = 25, diff_som = 950000, diff_dollar = 150, checker = "Abdullo", condition = "Tugatildi"},
                new Inventory() { id =3, branch = "Farg'ona filial", date= DateTime.Now, old_quan = 20, new_quan = 25, diff_som = 450000, diff_dollar = 250, checker = "Javohir", condition = "Jarayonda"},
                new Inventory() { id =4, branch = "Sirdaryo filial", date= DateTime.Now, old_quan = 20, new_quan = 25, diff_som = 650000, diff_dollar = 350, checker = "Azizbek", condition = "Tugatildi"}
            };

            dataGridInventory.ItemsSource = inventories;
        }

        public class Inventory
        {
            public int id { get; set; }
            public string branch { get; set; }
            public DateTime date { get; set; }
            public double old_quan { get; set; }
            public double new_quan { get; set; }
            public double diff_som { get; set; }
            public double diff_dollar { get; set; }
            public string checker { get; set; }
            public string condition { get; set; }
        }

        public List<Inventory> inventories;
    }
}
