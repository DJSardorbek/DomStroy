using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor
{
    interface IDebtorService
    {
        Task<Debtor> FilterDebtor(string status);

        Task<Debtor> DebtorPagination(string url);

        Task<Debtor> SearchDebtor(string status,string search);

    }
}
