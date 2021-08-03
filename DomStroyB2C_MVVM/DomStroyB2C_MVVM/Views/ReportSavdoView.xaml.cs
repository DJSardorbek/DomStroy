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
    /// Interaction logic for ReportSavdoView.xaml
    /// </summary>
    public partial class ReportSavdoView : UserControl
    {
        public ReportSavdoView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));
            summaList = new List<summa>()
            {
                new summa() {naqd_som=350000, naqd_dollar = 15, plastik = 50000, transfer = 10000, som = 50000, dollar = 200}
            };
            dataGridSumma.ItemsSource = summaList;

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

        public class summa
        {
            public double naqd_som { get; set; }
            public double naqd_dollar { get; set; }
            public double plastik { get; set; }
            public double transfer { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
        }

        public List<summa> summaList;
    }
}
