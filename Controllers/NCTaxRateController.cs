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

        /// <summary>
        /// This end point get the total amount of tax by the amount and the city 
        /// </summary>
        /// <param name="order"></param>
        /// <returns>the total amount of tax</returns>
        // GET: /api/NCTaxRate
        [HttpGet]
        [Route("api/NCTaxRate")]
        public async Task<decimal> Get(Order order)
        {
            return await _taxRateService.GetNCTaxRateByCity(order);
        }
    }
}
