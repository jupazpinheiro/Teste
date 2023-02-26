namespace CalculateVatAPI.Entities
{
    public class Vat
    {
        public int Id { get; set; }
        public List<VatRate> Rates { get; set; }
    }
}
