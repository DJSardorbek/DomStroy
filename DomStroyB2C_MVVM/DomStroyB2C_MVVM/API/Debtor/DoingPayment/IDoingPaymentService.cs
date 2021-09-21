using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor.DoingPayment
{
    interface IDoingPaymentService
    {
        Task<bool> Post(DoingPayment model);
    }
}
