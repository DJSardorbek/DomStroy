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
    /// Interaction logic for ReportHodimlarView.xaml
    /// </summary>
    public partial class ReportHodimlarView : UserControl
    {
        public ReportHodimlarView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));

            employeeReports = new List<EmployeeReport>()
            {
                new EmployeeReport {id=1,employee = "Sardorbek Sodiqjonov", filial = "Tashkent", naqd_som = 10000, naqd_dollar = 500, plastik = 10000, transfer=10000, nasiya_som=350000, nasiya_dollar = 100},
                new EmployeeReport {id=2, employee = "Maxkamov Abubakir", filial = "Andijan", naqd_som = 10000, naqd_dollar = 500, plastik = 10000, transfer=10000, nasiya_som=350000, nasiya_dollar = 100},
                new EmployeeReport {id=3, employee = "Gu'lomqodirov Abdurahmon", filial = "Fergana", naqd_som = 10000, naqd_dollar = 500, plastik = 10000, transfer=10000, nasiya_som=350000, nasiya_dollar = 100},
                new EmployeeReport {id=4, employee = "Nomozov Muhammadrizo", filial = "Tashkent", naqd_som = 10000, naqd_dollar = 500, plastik = 10000, transfer=10000, nasiya_som=350000, nasiya_dollar = 100},
                new EmployeeReport {id=5, employee = "Abdukhoshimov Khondamir", filial = "Tashkent", naqd_som = 10000, naqd_dollar = 500, plastik = 10000, transfer=10000, nasiya_som=350000, nasiya_dollar = 100}
            };
            dataGridREmployee.ItemsSource = employeeReports;
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

        public class EmployeeReport
        {
            public int id { get; set; }
            public string employee { get; set; }
            public string filial { get; set; }
            public double naqd_som { get; set; }
            public double naqd_dollar { get; set; }
            public double plastik { get; set; }
            public double transfer { get; set; }
            public double nasiya_som { get; set; }
            public double nasiya_dollar { get; set; }
        }

        public List<EmployeeReport> employeeReports;
    }
}
