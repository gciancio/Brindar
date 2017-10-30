using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface IServiciosServicio
    {
        //Registrar un servicio
        void RegistrarServicio(Servicios s);
        //Editar un servicio
        void EditarServicio(int IdServicio, Servicios s);
        //Borrar un servicio
        void BorrarServicio(int IdServicio);
        //Trae servicio por id
        Servicios BuscarServicioPorId(int? id);
        //Trae lista de servicios
		List<Servicios> TraerServicios();
		//Traer lista de servicios por categoría
		List<Servicios> TraerServiciosPorCategoria(int IdCategoria);
		//Traer servicios por proveedor
        List<Servicios> TraerServiciosPorProveedor(int IdProveedor);
    }
}
