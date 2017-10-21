using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface ITiposEventoServicio
    {
        //Trae lista de tipos de eventos
        public List<TiposEvento> TraerTiposEvento();
    }
}
