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
using System.Windows.Shapes;

namespace DomStroyB2C_MVVM.Views.Loading
{
    /// <summary>
    /// Interaction logic for LoadingWindowGif.xaml
    /// </summary>
    public partial class LoadingWindowGif : Window
    {
        public LoadingWindowGif()
        {
            InitializeComponent();
            media.Source = new Uri(Environment.CurrentDirectory + @"\loading.gif");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {

        }
    }
}
