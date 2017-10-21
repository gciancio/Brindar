using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class LocalidadesDALImple
    {
        BrindarEntities ctx = new BrindarEntities();

        //Traer lista de localidades
        public List<Localidades> TraerLocalidades()
        {
            List<Localidades> localidades = ctx.Localidades.ToList();
            return localidades;
        }
        
    }
}
