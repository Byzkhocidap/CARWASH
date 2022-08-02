using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
