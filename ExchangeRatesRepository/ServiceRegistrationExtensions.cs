using Microsoft.Extensions.DependencyInjection;
using Repository.ExchangeRatesRepository;

namespace Repository
{
    public static class ServiceRegistrationExtensions
    {
        public static void ConfigureExchangeRateRepository(this IServiceCollection services)
        {
            services.AddScoped<IExchangeRepository, ExchangeRepository>();
        }
    }
}
