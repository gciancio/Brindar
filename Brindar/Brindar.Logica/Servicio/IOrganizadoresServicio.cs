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
        void RegistrarOrganizador(Organizadores o);
        //Saber si el organizador/proveedor ya está registrado
        bool ExisteMailRegistrado(string Email);
        //Validar login
        bool ValidarLogin(Organizadores o);
    }
}
