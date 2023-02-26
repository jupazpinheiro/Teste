using CalculateVatAPI.Entities;

namespace CalculateVatAPI.Services
{
    public class CountryService : ICountryService
    {
        private readonly IVatService _vatService;
        public CountryService(IVatService vatService)
        {
            _vatService = vatService;
        }

        public List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country() { Id = 1, Name = "France" },
                new Country() { Id = 2, Name = "United Kingdom" },
                new Country() { Id = 3, Name = "Portugal" },
                new Country() { Id = 4, Name = "Spain" },
            };
        }

        public Country GetCountryWithVat(int countryId)
        {
            var vat = _vatService.GetVats().Single(x => x.Id == countryId);

            var country = this.GetCountryById(countryId);
            country.VatId = vat.Id;
            country.Vat = vat;

            return country;
        }

        private Country GetCountryById(int id)
        {
            var country = this.GetCountries()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (country == null)
            {
                throw new KeyNotFoundException($"{nameof(Country)} with id {id} does not exist.");
            }

            return country;
        }
    }
}
