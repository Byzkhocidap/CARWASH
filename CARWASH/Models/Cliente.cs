using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
