using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface ISuscripcionesServicio
    {
        //Registrar una suscripcion
        void RegistrarSuscripcion(Suscripciones s);

        //Traer suscripciones por proveedor
        List<Suscripciones> TraerSuscripcionesPorProveedor(int IdProveedor);
    }
}
