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
    
    public partial class Suscripciones
    {
        public int IdSuscripcion { get; set; }
        public int Proveedor { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public int CantMeses { get; set; }
        public double PrecioMensual { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
    }
}
