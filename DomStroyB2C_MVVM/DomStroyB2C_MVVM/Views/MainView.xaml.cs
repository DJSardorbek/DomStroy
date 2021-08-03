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
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        MainWindow main = (MainWindow)Application.Current.MainWindow;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 7;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 8;
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 6;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 9;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 3;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 5;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 2;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 4;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 10;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 11;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            main.ListView.SelectedIndex = 13;
        }
    }
}
