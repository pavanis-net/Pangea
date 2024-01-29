using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.ExchangeRatesService;

namespace ExchangeRatesAPI.Controllers
{
   
    [ApiController]
    [Route("api/exchange-rates")]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IExchangeRateService _exchangeRateService;

        public ExchangeRateController(IExchangeRateService exchangeRatesService)
        {
            _exchangeRateService = exchangeRatesService;
        }
        [HttpGet]
        public IActionResult GetExchangeRates([FromQuery] string country)
        {
            try
            {
                var exchangeRates = _exchangeRateService.GetExchangeRatesByCountry(country);

                if (exchangeRates.Any())
                {
                    return Ok(exchangeRates);
                }
                else
                {
                    return NotFound($"Exchange rates not found for country : {country}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
