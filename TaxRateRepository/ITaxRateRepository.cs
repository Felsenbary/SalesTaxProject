using System.Threading.Tasks;

namespace SalesTaxRate.TaxRateRepository
{
    public interface ITaxRateRepository
    {
        Task<decimal> GetTaxRateByCityAsync(string city);
    }
}
