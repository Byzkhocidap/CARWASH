using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public int TipoUsuarioId { get; set; }

        public virtual Empleado Empleado { get; set; } = null!;
        public virtual TipoUsuario TipoUsuario { get; set; } = null!;
    }
}
