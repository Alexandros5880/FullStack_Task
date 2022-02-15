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
            string token = await this.GetToken();
            string url = @"https://www.universal-tutorial.com/api/countries";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"bearer {token}");
            HttpResponseMessage response = await client.GetAsync(url);
            //response.EnsureSuccessStatusCode();
            if ( response.StatusCode == System.Net.HttpStatusCode.OK )
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ICollection<Country>>(responseBody);
            }
            else
            {
                return null;
            }
        }

        public async Task<ICollection<State>> GetStatesOfCountry(string countryName)
        {
            string token = await this.GetToken();
            string url = @"https://www.universal-tutorial.com/api/states/"+ countryName;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"bearer {token}");
            HttpResponseMessage response = await client.GetAsync(url);
            //response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ICollection<State>>(responseBody);
            }
            else
            {
                return null;
            }
        }

        protected async Task<string> GetToken()
        {
            string url = @"https://www.universal-tutorial.com/api/getaccesstoken";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("api-token", "Ppu_YoFxhWYYohIzKTF8znRhoq5BaAgUVSCA5-CMTJ4sRgs9_WMHr30m98G6L7KLh_8");
            client.DefaultRequestHeaders.Add("user-email", "alexandrosplatanios30@gmail.com");
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Token>(responseBody).Auth_token;
            }
            else
            {
                return null;
            }
        }
        protected class Token
        {
            public string Auth_token { get; set; }
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
