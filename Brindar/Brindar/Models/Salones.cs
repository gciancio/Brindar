using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Salones
    {
        public int IdSalon { get; set; }
        public int Proveedor { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Telefono { get; set; }
        public int Provincia { get; set; }
        public int Localidad { get; set; }
        public string Direccion { get; set; }
        public string URLFacebook { get; set; }
        public string URLPagina { get; set; }
    }
}