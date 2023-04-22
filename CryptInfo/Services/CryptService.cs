using CryptInfo.Models.Assets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Services
{
    internal class CryptService
    {
        private const string _apiKey = "a6a82357-9743-4f77-ac59-e22b3f4f8e44";
        public readonly string BASE_URL = "http://api.coincap.io/v2";

        private HttpClient httpClient;


        public async Task<T> GetData<T>(params string[] parts)
        {
            
            var request = new HttpRequestMessage(HttpMethod.Get, string.Join("/", parts));

            var response = await httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }

        public CryptService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "deflate");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
        }
    }
}
