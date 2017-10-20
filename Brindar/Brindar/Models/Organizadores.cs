using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Organizadores
    {
        public int IdOrganizador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}