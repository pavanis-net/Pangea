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
                    .Where(rate => rate.CountryCode.ToUpper() == countryCode.ToUpper() || rate.Country.ToUpper() == countryCode.ToUpper())
                    .OrderByDescending(rate => rate.AcquiredDate)
                    .FirstOrDefault();

                if (filteredRates != null)
                {
                    // Calculate the adjusted rate and round it to two decimal places
                    var adjustedRate = Math.Round(filteredRates.Rate + GetFlatRateByCountryCode(countryCode), 2);
                    pangeaxchangeRates.Add(new ExchangeRateResponse
                    {
                        Country = filteredRates.Country,
                        CurrencyCode = filteredRates.Currency,
                        CountryCode = filteredRates.CountryCode,
                        AdjustedRate = adjustedRate,
                        PaymentMethod = filteredRates.PaymentMethod,
                        DeliveryMethod = filteredRates.DeliveryMethod
                    });
                }
            }

            return pangeaxchangeRates;
        }

        private decimal GetFlatRateByCountryCode(string countryCode)
        {
            // Implement a method to return the flat rate based on the provided countryCode
            // You can use a dictionary or switch statement for this purpose
            switch (countryCode)
            {
                case "MEX":
                    return 0.024m;
                case "PHL":
                    return 2.437m;
                case "GTM":
                    return 0.056m;
                case "IND":
                    return 3.213m;
                // Add more country rates as needed
                default:
                    return 0.0m; // Default rate if the country code is not found
            }
        }

    }
}
