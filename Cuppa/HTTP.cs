using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Cuppa
{
    public class HTTP
    {
        private readonly HttpClient httpClient;
        
        public HTTP()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> GetStringAsync(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
        }
    }
}
