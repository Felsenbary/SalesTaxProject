using System.Threading.Tasks;

namespace SalesTaxRate.TaxRateService
{
    public interface ITaxRateService
    {
        Task<double> GetNCTaxRateByCity(string city);
    }
}
