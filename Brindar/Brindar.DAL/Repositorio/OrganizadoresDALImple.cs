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
        public Organizadores ValidarLogin(string Email, string Password)
        {
            var existe = ctx.Organizadores.Where(o => o.Email == Email && o.Contraseña = Password).FirstOrDefault();
            return existe;
        }
    }
}
