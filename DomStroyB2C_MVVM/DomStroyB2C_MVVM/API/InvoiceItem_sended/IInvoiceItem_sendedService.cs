using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.InvoiceItem_sended
{
    interface IInvoiceItem_sendedService
    {
        Task<IEnumerable<InvoiceItem_sended>> GetAll(int Id);
    }
}
