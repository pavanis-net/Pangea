using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ExchangeRatesService
{
    public class ExchangeRateResponse
    {
        
        public string CurrencyCode { get; set; }
        public string CountryCode { get; set; }
        public decimal PangeaRate { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
    }
}
