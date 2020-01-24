using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Permisos.Infrastructure.Data.Entities
{
    public class Permiso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string NombreEmpleado { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string ApellidosEmpleado { get; set; }
        [Required]
        public int TipoPermisoId { get; set; }
        [Required]
        public DateTime FechaPermiso { get; set; }

        public virtual TipoPermiso TipoPermiso { get; set; }
    }
}
