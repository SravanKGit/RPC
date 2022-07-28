using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace RPC.Models
{
    public static class Fixer
    {
        public static ConvertResponse GetConvertedCurrency(string from, string amount, string to)
        {
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("apikey", "qhFgdo8pCPf2yM47D0mJ2RmdkMOARwa0");

            HttpResponseMessage response =  httpClient.GetAsync("https://api.apilayer.com/fixer/convert?to="+to+"&from="+from +"&amount="+amount).Result;


            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<ConvertResponse>(result);
        }
    }
}