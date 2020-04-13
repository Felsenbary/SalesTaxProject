using System.Threading.Tasks;

namespace SalesTaxRate.TaxRateRepository
{
    public interface ITaxRateRepository
    {
        Task<double> GetTaxRateByCityAsync(string city);
    }
}
