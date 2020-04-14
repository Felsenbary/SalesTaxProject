using SalesTaxRate.Models;
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

        public async Task<decimal> GetNCTaxRateByCity(Order order)
        {
            try
            {
                decimal TotalTax;

                if (order is null || order.Amount < 0.010m)
                    throw new HttpResponseException(HttpStatusCode.BadRequest);

                var taxRate = await _taxRateRepository.GetTaxRateByCityAsync(order.City);
                if (taxRate == 0m)
                    throw new HttpResponseException(HttpStatusCode.NotFound);

                TotalTax = Math.Round((order.Amount * taxRate), 2);
                return TotalTax;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}