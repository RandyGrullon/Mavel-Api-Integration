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

        public string ApiKey { get=> "apikey=37a20968b5c9f1e39a5cfb7b2244a718&hash=ac9b44833ce206eec214b4fb3203ee68&ts=1";}
        public async Task<ComicsBooks> GetComic()
        {
            HttpClient httpClient = new HttpClient();
            var Result = await httpClient.GetStringAsync($"https://gateway.marvel.com:443/v1/public/comics?orderBy=-modified&limit=50&{ApiKey}");
            return JsonConvert.DeserializeObject<ComicsBooks>(Result);
            var x = 1;
        }

        
    }
}

