using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Servicios
    {
        public int IdServicio { get; set; }
        public int Proveedor { get; set; }
        public int Categoria { get; set; }
        public double Precio { get; set; }
    }
}