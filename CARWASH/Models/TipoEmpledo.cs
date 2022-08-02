using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class TipoEmpledo
    {
        public TipoEmpledo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
