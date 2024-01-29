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
                    {
                        Country = "Mexico",
                        CountryCode = "MEX",
                        Currency = "MXN",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 16.78m,
                        AcquiredDate = DateTime.Parse("2023-07-24T05:00:00.000Z")
                    },
                   new ExchangeRate
                    {
                        Country = "Mexico",
                        CountryCode = "MEX",
                        Currency = "MXN",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 15.78m,
                        AcquiredDate = DateTime.Parse("2023-06-24" )
                    },
                   new ExchangeRate
                    {
                        Country = "India",
                        CountryCode = "IND",
                        Currency = "RS",
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
                        Country = "Philippines",
                        CountryCode = "PHL",
                        Currency = "PHP",
                        PaymentMethod = "debit",
                        DeliveryMethod = "cash",
                        Rate = 16.83m,
                        AcquiredDate = DateTime.Parse("2023-07-24")
                    },
                    new ExchangeRate
                    {
                        Country = "Mexico",
                        CountryCode = "MEX",
                        Currency = "MXN",
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
