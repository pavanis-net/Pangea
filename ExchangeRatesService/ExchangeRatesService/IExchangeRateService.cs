using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;


namespace Service.ExchangeRatesService
{
    public interface IExchangeRateService
    {
        List<ExchangeRateResponse> GetExchangeRatesByCountry(string countryCode);
    }
}
