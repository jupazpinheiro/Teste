using CalculateVatAPI.Entities;

namespace CalculateVatAPI.Services
{
    public class VatService : IVatService
    {
        public IEnumerable<Vat> GetVats()
        {
            return new List<Vat>()
            {
                new Vat()
                {
                    Id = 1,
                    Rates = new List<VatRate>()
                    {
                        new VatRate()
                        {
                            Id = 1,
                            Value = 0.055m,
                            Text = "5.5%"
                        },
                        new VatRate()
                        {
                            Id = 2,
                            Value = 0.200m,
                            Text = "20%"
                        },
                        new VatRate()
                        {
                            Id = 3,
                            Value = 0.100m,
                            Text = "10%"
                        },
                    }
                },
                new Vat()
                {
                    Id = 2,
                    Rates = new List<VatRate>()
                    {
                        new VatRate()
                        {
                            Id = 4,
                            Value = 0.050m,
                            Text = "5%"
                        },
                        new VatRate()
                        {
                            Id = 2,
                            Value = 0.200m,
                            Text = "20%"
                        }
                    }
                },
                new Vat()
                {
                    Id = 3,
                    Rates = new List<VatRate>()
                    {
                        new VatRate()
                        {
                            Id = 5,
                            Value = 0.060m,
                            Text = "6%"
                        },
                        new VatRate()
                        {
                            Id = 6,
                            Value = 0.130m,
                            Text = "13%"
                        },
                        new VatRate()
                        {
                            Id = 7,
                            Value = 0.230m,
                            Text = "23%"
                        },
                    }
                },
                new Vat()
                {
                    Id = 4,
                    Rates = new List<VatRate>()
                    {
                        new VatRate()
                        {
                            Id = 8,
                            Value = 0.210m,
                            Text = "21%"
                        },
                        new VatRate()
                        {
                            Id = 3,
                            Value = 0.100m,
                            Text = "10%"
                        }
                    }
                }
            };
        }
    }
}
