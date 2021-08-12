using System;

namespace DomStroyB2C_MVVM.Models
{
    public class employeeDTO
    {
        public string token { get; set; }
        public Data data { get; set; }
    }

    public class Branch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateTime created_at { get; set; }
    }

    public class Section
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public Branch branch { get; set; }
        public Section section { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string role { get; set; }
    }
}
