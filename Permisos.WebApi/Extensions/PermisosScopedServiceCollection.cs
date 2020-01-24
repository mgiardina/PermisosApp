using Microsoft.Extensions.DependencyInjection;
using Permisos.Core.Interfaces;
using Permisos.Core.Services;
using Permisos.Infrastructure.Interfaces;
using Permisos.Infrastructure.Repositories;

namespace Permisos.WebApi.Extensions
{
    public static class PermisosScopedServiceCollection
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IPermisoRepository, PermisoRepository>();
            services.AddScoped<ITipoPermisoRepository, TipoPermisoRepository>();
            services.AddScoped<IPermisoService, PermisoService>();
            services.AddScoped<ITipoPermisoService, TipoPermisoService>();

            return services;
        }
    }
}
