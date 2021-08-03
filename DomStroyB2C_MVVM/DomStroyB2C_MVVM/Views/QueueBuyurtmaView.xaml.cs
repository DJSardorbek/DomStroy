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
    /// Interaction logic for QueueBuyurtmaView.xaml
    /// </summary>
    public partial class QueueBuyurtmaView : UserControl
    {
        public QueueBuyurtmaView()
        {
            InitializeComponent();

            clientOrderList = new List<ClientOrder>()
            {
                new ClientOrder(){id =1, saler = "Sardorbek", client = "Jamoliddin", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 },
                new ClientOrder(){id =2, saler = "Abdullo", client = "Abdurahmon", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 },
                new ClientOrder(){id =3, saler = "Azizbek", client = "Lazizbek", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 },
                new ClientOrder(){id =4, saler = "Sardorbek", client = "Kamronbek", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 },
                new ClientOrder(){id =5, saler = "Muhammadrizo", client = "Jamoliddin", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 },
                new ClientOrder(){id =6, saler = "Asatbek", client = "Dilshodbek", phone = "+998936589598", ol_date = DateTime.Now, kel_date = DateTime.Now, som = 365000, dollar = 520 }

            };

            dataGridOrder.ItemsSource = clientOrderList;
        }

        public class ClientOrder
        {
            public int id { get; set; }
            public string saler { get; set; }
            public string client { get; set; }
            public string phone { get; set; }
            public DateTime ol_date { get; set; }
            public DateTime kel_date { get; set; }
            public double som { get; set; }
            public double dollar { get; set; }
        }

        public List<ClientOrder> clientOrderList;
    }
}
