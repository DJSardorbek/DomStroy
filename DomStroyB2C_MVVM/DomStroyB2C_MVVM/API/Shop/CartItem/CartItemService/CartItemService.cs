using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Shop.CartItem.CartItemService
{
    class CartItemService : ICartService
    {
        public async Task<bool> Post(CartItemModel model)
        {
            bool result = false;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.CARTITEM);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
