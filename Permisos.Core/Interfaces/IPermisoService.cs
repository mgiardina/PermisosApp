using Permisos.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Permisos.Core.Interfaces
{
    public interface IPermisoService
    {
        Task<bool> Add(PermisoApp permiso);
        Task<PermisoApp> Get(int permisoId);
        Task<bool> Delete(int permisoId);
        Task<IEnumerable<PermisoApp>> List();
    }
}
