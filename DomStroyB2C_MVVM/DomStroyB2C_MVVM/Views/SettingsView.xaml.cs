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
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();

            staffList = new List<Employees>()
            {
                new Employees(){id =1, first_name = "Sardorbek", last_name="Sodiqjonov", staff="Ish boshqaruvchi"},
                new Employees(){id =2, first_name = "Abdurahmon", last_name="G'ulomqodirov", staff="Kassir"},
                new Employees(){id =3, first_name = "Abubakir", last_name="Maxkamov", staff="Sotuvchi"},
                new Employees(){id =4, first_name = "Xondamir", last_name="Abduhoshimov", staff="Kassir"}
            };

            dataGridEmployee.ItemsSource = staffList;

        }

        public class Employees
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string staff { get; set; }
        }

        public List<Employees> staffList;
    }
}
