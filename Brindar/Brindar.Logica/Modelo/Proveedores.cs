//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Brindar.Logica.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedores
    {
        public Proveedores()
        {
            this.Salones = new HashSet<Salones>();
            this.Servicios = new HashSet<Servicios>();
            this.Suscripciones = new HashSet<Suscripciones>();
            this.Eventos = new HashSet<Eventos>();
        }
    
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
    
        public virtual Localidades Localidades { get; set; }
        public virtual ICollection<Salones> Salones { get; set; }
        public virtual ICollection<Servicios> Servicios { get; set; }
        public virtual ICollection<Suscripciones> Suscripciones { get; set; }
        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}