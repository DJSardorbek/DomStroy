using Newtonsoft.Json;
using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop.Cart.CartService
{
    class CartService : ICartService
    {
        public async Task<string> Post(CartModel model)
        {
            string result = "error";
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.CART);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using(HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content))
                {
                    if(response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            return result;
        }
    }
}
