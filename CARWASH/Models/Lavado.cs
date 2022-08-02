using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class Lavado
    {
        public Lavado()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
