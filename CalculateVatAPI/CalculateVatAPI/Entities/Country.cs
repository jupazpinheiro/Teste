namespace CalculateVatAPI.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int VatId { get; set; }
        public Vat Vat { get; set; }
    }
}
