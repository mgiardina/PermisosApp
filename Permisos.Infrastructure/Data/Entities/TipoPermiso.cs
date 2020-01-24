using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Permisos.Infrastructure.Data.Entities
{
    public class TipoPermiso
    {
        public TipoPermiso()
        {
            Permisos = new HashSet<Permiso>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Descripcion { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}
