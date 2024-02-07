using DoctorLoader.Application.Contracts;
using DoctorLoader.Application.Contracts.Interfaces.Services;
using DoctorLoader.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DoctorLoader.Application.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => 
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ILoaderService, LoaderService>()
                    .AddScoped<IServiceManager, ServiceManager>();
        }
    }
}
