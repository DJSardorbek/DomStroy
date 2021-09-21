using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Debtor.PaymentHistory
{
    public class PaymentHistory
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public Staff staff { get; set; }
        public Branch branch { get; set; }
        public Client client { get; set; }
        public string paid_at { get; set; }
        public double card { get; set; }
        public double cash_sum { get; set; }
        public double cash_dollar { get; set; }
        public double discount_sum { get; set; }
        public double discount_dollar { get; set; }
        public double transfer { get; set; }
        public double from_ball { get; set; }
        public string comment { get; set; }
        public bool payment_for_loan { get; set; }
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
    public class Staff
    {
        public int id { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int branch { get; set; }
        public int section { get; set; }
        public string birth_date { get; set; }
        public string role { get; set; }
    }
}
