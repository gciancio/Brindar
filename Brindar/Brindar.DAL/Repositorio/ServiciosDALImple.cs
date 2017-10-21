using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class ServiciosDALImple : IServiciosServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registrar un servicio
        public void RegistrarServicio(Servicios s)
        {
            ctx.Servicios.Add(s);
            ctx.SaveChanges();
        }

        //Editar un servicio
        public void EditarServicio(int IdServicio, Servicios s)
        {
            var ServEdit = ctx.Servicios.Find(IdServicio);
            ServEdit.Categoria = s.Categoria;
            ServEdit.Precio = s.Precio;
            ctx.SaveChanges();
        }

        //Borrar un servicio
        public void BorrarServicio(int IdServicio)
        {
            var serv = ctx.Servicios.Find(IdServicio);
            ctx.Servicios.Remove(serv);
            ctx.SaveChanges();
        }

        //Trae lista de servicios
        public List<Servicios> TraerServicios()
        {
            List<Servicios> servicios = ctx.Servicios.ToList();
            return servicios;
        }

        //Traer lista de servicios por categoría
        public List<Servicios> TraerServiciosPorCategoria(int IdCategoria)
        {
            List<Servicios> ServiciosPorCategoria = ctx.Servicios.Where(s => s.Categoria == IdCategoria).ToList();
            return ServiciosPorCategoria;
        }

        //Traer servicios por proveedor
        public List<Servicios> TraerServiciosPorProveedor(int IdProveedor)
        {
            List<Servicios> ServiciosPorProveedor = ctx.Servicios.Where(s => s.Proveedor == IdProveedor).ToList();
            return ServiciosPorProveedor;
        }
    }
}
