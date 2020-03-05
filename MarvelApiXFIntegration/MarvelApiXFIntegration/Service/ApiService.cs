using MarvelApiXFIntegration.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using  MarvelApiXFIntegration.Models;

namespace MarvelApiXFIntegration.Service
{
    public class ApiService : IApiService
    {
        const string Api = "apikey=37a20968b5c9f1e39a5cfb7b2244a718&hash=ac9b44833ce206eec214b4fb3203ee68&ts=1";
        const string Url = "https://gateway.marvel.com:443/v1/public/comics?orderBy=-modified&limit=50&";
        public string ApiKey { get => $"{Api}";}
        public async Task<ComicsBook> GetComic()
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{Url}{ApiKey}");
            return JsonConvert.DeserializeObject<ComicsBook>(result);
        }

        
    }
}

