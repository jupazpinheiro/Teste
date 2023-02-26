using CalculateVatAPI.Entities;

namespace CalculateVatAPI.Services
{
    public interface IVatService
    {
        IEnumerable<Vat> GetVats();
    }
}
