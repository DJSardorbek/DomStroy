using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Minimal.MinimalService
{
    class MinimalService : IMinimalService
    {
        public async Task<ProductMinimal> Get(string product_id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.MINIMAL + $"{product_id}/");
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<ProductMinimal>(content);
                    return products;
                }
            }
        }

        public async Task<bool> Post(MinimalPost model)
        {
            var response = false;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.MINIMAL);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                System.Windows.MessageBox.Show(AllApi.MINIMAL);
                System.Windows.MessageBox.Show(json);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage result = await client.PostAsync(client.BaseAddress, content))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        System.Windows.MessageBox.Show(result.IsSuccessStatusCode.ToString());
                        response = true;
                    }
                }
            }
            return response;
        }
    }
}
