using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.InvoiceItem_sended
{
    public class InvoiceItem_sended
    {
        public int id { get; set; }
        public Product product { get; set; }
        public double get_summa { get; set; }
        public double amount { get; set; }
        public double selling_price { get; set; }
        public object expire_date { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public Category category { get; set; }
        public int branch { get; set; }
        public object section { get; set; }
        public int deliver { get; set; }
        public Producer producer { get; set; }
        public string currency { get; set; }
        public string status { get; set; }
        public string name { get; set; }
        public int ball { get; set; }
        public string measurement { get; set; }
        public string monthly_minimal_amout { get; set; }
        public double cost { get; set; }
        public string barcode { get; set; }
        public double selling_price { get; set; }
        public List<ExpireDate> expire_dates { get; set; }
        public double all_amount { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Producer
    {
        public string name { get; set; }
    }

    public class ExpireDate
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string expire_date { get; set; }
    }
}
