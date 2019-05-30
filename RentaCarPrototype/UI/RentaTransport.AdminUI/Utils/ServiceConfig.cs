using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.DAL.Repositories;

namespace RentaTransport.AdminUI.Utils
{
    public static class ServiceConfig
    {
        public static void Register(this IServiceCollection services)
        {
            RegisterServiceFacades(services);
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterValidators(services);
            RegisterMappers();
            //services.AddScoped<IdentityConfig>();
        }

        private static void RegisterServiceFacades(IServiceCollection services)
        {
            services.AddScoped<CityServiceFacade>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<CityService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
        }

        private static void RegisterValidators(IServiceCollection services)
        {
            services.AddScoped<CityValidator>();
        }

        private static void RegisterMappers()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MapperConfig>();
                cfg.AddProfile<DAL.DataContexts.MapperConfig>();
            });
        }
    }
}
