using DoctorLoader.Application.Contracts.Interfaces;
using DoctorLoader.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorLoader.Infrastructure.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddIntrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options 
                => options.UseSqlite(configuration.GetConnectionString("Sqlite")));

            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
        }
    }
}
