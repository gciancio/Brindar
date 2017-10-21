using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class SalonesDALImple : ISalonesServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registrar un salon
        public void RegistrarSalon(Salones s)
        {
            ctx.Salones.Add(s);
            ctx.SaveChanges();
        }

        //Editar un salon
        public void EditarSalon(int IdSalon, Salones s)
        {
            var SalonEdit = ctx.Salones.Find(IdSalon);
            SalonEdit.Nombre = s.Nombre;
            SalonEdit.Precio = s.Precio;
            SalonEdit.Telefono = s.Telefono;
            SalonEdit.Localidad = s.Localidad;
            SalonEdit.Direccion = s.Direccion;
            SalonEdit.URLFacebook = s.URLFacebook;
            SalonEdit.URLPagina = s.URLPagina;
            ctx.SaveChanges();
        }

        //Borrar un salon
        public void BorrarSalon(int IdSalon)
        {
            var sal = ctx.Salones.Find(IdSalon);
            ctx.Salones.Remove(sal);
            ctx.SaveChanges();
        }

        //Trae lista de todos los salones disponibles
        public List<Salones> TraerSalones()
        {
            List<Salones> salones = ctx.Salones.ToList();
            return salones;
        }

        //Trae lista de salones por id de localidad
        public List<Salones> TraerSalonesPorLocalidad(int IdLocalidad)
        {
            List<Salones> SalonesPorLocalidad = ctx.Salones.Where(s => s.Localidad == IdLocalidad).ToList();
            return SalonesPorLocalidad;
        }

        //Trae salón por id del proveedor
        public Salones TraerSalonPorProveedor(int IdProveedor)
        {
            return ctx.Salones.Where(s => s.Proveedor == IdProveedor).FirstOrDefault();
        }
    }
}
