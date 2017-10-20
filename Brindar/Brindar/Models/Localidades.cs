using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public class Localidades
    {
        public int IdLocalidad { get; set; }
        public string Descripcion { get; set; }
        public int IdProvincia { get; set; }
    }
}