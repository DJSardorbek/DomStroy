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
    /// Interaction logic for FakturaReportView.xaml
    /// </summary>
    public partial class FakturaReportView : UserControl
    {
        public FakturaReportView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));
            fakturaList = new List<FakturaReport>()
            {
                new FakturaReport(){id =1, name="Faktura1", saler = "Sodiqjonov Sardorbek", date = DateTime.Now, branch = "Andijon", som = 100000, dollar = 1000 },
                new FakturaReport(){id =1, name="Faktura2", saler = "Maxkamov Abubakir", date = DateTime.Now, branch = "Andijon", som = 100000, dollar = 1000 },
                new FakturaReport(){id =1, name="Faktura3", saler = "G'ulomqadirov Abdurahmon", date = DateTime.Now, branch = "Andijon", som = 100000, dollar = 1000 },
                new FakturaReport(){id =1, name="Faktura4", saler = "Abduhoshimov Xondamir", date = DateTime.Now, branch = "Andijon", som = 100000, dollar = 1000 },
                new FakturaReport(){id =1, name="Faktura5", saler = "Kamoliddinov Jamoliddin", date = DateTime.Now, branch = "Sirdaryo", som = 100000, dollar = 1000 },
                new FakturaReport(){id =1, name="Faktura6", saler = "Namozov Muhammadrizo", date = DateTime.Now, branch = "Namangan", som = 100000, dollar = 1000 }
            };

            dataGridFakturaReport.ItemsSource = fakturaList;
        }

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

        public class FakturaReport
        {
            public int id { get; set; }
            public string name { get; set; }
            public string saler { get; set; }
            public DateTime date { get; set; }
            public string branch { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
        }

        public List<FakturaReport> fakturaList;
    }
}
