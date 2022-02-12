using FullStack_Task.HorizontalClasses.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FullStack_Task.Controllers.API
{
    [Route("api/Geography")]
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
            return Ok(await this._geography.GetCountries());
        }

        [HttpGet("states/{countryName}")]
        public async Task<IActionResult> GetStates(string countryName)
        {
            if (countryName == null)
                return BadRequest();
            return Ok(await this._geography.GetStatesOfCountry(countryName));
        }
    }
}
