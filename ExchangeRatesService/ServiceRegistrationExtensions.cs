using Microsoft.Extensions.DependencyInjection;
using Service.ExchangeRatesService;

namespace Service
{
    public static class ServiceRegistrationExtensions
    {
        public static void ConfigureExchangeRateService(this IServiceCollection services)
        {
            services.AddScoped<IExchangeRateService, ExchangeRateService>();
        }
    }
}
