using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.InvoiceItem_sended
{
    public class Invoice_accept
    {
        public int invoice_id { get; set; }
        public List<int> invoice_list { get; set; }
        public double expense { get; set; }
    }
}
