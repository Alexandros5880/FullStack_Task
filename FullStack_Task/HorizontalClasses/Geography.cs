using FullStack_Task.HorizontalClasses.Interfaces;
using FullStack_Task.Models.OtherModels;
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
            string url = @"https://restcountries.com/v3.1/all";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            ICollection<CountriesModel> countriesM = JsonConvert.DeserializeObject<ICollection<CountriesModel>>(responseBody);
            List<Country> countries = new List<Country>();
            foreach(var country in countriesM)
            {
                var c = new Country()
                {
                    CommonName = country.Name.Common,
                    OfficialName = country.Name.Official,
                    Region = country.Region,
                    Population = country.Population
                };
                if (country.Capital != null)
                {
                    foreach (var cap in country.Capital)
                    {
                        c.Capital.Add(cap);
                    }
                }
                if (country.PostalCode != null)
                {
                    c.PostalCodeFormat = country.PostalCode.Format;
                    c.PostalCodeRegex = country.PostalCode.Regex;
                }
                countries.Add(c);
            }
            return countries;
        }

        public async Task<ICollection<Country>> GetCountriesAndStates()
        {
            string url = @"https://countriesnow.space/api/v0.1/countries/states";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            CountriesStatesResponse responseData = JsonConvert.DeserializeObject<CountriesStatesResponse>(responseBody);
            List<Country> countries = new List<Country>();
            foreach (var d in responseData.data)
            {
                countries.Add(new Country()
                {
                    Name = d.name,
                    Iso3 = d.iso3,
                    Iso2 = d.iso2,
                    States = d.states
                });
            }
            return countries;
        }

        public ICollection<State> GetStatesOfCountry(ICollection<Country> countries, string countryName)
        {
            foreach(var country in countries)
            {
                if (country.Name.Equals(countryName))
                {
                    return country.States;
                } 
            }
            return new List<State>() { new State() { Name = "", State_code = "" } };
        }

        protected class CountriesStatesResponse
        {
            public bool error { get; set; }
            public string msg { get; set; }
            public ICollection<CountriesStatesData> data { get; set; }
        }

        protected class CountriesStatesData
        {
            public string name { get; set; }
            public string iso3 { get; set; }
            public string iso2 { get; set; }
            public ICollection<State> states { get; set; }
        }

        protected class CountriesModel
        {
            public SubName Name { get; set; }
            public string[] Capital { get; set; }
            public string Region { get; set; }
            public long Population { get; set; }
            public PostalCodeModel PostalCode { get; set; }
        }

        protected class SubName
        {
            public string Common { get; set; }
            public string Official { get; set; }
        }

        protected class PostalCodeModel
        {
            public string Format { get; set; }
            public string Regex { get; set; }
        }

    }


    


}
