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
    /// Interaction logic for BuyurtmalarTarixiView.xaml
    /// </summary>
    public partial class BuyurtmalarTarixiView : UserControl
    {
        public BuyurtmalarTarixiView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));
            orderList = new List<Orders>()
            {
                new Orders(){branch = "Andjan", saler = "Sardorbek", client = "Abdurahmon", phone = "+998931584849", date = DateTime.Now, som = 1000000, dollar = 15, tul = "Naqd pul"},
                new Orders(){branch = "Fergana", saler = "Abubakir", client = "Khondamir", phone = "+998931584849", date = DateTime.Now, som = 1000000, dollar = 15, tul = "Naqd pul"},
                new Orders(){branch = "Sirdaryo", saler = "Jamoliddin", client = "Mukhammadrizo", phone = "+998931584849", date = DateTime.Now, som = 1000000, dollar = 15, tul = "Naqd pul"},
                new Orders(){branch = "Tashkent", saler = "Galimjan", client = "Khojiakbar", phone = "+998931584849", date = DateTime.Now, som = 1000000, dollar = 15, tul = "Naqd pul"}
            };

            dataGridOrders.ItemsSource = orderList;
        }

        public class Orders
        {
            public string branch { get; set; }
            public string saler { get; set; }
            public string client { get; set; }
            public string phone { get; set; }
            public DateTime date { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
            public string tul { get; set; }
        }

        public List<Orders> orderList;

        private void WidenObject(int newWidth, TimeSpan duration)
        {
            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            GridMenu.BeginAnimation(Border.WidthProperty, animation);
        }

        public static bool calendar = false;

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
    }
}
