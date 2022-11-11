using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
