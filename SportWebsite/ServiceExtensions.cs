using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Contracts;
using Service.Contracts;
using Service.ServiceModels;

namespace SportWebsite
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext, ApplicationDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b=> b.MigrationsAssembly("DAL")));

        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
     
    }

}
