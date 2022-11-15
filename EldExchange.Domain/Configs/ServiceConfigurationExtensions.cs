using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EldExchange.Domain.Configs
{
    public static class ServiceConfigurationExtensions
    {
        public static void AddBusinesService(this IServiceCollection services)
        {
            services.AddScoped<IAgencyService, AgencyService>();
        }
    }
}
