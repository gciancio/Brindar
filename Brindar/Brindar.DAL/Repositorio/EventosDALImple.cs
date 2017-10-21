using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;
using Brindar.Logica.Servicio;

namespace Brindar.DAL.Repositorio
{
    public class EventosDALImple : IEventosServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Crear un evento
        public void RegistrarEvento(Eventos e)
        {
            ctx.Eventos.Add(e);
            ctx.SaveChanges();
        }

        //Editar un evento
        public void EditarEvento(int IdEvento, Eventos e)
        {
            var EventoEdit = ctx.Eventos.Find(IdEvento);
            EventoEdit.Salon = e.Salon;
            EventoEdit.Servicio = e.Servicio;
            EventoEdit.Fecha = e.Fecha;
            EventoEdit.Presupuesto = e.Presupuesto;
            ctx.SaveChanges();
        }

        //Borrar un evento
        public void BorrarEvento(int IdEvento)
        {
            var eve = ctx.Eventos.Find(IdEvento);
            ctx.Eventos.Remove(eve);
            ctx.SaveChanges();
        }

        //Trae evento por ID
        public Eventos TraerEvento(int? IdEvento)
        {
            return ctx.Eventos.Find(IdEvento);
        }

        //Borrar un servicio de un evento
        public void BorrarServicioDeEvento(int IdEvento, int IdServicio)
        {
            var ser = ctx.Eventos.Where(e => e.IdEvento == IdEvento && e.Servicio == IdServicio).First();
            ctx.Eventos.Remove(ser);
            ctx.SaveChanges();
        }

        //Trae lista de eventos por organizador
        public List<Eventos> TraerEventosOrganizador(int IdOrganizador)
        {
            List<Eventos> EventosOrganizados = ctx.Eventos.Where(e => e.Organizador == IdOrganizador).ToList();
            return EventosOrganizados;
        }
    }
}
