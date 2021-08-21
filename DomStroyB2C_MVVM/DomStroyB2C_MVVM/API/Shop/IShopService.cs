using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop
{
    interface IShopService
    {
        Task<string> Post(ShopModel model);
    }
}
