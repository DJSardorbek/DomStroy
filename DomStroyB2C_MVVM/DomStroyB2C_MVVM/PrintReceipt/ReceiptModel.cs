
namespace DomStroyB2C_MVVM.PrintReceipt
{
    public class ReceiptModel
    {
        public string product_name { get; set; }

        public double selling_price { get; set; }

        public double amount { get; set; }

        public double total_sum { get { return selling_price * amount; } }
    }
}
