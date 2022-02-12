using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullStack_Task.HorizontalClasses.Interfaces
{
    public interface IGeography
    {
        Task<ICollection<Country>> GetCountries();
        Task<ICollection<State>> GetStatesOfCountry(string countryName);
    }
}