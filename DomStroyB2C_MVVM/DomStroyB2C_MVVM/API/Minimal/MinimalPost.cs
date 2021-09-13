using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Minimal
{
    class MinimalPost
    {
        public string product { get; set; }
        public List<Minimal1> minimals { get; set; }
    }

    public class Minimal1
    {
        public double amount { get; set; }
        public string month { get; set; }
    }
}
