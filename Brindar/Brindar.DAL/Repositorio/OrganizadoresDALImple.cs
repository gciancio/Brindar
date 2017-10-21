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

        //Registro usuario
        public void RegistrarOrganizador(Organizadores o)
        {
            ctx.Organizadores.Add(o);
            ctx.SaveChanges();
        }

        //Saber si el organizador/proveedor ya está registrado
        public bool ExisteMailRegistrado(string Email)
        {
            int existe = (from org in ctx.Organizadores where org.Email == Email select org).Count();
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
        public bool ValidarLogin(String Email, String Password)
        {
            int existe = (from org in ctx.Organizadores where org.Email == Email select org).Count();

            if (existe > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Trae lista de eventos por organizador
        public List<Eventos> TraerEventosOrganizador(int IdOrganizador);
    }
}
