using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MonApp.Domaine.Interfaces;
using MonApp.Infrastructure.Data;
using MonApp.Infrastructure.Repositories;

namespace MonApp.Infrastructure
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlite("Data Source=recette.db"));
            //options => options.UseSqlite(config.GetConnectionString("DefaultConnection") ?? "Data Source=recette.db"));

            services.AddScoped<IRecetteRepository, RecetteRepository>();

            //services.AddScoped<IArticlesRepository, ArticlesRepository>();
            return services;
        }


    }
}
