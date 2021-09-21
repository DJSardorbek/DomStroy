using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Debtor
{
    public class Debtor
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_1 { get; set; }
        public object phone_2 { get; set; }
        public string address { get; set; }
        public string return_date { get; set; }
        public double loan_dollar { get; set; }
        public double loan_sum { get; set; }
        public int ball { get; set; }
        public DiscountCard discount_card { get; set; }
    }

    public class DiscountCard
    {
        public int id { get; set; }
        public double bonus_dollar { get; set; }
        public string card { get; set; }
        public double bonus_sum { get; set; }
    }
}
