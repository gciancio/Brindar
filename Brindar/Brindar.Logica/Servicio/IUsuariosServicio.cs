using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface IUsuariosServicio
    {
        //Registro organizador
        void RegistrarUsuario(Usuarios o);
        //Saber si el organizador/proveedor ya está registrado
        bool ExisteMailRegistrado(string Email);
        //Validar login
        int ValidarLogin(Usuarios o);
        //Activar/desactivar premium
        void ProveedorPremium(int IdUsuario, bool Premium);
        //Obtener id de usuario
        int ObtenerIdUsuario(string Email);
        //Obtener datos del usuario
        Usuarios ObtenerDatosUsuario(string Email);
        //Obtener tipo de usuario
        string ObtenerTipoUsuario(int IdTipoUsuario);
    }
}
