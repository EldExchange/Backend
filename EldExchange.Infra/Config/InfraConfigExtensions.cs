using EldExchange.Domain.Interfaces;
using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EldExchange.Infra.Config
{
    public static class InfraConfigExtensions
    {
        public static void AddInfraConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("CONNECTIONSTRING_ELDEXCHANGE")?? configuration.GetConnectionString("EldExchange");
            services.AddDbContext<EldDbContext>(context => context.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void CheckAgengy(this IAgencyService service) { }
    }
}
