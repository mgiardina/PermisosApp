using AutoMapper;
using Permisos.Core.Domain.Entities;
using Permisos.Core.Interfaces;
using Permisos.Infrastructure.Data.Entities;
using Permisos.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Permisos.Core.Services
{

    public class PermisoService : IPermisoService
    {
        private readonly IPermisoRepository _permisoRepository;
        private readonly ITipoPermisoRepository _tipoPermisoRepository;
        private readonly IMapper _mapper;

        public PermisoService(IPermisoRepository permisoRepository, ITipoPermisoRepository tipoPermisoRepository, IMapper mapper)
        {
            _permisoRepository = permisoRepository;
            _tipoPermisoRepository = tipoPermisoRepository;
            _mapper = mapper;
        }

        async Task<bool> IPermisoService.Add(PermisoApp permiso)
        {
            permiso.FechaPermiso = DateTime.Now;
            return await _permisoRepository.Add(_mapper.Map<Permiso>(permiso));
        }

        async Task<bool> IPermisoService.Delete(int permisoId)
        {
            return await _permisoRepository.Delete(permisoId);
        }

        async Task<PermisoApp> IPermisoService.Get(int permisoId)
        {
            return _mapper.Map<PermisoApp>(await _permisoRepository.Get(permisoId));
        }

        async Task<IEnumerable<PermisoApp>> IPermisoService.List()
        {
            var permisosAppList = new List<PermisoApp>();
            foreach (var permiso in await _permisoRepository.List())
            {
                var permisoApp = _mapper.Map<PermisoApp>(permiso);
                permisoApp.TipoPermiso = _tipoPermisoRepository.Get(permiso.TipoPermisoId).Result.Descripcion;
                permisosAppList.Add(permisoApp);
            }
            return permisosAppList;
        }
    }
}
