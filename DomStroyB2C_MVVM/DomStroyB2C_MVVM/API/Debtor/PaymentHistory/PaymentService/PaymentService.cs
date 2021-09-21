using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor.PaymentHistory.PaymentService
{
    class PaymentService : IPaymentService
    {
        public async Task<PaymentHistory> GetPaymentList(int client_id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.CLIENT_HISTORY + $"?id={client_id}");
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var payments = JsonConvert.DeserializeObject<PaymentHistory>(content);
                    return payments;
                }
            }
        }

        public async Task<PaymentHistory> PaymentPagination(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var payments = JsonConvert.DeserializeObject<PaymentHistory>(content);
                    return payments;
                }
            }
        }
    }
}
