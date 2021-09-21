using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor.DoingPayment.DoingPaymentService
{
    class DoingPaymentService : IDoingPaymentService
    {
        public async Task<bool> Post(DoingPayment model)
        {
            var response = false;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.CLIENT_LOAN_PAYMENT);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage result = await client.PostAsync(client.BaseAddress, content))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        response = true;
                    }
                }
            }
            return response;
        }
    }
}
