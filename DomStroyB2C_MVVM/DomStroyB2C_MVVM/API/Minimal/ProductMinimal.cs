using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Minimal
{
    class ProductMinimal
    {
        public string product_id { get; set; }
        public List<Minimal> minimals { get; set; }
    }

    public class Minimal
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string month { get; set; }
    }
}
