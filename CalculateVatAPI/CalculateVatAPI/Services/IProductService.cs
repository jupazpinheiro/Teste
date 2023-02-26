using CalculateVatAPI.Entities;
using CalculateVatAPI.Models;

namespace CalculateVatAPI.Services
{
    public interface IProductService
    {
        Product CalculateProductPrices(CalculateProductPricesModel model);
    }
}