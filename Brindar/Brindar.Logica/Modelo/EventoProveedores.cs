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
    
    public partial class EventoProveedores
    {
        public int Evento { get; set; }
        public int Proveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Eventos Eventos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
