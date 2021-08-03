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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for ReportOtkazView.xaml
    /// </summary>
    public partial class ReportOtkazView : UserControl
    {
        public ReportOtkazView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));

            otkazList = new List<Otkaz>()
            {
                new Otkaz() { id =1, client = "Jahongir Mamirov", phone = "123456", address = "Andijon tuman Nayman", som = 350500, dollar=50},
                new Otkaz() { id =2, client = "G'ulomqodirov Abdurahmon", phone = "123456", address = "Andijon tuman Nayman", som = 350500, dollar=50},
                new Otkaz() { id =3, client = "Abdukhoshimov Khondamir", phone = "123456", address = "Andijon tuman Nayman", som = 350500, dollar=50},
                new Otkaz() { id =4, client = "Maxkamov Abubakir", phone = "123456", address = "Andijon tuman Nayman", som = 350500, dollar=50},
                new Otkaz() { id =5, client = "Mamajonov Izzatillo", phone = "123456", address = "Andijon tuman Nayman", som = 350500, dollar=50}
            };

            dataGridOtkaz.ItemsSource = otkazList;
        }

        private void WidenObject(int newWidth, TimeSpan duration)
        {
            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            GridMenu.BeginAnimation(Border.WidthProperty, animation);
        }

        public static bool calendar = false;

        private void TabItem_DragEnter(object sender, DragEventArgs e)
        {
            System.Windows.MessageBox.Show("Hello world");
        }

        private void ButtonCloseCalendar_Click(object sender, RoutedEventArgs e)
        {
            tab1.SelectedIndex = -1;
            ButtonCloseCalendar.Visibility = Visibility.Collapsed;
            ButtonOpenCalendar.Visibility = Visibility.Visible;
            calendar = true;
        }

        private void tab1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar)
            {
                WidenObject(332, TimeSpan.FromSeconds(0.4));
                ButtonCloseCalendar.Visibility = Visibility.Visible;
                ButtonOpenCalendar.Visibility = Visibility.Collapsed;
                calendar = false;
            }
        }

        public class Otkaz
        {
            public int id { get; set; }
            public string client { get; set; }
            public string phone { get; set; }
            public string address { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
        }

        public List<Otkaz> otkazList;
    }
}
