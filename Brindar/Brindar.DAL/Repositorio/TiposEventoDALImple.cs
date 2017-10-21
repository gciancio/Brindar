using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class TiposEventoDALImple
    {
        BrindarEntities ctx = new BrindarEntities();

        //Trae lista de tipos de eventos
        public List<TiposEvento> TraerTiposEvento()
        {
            List<TiposEvento> tiposEvento = ctx.TiposEvento.ToList();
            return tiposEvento;
        }
    }
}
