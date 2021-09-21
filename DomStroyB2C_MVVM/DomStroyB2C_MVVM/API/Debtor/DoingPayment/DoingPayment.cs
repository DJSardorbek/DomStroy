namespace DomStroyB2C_MVVM.API.Debtor.DoingPayment
{
    public class DoingPayment
    {
        public int staff { get; set; }
        public int branch { get; set; }
        public int client { get; set; }
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
}
