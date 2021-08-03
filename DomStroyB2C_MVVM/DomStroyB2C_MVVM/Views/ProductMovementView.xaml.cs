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
    /// Interaction logic for ProductMovementView.xaml
    /// </summary>
    public partial class ProductMovementView : UserControl
    {
        public ProductMovementView()
        {
            InitializeComponent();
            WidenObject(332, TimeSpan.FromSeconds(1));
            productMovements = new List<ProductMovement>()
            {
                new ProductMovement() {id =1, faktura_name = "10.02.2021", employee = "Sardorbek", dollar = 1000, som = 3560000, date = DateTime.Now, from_branch="Asosiy filial", to_branch="Chakana savdo" },
                new ProductMovement() {id =2, faktura_name = "11.02.2021", employee = "Abdurahmon", dollar = 1000, som = 3560000, date = DateTime.Now, from_branch="Asosiy filial", to_branch="Chakana savdo" },
                new ProductMovement() {id =3, faktura_name = "15.02.2021", employee = "Abdullo", dollar = 1000, som = 3560000, date = DateTime.Now, from_branch="Asosiy filial", to_branch="Chakana savdo" },
                new ProductMovement() {id =4, faktura_name = "20.02.2021", employee = "Lazizbek", dollar = 1000, som = 3560000, date = DateTime.Now, from_branch="Asosiy filial", to_branch="Chakana savdo" }
            };

            dataGridMovement.ItemsSource = productMovements;
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

        public class ProductMovement
        {
            public int id { get; set; }
            public string faktura_name { get; set; }
            public string employee { get; set; }
            public double dollar { get; set; }
            public double som { get; set; }
            public DateTime date { get; set; }
            public string from_branch { get; set; }
            public string to_branch { get; set; }
        }

        public List<ProductMovement> productMovements;
    }
}
