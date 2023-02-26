namespace CalculateVatAPI.Entities
{
    public class Product
    {
        public Product(int id, decimal priceWithoutVat, decimal vat, decimal priceWithVat, int vatRateId, VatRate vatRate)
        {
            Id = id;
            PriceWithoutVat = priceWithoutVat;
            Vat = vat;
            PriceWithVat = priceWithVat;
            VatRateId = vatRateId;
            VatRate = vatRate;
        }

        public int Id { get; set; }
        public decimal PriceWithoutVat { get; set; }
        public decimal Vat { get; set; }
        public decimal PriceWithVat { get; set; }

        public int VatRateId { get; set; }
        public VatRate VatRate { get; set; }
    }
}
