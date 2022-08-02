using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Facturacions = new HashSet<Facturacion>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? DocumentoIdentidad { get; set; }
        public string? Email { get; set; }
        public int TipoEmpleadoId { get; set; }
        public int? Porcentaje { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual TipoEmpledo TipoEmpleado { get; set; } = null!;
        public virtual ICollection<Facturacion> Facturacions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
