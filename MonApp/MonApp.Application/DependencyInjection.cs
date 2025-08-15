using Microsoft.Extensions.DependencyInjection;
using MonApp.Application.Interfaces;
using MonApp.Application.Services;

namespace MonApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddScoped<IArticlesService, ArticlesService>();
            services.AddScoped<IRecetteService, RecetteService>();
            return services;
        }
            
    }
}
