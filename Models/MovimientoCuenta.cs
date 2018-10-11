using System;
using System.Collections.Generic;

namespace MenuHorizontal.Models
{
    public partial class MovimientoCuenta
    {
        public int IdMovimientoCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public int NumDocumento { get; set; }
        public double Valor { get; set; }
        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; }

        public MovimientoCuenta IdMovimientoCuentaNavigation { get; set; }
        public MovimientoCuenta InverseIdMovimientoCuentaNavigation { get; set; }
    }
}
