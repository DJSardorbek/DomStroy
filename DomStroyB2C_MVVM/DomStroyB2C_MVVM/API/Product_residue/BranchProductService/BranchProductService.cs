using DomStroyB2C_MVVM.ViewModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Product_residue.ProductService
{
    class BranchProductService : IBranchProductService
    {
        public async Task<BranchProduct> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.PRODUCT + $"?branch={MainWindowViewModel.branch}");
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<BranchProduct>(content);
                    return products;
                }
            }
        }
    }
}
