using DomStroyB2C_MVVM.PrintReceipt;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Controls;

namespace DomStroyB2C_MVVM.Views
{
    /// <summary>
    /// Interaction logic for ChashDeskView.xaml
    /// </summary>
    public partial class ChashDeskView : UserControl
    {
        public ChashDeskView()
        {
            InitializeComponent();
        }

        public List<ReceiptModel> list;

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            list = new List<ReceiptModel>()
            {
                new ReceiptModel(){ product_name = "Akfa lampochka 5W", amount = 500, selling_price = 15000},
                new ReceiptModel(){ product_name = "Akfa lampochka 15W", amount = 120, selling_price = 18000},
                new ReceiptModel(){ product_name = "Akfa lampochka 25W", amount = 489, selling_price = 20000},
                new ReceiptModel(){ product_name = "Akfa lampochka 35W", amount = 752, selling_price = 25000},
                new ReceiptModel(){ product_name = "Akfa lampochka 55W", amount = 453, selling_price = 35000}
            };

            using(frmPrint frm = new frmPrint(list, "12.07.2021 12:35", "74560", "Sardorbek", "1523000", "0", "1523000", "0"))
            {
                frm.ShowDialog();
            }
        }
    }
}
