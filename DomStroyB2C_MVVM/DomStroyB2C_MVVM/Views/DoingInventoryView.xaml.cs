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
    /// Interaction logic for DoingInventoryView.xaml
    /// </summary>
    public partial class DoingInventoryView : UserControl
    {
        public DoingInventoryView()
        {
            InitializeComponent();

            doInventories = new List<DoInventory>()
            {
                new DoInventory() { id = 1, name = "Lyustra", preparer = "Andijon", checker="Sardorbek", app_quan = 20, store_quan = 30, diff_quan = 10, measurement = "metr", last_date = DateTime.Now, diff_summa = 30000},
                new DoInventory() { id = 2, name = "Panel", preparer = "Toshkent",  checker="Abdurahmon", app_quan = 20, store_quan = 30, diff_quan = 10, measurement = "dona", last_date = DateTime.Now, diff_summa = 30000},
                new DoInventory() { id = 3, name = "Oboylar", preparer = "Rossiya", checker="Jamoliddin", app_quan = 20, store_quan = 30, diff_quan = 10, measurement = "metr", last_date = DateTime.Now, diff_summa = 30000},
                new DoInventory() { id = 4, name = "Qopli", preparer = "Turkiya",  checker="Xondamir", app_quan = 20, store_quan = 30, diff_quan = 10, measurement = "kg", last_date = DateTime.Now, diff_summa = 30000}
            };

            dataGridDoingInventory.ItemsSource = doInventories;

        }


        public class DoInventory
        {
            public int id { get; set; }
            public string name { get; set; }
            public string preparer { get; set; }
            public string checker { get; set; }
            public double app_quan { get; set; }
            public double store_quan { get; set; }
            public double diff_quan { get; set; }
            public DateTime last_date { get; set; }
            public double diff_summa { get; set; }
            public string measurement { get; set; }
        }

        public List<DoInventory> doInventories;

    }
}
