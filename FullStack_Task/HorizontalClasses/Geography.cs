using FullStack_Task.HorizontalClasses.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FullStack_Task.HorizontalClasses
{
    public class Geography : IGeography
    {
        public async Task<ICollection<Country>> GetCountries()
        {
            string url = @"https://www.universal-tutorial.com/api/countries";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjp7InVzZXJfZW1haWwiOiJhbGV4YW5kcm9zcGxhdGFuaW9zMjhAZ21haWwuY29tIiwiYXBpX3Rva2VuIjoid0MzNGlKVjFlWHVqZHlwNVNTaGltcUZSSWtYbloxeWxzTEJtMGlIU3VfSi1EQkpYRGR5R0ZsVUpRS0FRRHZaMVRFRSJ9LCJleHAiOjE2NDQ3ODEzNzB9.zDRoBPbTigIGJJIt4KG9qgKyVShzYsrc3TBi_IP2qbA");
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICollection<Country>>(responseBody);
        }

        public async Task<ICollection<State>> GetStatesOfCountry(string countryName)
        {
            string url = @"https://www.universal-tutorial.com/api/states/"+ countryName;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjp7InVzZXJfZW1haWwiOiJhbGV4YW5kcm9zcGxhdGFuaW9zMjhAZ21haWwuY29tIiwiYXBpX3Rva2VuIjoid0MzNGlKVjFlWHVqZHlwNVNTaGltcUZSSWtYbloxeWxzTEJtMGlIU3VfSi1EQkpYRGR5R0ZsVUpRS0FRRHZaMVRFRSJ9LCJleHAiOjE2NDQ3ODEzNzB9.zDRoBPbTigIGJJIt4KG9qgKyVShzYsrc3TBi_IP2qbA");
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICollection<State>>(responseBody);
        }


    }

    public class Country
    {
        public string Country_name { get; set; }
        public string Country_short_name { get; set; }
        public string Country_phone_code { get; set; }
    }

    public class State
    {
        public string State_name { get; set; }
    }


}
