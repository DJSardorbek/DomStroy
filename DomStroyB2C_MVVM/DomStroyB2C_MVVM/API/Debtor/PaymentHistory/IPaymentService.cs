using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor.PaymentHistory
{
    interface IPaymentService
    {
        Task<PaymentHistory> GetPaymentList(int client_id);

        Task<PaymentHistory> PaymentPagination(string url);
    }
}
