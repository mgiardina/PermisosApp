using AutoMapper;
using Permisos.Core.Domain.Entities;
using Permisos.Infrastructure.Data.Entities;

namespace Permisos.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TipoPermisoApp, TipoPermiso>();
            CreateMap<TipoPermiso, TipoPermisoApp>();
            CreateMap<PermisoApp, Permiso>();
            CreateMap<Permiso, PermisoApp>();
        }
    }
}
