//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Brindar.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TiposEvento
    {
        public TiposEvento()
        {
            this.Eventos = new HashSet<Eventos>();
        }
    
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}