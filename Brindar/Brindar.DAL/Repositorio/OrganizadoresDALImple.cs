using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class OrganizadoresDALImple : IOrganizadoresServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registro organizador
        public void RegistrarOrganizador(Organizadores o)
        {
            ctx.Organizadores.Add(o);
            ctx.SaveChanges();
        }

        //Saber si el organizador/proveedor ya está registrado
        public bool ExisteMailRegistrado(string Email)
        {
            int existe = ctx.Organizadores.Where(o => o.Email == Email).Count();

            if (existe > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Validar login
        public bool ValidarLogin(Organizadores o)
        {
            var organizador = ctx.Organizadores.Where(org => org.Email == o.Email && org.Contraseña == o.Contraseña).ToList();
            if (organizador.Count() == 0 || organizador.Count() > 1)
            {
                return false;
            }

            return true;
        }
    }
}
