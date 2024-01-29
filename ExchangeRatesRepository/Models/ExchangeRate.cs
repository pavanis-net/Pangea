using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class ExchangeRate
    {
        
        public string CurrencyCode { get; set; }
        public decimal AdjustedRate { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
        public decimal Rate { get; set; }
        public DateTime AcquiredDate { get; set; }
    }
}
