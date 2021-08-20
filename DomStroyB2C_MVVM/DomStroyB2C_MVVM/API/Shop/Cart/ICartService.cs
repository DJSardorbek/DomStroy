using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop.Cart
{
    interface ICartService
    {
        Task<string> Post(CartModel model);
    }
}
