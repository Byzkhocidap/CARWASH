using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class VehiculoLavado
    {
        public int VehiculoId { get; set; }
        public int LavadoId { get; set; }
        public double Precio { get; set; }

        public virtual Lavado Lavado { get; set; } = null!;
        public virtual Vehiculo Vehiculo { get; set; } = null!;
    }
}
