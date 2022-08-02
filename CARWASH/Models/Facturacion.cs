using System;
using System.Collections.Generic;

namespace CARWASH.Models
{
    public partial class Facturacion
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public int ClienteId { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdEmplado { get; set; }
        public int VehiculoId { get; set; }
        public int LavadoId { get; set; }
        public double? Total { get; set; }
        public int EstatusFacturacionId { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual EstadoFacturacion EstatusFacturacion { get; set; } = null!;
        public virtual Empleado IdEmpladoNavigation { get; set; } = null!;
        public virtual Lavado Lavado { get; set; } = null!;
        public virtual Vehiculo Vehiculo { get; set; } = null!;
    }
}
