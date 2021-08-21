using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop.Cart
{
    interface ICartService
    {
        Task<string> Post(string json);

        Task<bool> Patch(int id, CartModel model);
    }
}
