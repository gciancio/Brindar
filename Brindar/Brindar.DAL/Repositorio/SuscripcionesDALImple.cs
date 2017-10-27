using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;
using Brindar.Logica.Servicio;

namespace Brindar.DAL.Repositorio
{
    public class SuscripcionesDALImple : ISuscripcionesServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registrar una suscripcion
        public void RegistrarSuscripcion(Suscripciones s)
        {
            ctx.Suscripciones.Add(s);
            ctx.SaveChanges();
        }

        //Traer suscripciones por proveedor
        public List<Suscripciones> TraerSuscripcionesPorProveedor(int IdProveedor)
        {
            List<Suscripciones> SuscripcionesPorProveedor = ctx.Suscripciones.Where(s => s.Usuario == IdProveedor).ToList();
            return SuscripcionesPorProveedor;
        }
    }
}
