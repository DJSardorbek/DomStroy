
namespace DomStroyB2C_MVVM.API.Shop
{
    public class ShopResponse
    {
        public int id { get; set; }
        public Client client { get; set; }
        public Branch branch { get; set; }
        public Seller seller { get; set; }
        public double card { get; set; }
        public double loan_sum { get; set; }
        public double cash_sum { get; set; }
        public double discount_sum { get; set; }
        public double loan_dollar { get; set; }
        public double discount_dollar { get; set; }
        public double transfer { get; set; }
        public double cash_dollar { get; set; }
    }

    public class Client
    {
        public int id { get; set; }
        public string phone_1 { get; set; }
        public double loan_dollar { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string birth_date { get; set; }
        public string return_date { get; set; }
        public object phone_2 { get; set; }
        public double loan_sum { get; set; }
        public double ball { get; set; }
    }

    public class Branch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class Seller
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }

    
}
