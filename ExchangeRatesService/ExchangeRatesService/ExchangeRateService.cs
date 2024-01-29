using System.Runtime.InteropServices;
using Repository.ExchangeRatesRepository;
using Repository.Models;

namespace Service.ExchangeRatesService
{
    public class ExchangeRateService:IExchangeRateService
    {
        private readonly IExchangeRepository _exchangeRepository;
        public ExchangeRateService(IExchangeRepository exchangeRepository) 
        {
            _exchangeRepository = exchangeRepository;
        }
        public List<ExchangeRateResponse> GetExchangeRatesByCountry(string countryCode)
        {
            var partnerExchangeRates = _exchangeRepository.GetPartnerExchangeRatesByCountry();
            var pangeaxchangeRates = new List<ExchangeRateResponse>();

            // Iterate through partner data and filter by countryCode
            foreach (var partnerExchangeRate in partnerExchangeRates)
            {
                var filteredRates = partnerExchangeRate.ExchangeRates
                    .Where(rate => GetCountryCodeByCurrencyCode( rate.CurrencyCode.ToUpper()) == countryCode.ToUpper() )
                    .OrderByDescending(rate => rate.AcquiredDate)
                    .FirstOrDefault();

                if (filteredRates != null)
                {
                    // Calculate the adjusted rate and round it to two decimal places
                    var adjustedRate = Math.Round(filteredRates.Rate + GetFlatRateByCountryCode(countryCode), 2);
                    pangeaxchangeRates.Add(new ExchangeRateResponse
                    {

                        CountryCode = GetCountryCodeByCurrencyCode( filteredRates.CurrencyCode),
                        CurrencyCode = filteredRates.CurrencyCode,
                        PangeaRate = adjustedRate,
                        PaymentMethod = filteredRates.PaymentMethod,
                        DeliveryMethod = filteredRates.DeliveryMethod
                    });
                }
            }

            return pangeaxchangeRates;
        }

        private decimal GetFlatRateByCountryCode(string countryCode)
        {
             switch (currencyCode.ToUpper())
            {
                case "MEX":
                    return 0.024m;
                case "PHL":
                    return 2.437m;
                case "GTM":
                    return 0.056m;
                case "IND":
                    return 3.213m;
              
                default:
                    return 0.0m; 
            }
        }

        private string GetCountryCodeByCurrencyCode(string currencyCode)
        {
        
            switch (currencyCode)
            {
                case "MXN":
                    return "MEX";
                case "PHP":
                    return "PHL";
                case "GTM":
                    return "GTQ";
                case "IND":
                    return "INR";
               
                default:
                    return "null"; 
            }
        }

    }
}
