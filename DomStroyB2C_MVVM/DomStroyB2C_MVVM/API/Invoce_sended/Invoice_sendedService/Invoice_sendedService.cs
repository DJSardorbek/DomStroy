using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Invoce_sended.Invoice_sendedService
{
    class Invoice_sendedService : IInvoice_sendedService
    {
        public async Task<IEnumerable<Invoice_sendedModel>> GetAll()
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.INVOICE_SENDED);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using(HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    IEnumerable<Invoice_sendedModel> invoices = JsonConvert.DeserializeObject<IEnumerable<Invoice_sendedModel>>(content);
                    return invoices;
                }
            }
        }
    }
}
