using DomStroyB2C_MVVM.ViewModels;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for QueueBuyurtmaView.xaml
    /// </summary>
    public partial class QueueBuyurtmaView : UserControl
    {
        public QueueBuyurtmaView()
        {
            InitializeComponent();
            DataContext = new QueueBuyurtmalarViewModel();
        }
    }
}
