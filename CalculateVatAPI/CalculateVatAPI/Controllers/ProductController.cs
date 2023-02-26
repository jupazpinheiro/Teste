using CalculateVatAPI.Models;
using CalculateVatAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculateVatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("Calculate")]
        public IActionResult CalculateProductPrices([FromBody] CalculateProductPricesModel model)
        {
            return Ok(_productService.CalculateProductPrices(model));
        }
    }
}
