using System;
using System.Collections.Generic;

namespace MenuHorizontal.Models
{
    public partial class MovimientoPres
    {
        public int IdMovimientoPrestamo { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime Fecha { get; set; }
        public int NumDocumento { get; set; }
        public double Cuota { get; set; }
        public double Capital { get; set; }
        public double Total { get; set; }

        public MovimientoPres IdMovimientoPrestamoNavigation { get; set; }
        public MovimientoPres InverseIdMovimientoPrestamoNavigation { get; set; }
    }
}
