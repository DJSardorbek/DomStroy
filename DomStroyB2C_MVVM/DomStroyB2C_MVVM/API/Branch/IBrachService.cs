using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Branch
{
    interface IBrachService
    {
        Task<List<Branch>> GetAll();
    }
}
