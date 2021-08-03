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
    /// Interaction logic for SeeEmployeeView.xaml
    /// </summary>
    public partial class SeeEmployeeView : UserControl
    {
        Thickness LeftSide = new Thickness(-28,0,0,0);
        Thickness RightSide = new Thickness(0,0,-28,0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(173, 171, 173));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        private bool Toggled = false;
        

        public SeeEmployeeView()
        {
            InitializeComponent();
            Back.Fill = Off;
            Toggled = false;
            Dot.Margin = LeftSide;

            employees = new List<Employee>()
            {
                new Employee() { id =1, first_name = "Sardorbek", last_name = "Sodiqjonov", staff = "Ish boshqaruvchi", login = "asd@gmail.com", password="1212", phone="+998901586968", condition="Aktiv" },
                new Employee() { id =2, first_name = "Abdurahmon", last_name = "G'ulomqodirov", staff = "Kassir", login = "asd12@gmail.com", password="6539", phone="+998901586968", condition="Aktiv" },
                new Employee() { id =3, first_name = "Asadbek", last_name = "Abbosov", staff = "Sotuvchi", login = "asd32@gmail.com", password="7895", phone="+998901586968", condition="Aktiv" },
                new Employee() { id =4, first_name = "Azizbek", last_name = "Azamov", staff = "Kassir", login = "asd43@gmail.com", password="3654", phone="+998901586968", condition="Aktiv emas" }
            };

            dataGridEmployee.ItemsSource = employees;
        }

        public bool Togled1 { get => Toggled; set => Toggled = value; }

        public class Employee
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string staff { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public string phone { get; set; }
            public string condition { get; set; }
        }

        public List<Employee> employees;

        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = RightSide;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = LeftSide;
            }
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = RightSide;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = LeftSide;
            }
        }
    }
}
