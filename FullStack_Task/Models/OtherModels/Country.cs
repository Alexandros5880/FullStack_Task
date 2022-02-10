using System.Collections.Generic;

namespace FullStack_Task.Models.OtherModels
{
    public class Country
    {
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public string Iso2 { get; set; }
        public ICollection<State> States { get; set; }
        public string CommonName { get; set; }
        public string OfficialName { get; set; }
        public HashSet<string> Capital { get; protected set; }
        public string Region { get; set; }
        public long Population { get; set; }
        public string PostalCodeFormat { get; set; }
        public string PostalCodeRegex { get; set; }
        public Country()
        {
            this.Capital = new HashSet<string>();
        }
    }

    public class State
    {
        public string Name { get; set; }
        public string State_code { get; set; }
    }
}
