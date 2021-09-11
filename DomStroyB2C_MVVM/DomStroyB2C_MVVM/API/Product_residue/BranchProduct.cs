using System;
using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Product_residue
{
    class BranchProduct
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public Product product { get; set; }
        public double selling_price { get; set; }
        public int branch { get; set; }
        public double get_amount { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
    }
    public class Product
    {
        public int id { get; set; }
        public int deliver { get; set; }
        public Producer producer { get; set; }
        public string currency { get; set; }
        public string name { get; set; }
        public double ball { get; set; }
        public string measurement { get; set; }
        public string monthly_minimal_amout { get; set; }
        public double cost { get; set; }
        public string barcode { get; set; }
        public DateTime created_at { get; set; }
    }
    public class Producer
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
