using DomStroyB2C_MVVM.ViewModels;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for QueueNavbatlarView.xaml
    /// </summary>
    public partial class QueueNavbatlarView : UserControl
    {
        public QueueNavbatlarView()
        {
            InitializeComponent();
            this.DataContext = new QueueNavbatlarViewModel();
        }
    }
}
