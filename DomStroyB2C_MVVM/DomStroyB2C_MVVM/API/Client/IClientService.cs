using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Client
{
    interface IClientService
    {
        Task<string> Post(ClientModel model);
    }
}
