using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class ProvinciasDALImple
    {
        BrindarEntities ctx = new BrindarEntities();

        //Traer lista de provincias
        public List<Provincias> TraerLocalidades()
        {
            List<Provincias> provincias = ctx.Provincias.ToList();
            return provincias;
        }
    }
}
