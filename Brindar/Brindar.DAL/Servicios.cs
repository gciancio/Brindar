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
    
    public partial class Servicios
    {
        public Servicios()
        {
            this.Eventos = new HashSet<Eventos>();
        }
    
        public int IdServicio { get; set; }
        public int Proveedor { get; set; }
        public int Categoria { get; set; }
        public double Precio { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        public virtual ICollection<Eventos> Eventos { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}