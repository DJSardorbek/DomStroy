using DomStroyB2C_MVVM.ViewModels;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for TovarQoldiqView.xaml
    /// </summary>
    public partial class TovarQoldiqView : UserControl
    {
        public TovarQoldiqView()
        {
            InitializeComponent();
            this.DataContext = new TovarQoldiqViewModel();
        }
    }
}
