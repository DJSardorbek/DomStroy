using System;
using System.Threading.Tasks;
using System.Windows;

namespace DomStroyB2C_MVVM.Views.Loading
{
    /// <summary>
    /// Interaction logic for LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window, IDisposable
    {
        public Action Worker { get; set; }
        public LoadingWindow(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        public void Dispose()
        {

        }
    }
}
