using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Suscripciones
    {
        public int IdSuscripcion { get; set; }
        public int Proveedor { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public int CantMeses { get; set; }
        public double PrecioMensual { get; set; }
    }
}