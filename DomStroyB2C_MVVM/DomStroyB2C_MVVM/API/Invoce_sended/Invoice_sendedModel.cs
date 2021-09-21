using System;
using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Invoce_sended
{
    public class Invoice_sendedModel
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public Staff staff { get; set; }
        public int deliver { get; set; }
        public double expense { get; set; }
        public double summa_sum { get; set; }
        public double summa_dollar { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public ToBranch to_branch { get; set; }
        public FromBranch from_branch { get; set; }
        public Section section { get; set; }
    }

    public class Staff
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class ToBranch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class FromBranch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class Section
    {
        public int id { get; set; }
    }
}
