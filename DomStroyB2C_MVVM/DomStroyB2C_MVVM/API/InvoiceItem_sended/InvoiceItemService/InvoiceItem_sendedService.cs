using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.InvoiceItem_sended.InvoiceItemService
{
    class InvoiceItem_sendedService : IInvoiceItem_sendedService
    {
        public async Task<IEnumerable<InvoiceItem_sended>> GetAll(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.INVOICEITEM_SENDED + Id + '/');
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    IEnumerable<InvoiceItem_sended> invoiceitems = JsonConvert.DeserializeObject<IEnumerable<InvoiceItem_sended>>(content);
                    return invoiceitems;
                }

            }
        }
    }
}
