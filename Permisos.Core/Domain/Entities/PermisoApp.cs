using System;

namespace Permisos.Core.Domain.Entities
{
    public class PermisoApp
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public int TipoPermisoId { get; set; }
        public DateTime FechaPermiso { get; set; }
        public string TipoPermiso { get; set; }
    }
}
