using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ExchangeRate
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public string CountryCode { get; set; }
        public decimal AdjustedRate { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
        public decimal Rate { get; set; }
        public DateTime AcquiredDate { get; set; }
    }
}
