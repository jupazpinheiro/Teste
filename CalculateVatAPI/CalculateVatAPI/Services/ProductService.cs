using CalculateVatAPI.Entities;
using CalculateVatAPI.Models;

namespace CalculateVatAPI.Services
{
    public class ProductService : IProductService
    {
        public Product CalculateProductPrices(CalculateProductPricesModel model)
        {
            var vatRate = new VatRate(model.VatRateId, model.VatRate);

            if (model.PriceType == PriceType.WithoutVat)
            {
                var vat = model.Value * model.VatRate;
                return new Product(1, model.Value, vat, model.Value + vat, model.VatRateId, vatRate);
            }

            else if (model.PriceType == PriceType.JustVat)
            {
                var totalPrice = model.Value / model.VatRate;
                return new Product(1, totalPrice - model.Value, model.Value, totalPrice, model.VatRateId, vatRate);
            }

            else if (model.PriceType == PriceType.WithVat)
            {
                var vat = model.Value * model.VatRate;
                return new Product(1, model.Value - vat, vat, model.Value, model.VatRateId, vatRate);
            }

            else
            {
                throw new ArgumentOutOfRangeException($"{nameof(model.PriceType)} {model.PriceType} is invalid");
            }
        }
    }
}
