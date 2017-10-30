using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class UsuariosDALImple : IUsuariosServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registro organizador
        public void RegistrarUsuario(Usuarios o)
        {
            ctx.Usuarios.Add(o);
            ctx.SaveChanges();
        }

        //Saber si el organizador/proveedor ya está registrado
        public bool ExisteMailRegistrado(string Email)
        {
            int existe = ctx.Usuarios.Where(o => o.Email == Email).Count();

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
        public int ValidarLogin(Usuarios o)
        {
            var usuario = ctx.Usuarios.Where(org => org.Email == o.Email && org.Password == o.Password).ToList();
            if (usuario.Count() != 1)
            {
                return 0;
            }

            return 1;
        }

        //Activar/desactivar proveedor premium
        public void ProveedorPremium(int IdUsuario, bool Premium)
        {
            var ServicioPremium = ctx.Usuarios.Find(IdUsuario);
            ServicioPremium.ProPremium = Premium;
            ctx.SaveChanges();
        }

        //Obtener Rol
        public Usuarios ObtenerRolUsuario(int IdUsuario)
        {
            var rol = ctx.Usuarios.Where(u => u.IdUsuario == IdUsuario).First();
            return rol;
        }

        //Obtener id de usuario
        public int ObtenerIdUsuario(string Email)
        {
            var Usuario = ctx.Usuarios.Where(u => u.Email == Email).First();
            int IdUsuario = Usuario.IdUsuario;
            return IdUsuario;
        }
    }
}
