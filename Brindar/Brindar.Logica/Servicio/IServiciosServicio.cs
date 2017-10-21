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
        public void RegistrarServicio(Servicios s);
        //Editar un servicio
        public void EditarServicio(int IdServicio, Servicios s);
        //Borrar un servicio
        public void BorrarServicio(int IdServicio);
        //Trae lista de servicios
		public List<Servicios> TraerServicios();
		//Traer lista de servicios por categoría
		public List<Servicios> TraerServiciosPorCategoria(int IdCategoria);
		//Traer servicios por proveedor
        public List<Servicios> TraerServiciosPorProveedor(int IdProveedor);
    }
}
