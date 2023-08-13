using Microsoft.EntityFrameworkCore;
using Seguridad.Data;
using Seguridad.Interfaces;
using Seguridad.Services;

namespace Seguridad.Extensions
{
    public static class ApplicationServiceExtensions
    {
        //Metodo de configuracion para el sistemas de pertenencia
        public static IServiceCollection 
            AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));
            return services;
        }

    }
}
