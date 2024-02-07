using DoctorLoader.Application.Contracts;
using DoctorLoader.Application.Contracts.Interfaces.Services;
using DoctorLoader.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorLoader.Application.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => 
                cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionExtensions).Assembly));

            services.AddScoped<ILoaderService, LoaderService>()
                    .AddScoped<IServiceManager, ServiceManager>();
        }
    }
}
