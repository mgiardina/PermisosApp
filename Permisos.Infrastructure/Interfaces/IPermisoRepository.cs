using Permisos.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Permisos.Infrastructure.Interfaces
{
    public interface IPermisoRepository
    {
        Task<bool> Add(Permiso permiso);
        Task<Permiso> Get(int permisoId);
        Task<bool> Delete(int permisoId);
        Task<IEnumerable<Permiso>> List();
    }
}
