using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class EstadoFacturacion
    {
        public EstadoFacturacion()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
