using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Permisos.Core.Mapping;

namespace Permisos.WebApi.Extensions
{
    public static class PermisosMapperService
    {
        public static IServiceCollection AddMapperService(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
