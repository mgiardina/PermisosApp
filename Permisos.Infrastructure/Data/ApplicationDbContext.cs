using Microsoft.EntityFrameworkCore;
using Permisos.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permisos.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }
    }
}
