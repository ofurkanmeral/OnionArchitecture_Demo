using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrapper
{
    public class HttpClientWrapper
    {
        private static readonly HttpClient _client;

        static HttpClientWrapper()
        {
            _client = new HttpClient();
        }

        public async Task<string> GetStringAsyncWrapper(string url)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync();
                else
                    throw new Exception($"Error Code {response.StatusCode}");
            }
            catch (Exception e)
            {
                throw new Exception($"Get Request Error => " + e.Message);
            }
        }
    }
}
