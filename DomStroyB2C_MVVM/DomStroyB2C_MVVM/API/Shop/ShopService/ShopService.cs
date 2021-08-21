using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
namespace DomStroyB2C_MVVM.API.Shop.ShopService
{
    class ShopService : IShopService
    {
        public async Task<string> Post(ShopModel model)
        {
            var response = "error";
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.SHOP);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using(HttpResponseMessage result = await client.PostAsync(client.BaseAddress, content))
                {
                    if(result.IsSuccessStatusCode)
                    {
                        response = await result.Content.ReadAsStringAsync();
                    }
                }
            }
            return response;
        }
    }
}
