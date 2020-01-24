using AutoMapper;
using Permisos.Core.Domain.Entities;
using Permisos.Core.Interfaces;
using Permisos.Infrastructure.Data.Entities;
using Permisos.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Permisos.Core.Services
{

    public class TipoPermisoService : ITipoPermisoService
    {
        private readonly ITipoPermisoRepository _tipoPermisoRepository;
        private readonly IMapper _mapper;

        public TipoPermisoService(ITipoPermisoRepository tipoPermisoRepository, IMapper mapper)
        {
            _tipoPermisoRepository = tipoPermisoRepository;
            _mapper = mapper;
        }

        async Task<TipoPermisoApp> ITipoPermisoService.Get(int tipoPermisoId)
        {
            return _mapper.Map<TipoPermisoApp>(await _tipoPermisoRepository.Get(tipoPermisoId));
        }

        async Task<IEnumerable<TipoPermisoApp>> ITipoPermisoService.List()
        {
            return _mapper.Map<IEnumerable<TipoPermisoApp>>(await _tipoPermisoRepository.List());
        }
    }
}
