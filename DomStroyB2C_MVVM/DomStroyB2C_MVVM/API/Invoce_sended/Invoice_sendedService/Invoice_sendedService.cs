using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Invoce_sended.Invoice_sendedService
{
    class Invoice_sendedService : IInvoice_sendedService
    {
        public async Task<Invoice_sendedModel> GetAll()
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.INVOICE_SENDED);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using(HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var invoices = JsonConvert.DeserializeObject<Invoice_sendedModel>(content);
                    return invoices;
                }
            }
        }

        public async Task<bool> Patch(int id, Invoice_status model)
        {
            var result = false;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.INVOICEITEM_SENDED + id.ToString() + '/');
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var method = new HttpMethod("PATCH");
                var request = new HttpRequestMessage(method, client.BaseAddress)
                {
                    Content = content
                };

                using (HttpResponseMessage response = await client.SendAsync(request))
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
