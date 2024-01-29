using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ExchangeRatesService
{
    public class ExchangeRateResponse
    {
        public string Country { get; set; }
        public string CurrencyCode { get; set; }
        public string CountryCode { get; set; }
        public decimal AdjustedRate { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
    }
}
