using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Invoce_sended
{
    interface IInvoice_sendedService
    {
        Task<Invoice_sendedModel> GetAll();

        Task<bool> Patch(int id, Invoice_status model);
    }
}
