namespace CalculateVatAPI.Models
{
    public class CalculateProductPricesModel
    {
        public int VatRateId { get; set; }
        public decimal VatRate { get; set; }
        public PriceType PriceType { get; set; }
        public decimal Value { get; set; }
    }
}
