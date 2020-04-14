using SalesTaxRate.Models;
using System.Threading.Tasks;

namespace SalesTaxRate.TaxRateService
{
    public interface ITaxRateService
    {
        Task<decimal> GetNCTaxRateByCity(Order order);
    }
}
