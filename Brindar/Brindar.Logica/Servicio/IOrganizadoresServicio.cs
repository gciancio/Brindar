using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface IOrganizadoresServicio
    {
        //Registro organizador
        public void RegistrarOrganizador(Organizadores o);
        //Saber si el organizador/proveedor ya está registrado
        public bool ExisteMailRegistrado(string Email);
        //Validar login
        public Organizadores ValidarLogin(string Email, string Password);
    }
}
