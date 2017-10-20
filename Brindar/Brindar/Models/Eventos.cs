using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Eventos
    {
        public int IdEvento { get; set; }
        public int TipoEvento { get; set; }
        public int Organizador { get; set; }
        public Nullable<int> Salon { get; set; }
        public Nullable<int> Servicio { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Presupuesto { get; set; }
    }
}