using FullStack_Task.Models.OtherModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStack_Task.HorizontalClasses.Interfaces
{
    public interface IGeography
    {
        Task<ICollection<Country>> GetCountries();
        Task<ICollection<Country>> GetCountriesAndStates();
        ICollection<State> GetStatesOfCountry(ICollection<Country> countries, string countryName);
    }
}