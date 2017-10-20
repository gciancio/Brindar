using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public int Localidad { get; set; }
        public string Direccion { get; set; }
        public string URLFacebook { get; set; }
        public string URLPagina { get; set; }
        public Nullable<bool> Premium { get; set; }
    }
}