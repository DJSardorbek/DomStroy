using System.Collections.Generic;
using System.ComponentModel;

namespace DomStroyB2C_MVVM.API.InvoiceItem_sended
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class InvoiceItem_sended : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public int id { get; set; }
        public Product product { get; set; }
        public double get_summa { get; set; }
        public double amount { get; set; }
        public double selling_price { get; set; }
        public string expire_date { get; set; }
        public string status { get; set; }

        private bool _accepted;

        public bool accepted
        {
            get { return _accepted; }
            set { _accepted = value; OnPropertyChanged("accepted"); }
        }

        public bool enabled { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public Category category { get; set; }
        public object branch { get; set; }
        public Section section { get; set; }
        public int deliver { get; set; }
        public Producer producer { get; set; }
        public string currency { get; set; }
        public string name { get; set; }
        public double ball { get; set; }
        public string measurement { get; set; }
        public string monthly_minimal_amout { get; set; }
        public double cost { get; set; }
        public string barcode { get; set; }
        public double selling_price { get; set; }
        public double all_amount { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Section
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Producer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public object country { get; set; }
    }
}
