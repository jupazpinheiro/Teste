using CalculateVatAPI.Entities;
using CalculateVatAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculateVatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public VatController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("{countryId}")]
        public IActionResult GetVatByCountryId([FromRoute] int countryId)
        {
            return Ok(_countryService.GetCountryWithVat(countryId).Vat);
        }
    }
}
