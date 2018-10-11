using System;
using System.Collections.Generic;

namespace MenuHorizontal.Models
{
    public partial class Cuenta
    {
        public int IdCuenta { get; set; }
        public string IdUsuario { get; set; }
        public int NumeroCuenta { get; set; }
        public int IdTipoCuenta { get; set; }
        public double Saldo { get; set; }
        public double Disponible { get; set; }

        public Cuenta IdCuentaNavigation { get; set; }
        public Cuenta InverseIdCuentaNavigation { get; set; }
    }
}
