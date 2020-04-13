using SalesTaxRate.TaxRateRepository;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace SalesTaxRate.TaxRateService
{
    public class NCTaxRateService : ITaxRateService
    {
        private ITaxRateRepository _taxRateRepository;

        public NCTaxRateService(ITaxRateRepository taxRateRepository)
        {
            _taxRateRepository = taxRateRepository;
        }

        public async Task<double> GetNCTaxRateByCity(string city)
        {
            try
            {
                if (int.TryParse(city, out int total))
                    throw new HttpResponseException(HttpStatusCode.BadRequest);

                var taxRate = await _taxRateRepository.GetTaxRateByCityAsync(city);
                if (taxRate == 0.000)
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                
                return taxRate;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}