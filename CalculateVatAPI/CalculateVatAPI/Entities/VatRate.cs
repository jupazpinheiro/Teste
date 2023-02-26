namespace CalculateVatAPI.Entities
{
    public class VatRate
    {
        public VatRate()
        {

        }

        public VatRate(int id, decimal value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; set; }
        public decimal Value { get; set; }
        public string Text { get; set; }

    }
}
