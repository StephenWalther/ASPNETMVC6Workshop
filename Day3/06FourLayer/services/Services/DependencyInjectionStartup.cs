using Infrastructure.Services;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Services.Services;
using System;


namespace Services
{
    public static class DependencyInjectionStartup
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration config = null)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IGenericRepository, GenericRepository>();

            return services;
        }
    }
}