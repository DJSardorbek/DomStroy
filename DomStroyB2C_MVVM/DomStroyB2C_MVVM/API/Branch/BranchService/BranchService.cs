using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DomStroyB2C_MVVM.API.Branch.BranchService
{
    class BranchService : IBrachService
    {
        public async Task<List<Branch>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(AllApi.BRANCH);
                client.DefaultRequestHeaders.Add("Authorization", AllApi.AUTH_TOKEN);

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var branches = JsonConvert.DeserializeObject<List<Branch>>(content);
                    return branches;
                }
            }
        }
    }
}
