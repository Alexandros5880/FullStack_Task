using FullStack_Task.HorizontalClasses.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FullStack_Task.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographyController : ControllerBase
    {
        private readonly IGeography _geography;

        public GeographyController(IGeography geography)
        {
            this._geography = geography;
        }

        [HttpGet("countries")]
        public async Task<IActionResult> GetStates()
        {
            return Ok(await this._geography.GetCountriesAndStates());
        }

        [HttpGet("states/{countryName}")]
        public async Task<IActionResult> GetStates(string countryName)
        {
            if (countryName == null)
                return BadRequest();
            var countries = await this._geography.GetCountriesAndStates();
            var states = this._geography.GetStatesOfCountry(countries, countryName);
            return Ok(states);
        }
    }
}
