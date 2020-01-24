using Permisos.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Permisos.Infrastructure.Interfaces
{
    public interface ITipoPermisoRepository
    {
        Task<TipoPermiso> Get(int tipoPermisoId);
        Task<IEnumerable<TipoPermiso>> List();
    }
}
