using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Minimal
{
    interface IMinimalService
    {
        Task<ProductMinimal> Get(string product_id);

        Task<bool> Post(MinimalPost model);
    }
}
