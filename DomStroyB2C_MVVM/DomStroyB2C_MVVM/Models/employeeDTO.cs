
using System.ComponentModel;

namespace DomStroyB2C_MVVM.Models
{
    public class employeeDTO
    {
        public string token { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int branch { get; set; }
        public int section { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string role { get; set; }
    }
}
