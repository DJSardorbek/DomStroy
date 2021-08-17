using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Invoce_sended
{
    interface IInvoice_sendedService
    {
        Task<IEnumerable<Invoice_sendedModel>> GetAll();
    }
}
