using CalculateVatAPI.Entities;
using CalculateVatAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculateVatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Country>>> GetCountries()
        {
            return Ok(_countryService.GetCountries());
        }
    }
}
