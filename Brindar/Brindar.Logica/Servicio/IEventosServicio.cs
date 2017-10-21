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
        public void RegistrarEvento(Eventos e);
        //Editar un evento
        public void EditarEvento(int IdEvento, Eventos s);
        //Borrar un evento
        public void BorrarEvento(int IdEvento);
        //Trae evento por ID
        public Eventos TraerEvento(int? IdEvento);
        //Borrar un servicio de un evento
        public void BorrarServicioDeEvento(int IdEvento, int IdServicio);
        //Trae lista de eventos por organizador
        public List<Eventos> TraerEventosOrganizador(int IdOrganizador);
        
        //public void AsignarProveedores(EventoProveedores ProvAsignado);
    }
}
