using CalculateVatAPI.Entities;

namespace CalculateVatAPI.Services
{
    public interface ICountryService
    {
        List<Country> GetCountries();
        Country GetCountryWithVat(int countryId);
    }
}
