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
    
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
