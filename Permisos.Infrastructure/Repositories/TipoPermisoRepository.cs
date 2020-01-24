using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Permisos.Infrastructure.Data;
using Permisos.Infrastructure.Data.Entities;
using Permisos.Infrastructure.Interfaces;

namespace Permisos.Infrastructure.Repositories
{
    public class TipoPermisoRepository : ITipoPermisoRepository
    {
        public readonly ApplicationDbContext _context;

        public TipoPermisoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<TipoPermiso>> ITipoPermisoRepository.List()
        {
            return await _context.TipoPermiso.ToListAsync();
        }

        async Task<TipoPermiso> ITipoPermisoRepository.Get(int tipoPermisoId)
        {
            try
            {
                return await _context.TipoPermiso.FindAsync(tipoPermisoId);
            }
            catch
            {
                return new TipoPermiso();
            }
        }
    }
}
