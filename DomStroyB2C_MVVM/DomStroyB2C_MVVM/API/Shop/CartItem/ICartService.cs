
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop.CartItem
{
    interface ICartService
    {
        Task<bool> Post(CartItemModel model);
    }
}
