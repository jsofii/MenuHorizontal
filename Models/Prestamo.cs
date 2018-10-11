using System;
using System.Collections.Generic;

namespace MenuHorizontal.Models
{
    public partial class Prestamo
    {
        public int IdPrestamo { get; set; }
        public string IdUsuario { get; set; }
        public int? IdTipoPrestamo { get; set; }
        public double? Saldo { get; set; }
        public string Moneda { get; set; }
        public double? ValorDia { get; set; }

        public Prestamo IdPrestamoNavigation { get; set; }
        public Prestamo InverseIdPrestamoNavigation { get; set; }
    }
}
