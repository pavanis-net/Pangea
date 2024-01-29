using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.ExchangeRatesRepository
{
    public class ExchangeRepository:IExchangeRepository
    {
        public List<PartnerExchangeRate> GetPartnerExchangeRatesByCountry()
        {
            List<PartnerExchangeRate> partnerRates = new List<PartnerExchangeRate>
        {
            new PartnerExchangeRate
            {
                PartnerName = "Partner1",
                ExchangeRates = new List<ExchangeRate>
                {
                    new ExchangeRate
                    {CurrencyCode = "MXN", PaymentMethod = "debit", DeliveryMethod = "cash", Rate = 16.78m, AcquiredDate = DateTime.Parse("2023-07-24")},
                   new ExchangeRate
                    {CurrencyCode = "MXN", PaymentMethod = "debit", DeliveryMethod = "cash", Rate = 15.78m, AcquiredDate = DateTime.Parse("2023-06-24")},
                   new ExchangeRate
                    {             
                        CurrencyCode = "INR",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 15.78m,
                        AcquiredDate = DateTime.Parse("2023-06-24" )
                    },
                }
            },
            new PartnerExchangeRate
            {
                PartnerName = "Partner2",
                ExchangeRates = new List<ExchangeRate>
                {
                    new ExchangeRate
                    {
                       
                        CurrencyCode = "PHP",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 16.83m,
                        AcquiredDate = DateTime.Parse("2023-07-24")
                    },
                    new ExchangeRate
                    {
                        CurrencyCode = "MXN",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 15.78m,
                        AcquiredDate = DateTime.Parse("2023-06-24" )
                    }

                }
            }
        };
          return  partnerRates;

        }
    }
}
