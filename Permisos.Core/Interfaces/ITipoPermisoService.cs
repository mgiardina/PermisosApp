using Permisos.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Permisos.Core.Interfaces
{
    public interface ITipoPermisoService
    {
        Task<TipoPermisoApp> Get(int tipoPermisoId);
        Task<IEnumerable<TipoPermisoApp>> List();
    }
}
