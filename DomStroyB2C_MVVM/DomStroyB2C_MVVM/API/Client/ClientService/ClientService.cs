using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Client.ClientService
{
    class ClientService : IClientService
    {
        public async Task<string> Post(ClientModel model)
        {
            var response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.CLIENT);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage result = await client.PostAsync(client.BaseAddress, content))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        response = await result.Content.ReadAsStringAsync();
                    }

                    else
                    {
                        response = "error";
                    }
                }
            }
            return response;
        }
    }
}
