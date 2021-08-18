using System;

namespace DomStroyB2C_MVVM.API.Invoce_sended
{
    public class Invoice_sendedModel
    {
        public int id { get; set; }

        public int deliver { get; set; }

        public double get_item_sum { get; set; }

        public double get_item_dollar { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public DateTime created_at { get; set; }

        public FromBranch from_branch { get; set; }

        public ToBranch to_branch { get; set; }
    }

    public class FromBranch
    {
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public DateTime created_at { get; set; }
    }

    public class ToBranch
    {
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public DateTime created_at { get; set; }
    }
}
