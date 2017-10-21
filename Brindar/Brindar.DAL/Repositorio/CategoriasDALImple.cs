using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class CategoriasDALImple
    {
        BrindarEntities ctx = new BrindarEntities();

        //Traer lista de categorías
        public List<Categorias> TraerCategorias()
        {
            List<Categorias> categorias = ctx.Categorias.ToList();
            return categorias;
        }
    }
}
