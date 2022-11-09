using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Infra.Config
{
    public static class InfraConfigExtensions
    {
        public static void AddInfraConfiguration(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration.GetConnectionString("EldExchange");
            services.AddDbContext<EldDbContext>(context => context.UseSqlServer(connectionString));
        }
    }
}
