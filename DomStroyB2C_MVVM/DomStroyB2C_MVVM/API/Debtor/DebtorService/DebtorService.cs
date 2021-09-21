using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Debtor.DebtorService
{
    class DebtorService : IDebtorService
    {
        public async Task<Debtor> FilterDebtor(string status)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.DEBTOR + $"?status={status}");
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var debtors = JsonConvert.DeserializeObject<Debtor>(content);
                    return debtors;
                }
            }
        }

        public async Task<Debtor> DebtorPagination(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var debtors = JsonConvert.DeserializeObject<Debtor>(content);
                    return debtors;
                }
            }
        }

        public async Task<Debtor> SearchDebtor(string status,string search)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.DEBTOR + $"?status={status}&search={search}");
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var debtors = JsonConvert.DeserializeObject<Debtor>(content);
                    return debtors;
                }
            }
        }
    }
}
