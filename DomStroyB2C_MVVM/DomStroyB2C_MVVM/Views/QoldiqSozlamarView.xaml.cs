using DomStroyB2C_MVVM.ViewModels;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for QoldiqSozlamarView.xaml
    /// </summary>
    public partial class QoldiqSozlamarView : UserControl
    {
        public QoldiqSozlamarView()
        {
            InitializeComponent();
            this.DataContext = new QoldiqSozlamalarViewModel();
        }
    }
}
