using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Permisos.Infrastructure.Data;
using Permisos.Infrastructure.Data.Entities;
using Permisos.Infrastructure.Interfaces;

namespace Permisos.Infrastructure.Repositories
{
    public class PermisoRepository : IPermisoRepository
    {
        public readonly ApplicationDbContext _context;

        public PermisoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<bool> IPermisoRepository.Add(Permiso permiso)
        {
            try
            {
                await _context.Permiso.AddAsync(permiso);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        async Task<bool> IPermisoRepository.Delete(int permisoId)
        {
            try
            {
                var permiso = await _context.Permiso.FindAsync(permisoId);
                _context.Permiso.Remove(permiso);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        async Task<Permiso> IPermisoRepository.Get(int permisoId)
        {
            try
            {
                return await _context.Permiso.FindAsync(permisoId);
            }
            catch
            {
                return new Permiso();
            }
        }

        async Task<IEnumerable<Permiso>> IPermisoRepository.List()
        {
            return await _context.Permiso.ToListAsync();
        }
    }
}
