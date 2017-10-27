using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class EventoProveedores
    {
        public int Evento { get; set; }
        public int Proveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}