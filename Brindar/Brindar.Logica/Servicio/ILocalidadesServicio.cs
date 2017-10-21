using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface ILocalidadesServicio
    {
        //Traer lista de localidades
        public List<Localidades> TraerLocalidades();
    }
}
