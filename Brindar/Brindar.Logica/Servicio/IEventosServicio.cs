using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface IEventosServicio
    {
        //Crear un evento
        void RegistrarEvento(Eventos e);
        //Editar un evento
        void EditarEvento(int IdEvento, Eventos s);
        //Borrar un evento
        void BorrarEvento(int IdEvento);
        //Trae evento por ID
        Eventos TraerEvento(int? IdEvento);
        //Borrar un servicio de un evento
        void BorrarServicioDeEvento(int IdEvento, int IdServicio);
        //Trae lista de eventos por organizador
        List<Eventos> TraerEventosOrganizador(int IdOrganizador);
        
        //public void AsignarProveedores(EventoProveedores ProvAsignado);
    }
}
