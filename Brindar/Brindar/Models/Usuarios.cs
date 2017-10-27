using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Provincia { get; set; }
        public Nullable<int> Localidad { get; set; }
        public string Direccion { get; set; }
        public string URLFacebook { get; set; }
        public string URLPagina { get; set; }
        public Nullable<bool> OrgPremium { get; set; }
        public Nullable<bool> ProPremium { get; set; }
    }
}