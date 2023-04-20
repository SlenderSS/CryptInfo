using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Services
{
    class CryptService
    {
        private const string _apiKey = "a6a82357-9743-4f77-ac59-e22b3f4f8e44";
        private const string _baseURL = "http://api.coincap.io/v2/";

        public HttpClient httpClient;


        public async Task GetData(params string[] parts)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, string.Join("/", _baseURL, parts));


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
