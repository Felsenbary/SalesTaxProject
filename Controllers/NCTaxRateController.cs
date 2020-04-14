using SalesTaxRate.Models;
using SalesTaxRate.TaxRateService;
using System.Threading.Tasks;
using System.Web.Http;

namespace SalesTaxRate.Controllers
{
    public class NCTaxRateController : ApiController
    {
        private readonly ITaxRateService _taxRateService;

        public NCTaxRateController(ITaxRateService taxRateService)
        {
            _taxRateService = taxRateService;
        }

        // GET: /api/NCTaxRate/cary
        [HttpGet]
        [Route("api/NCTaxRate/{city}")]
        public async Task<decimal> Get(Order order)
        {
            return await _taxRateService.GetNCTaxRateByCity(order);
        }
    }
}
