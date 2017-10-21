using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Servicio;
using Brindar.Logica.Modelo;

namespace Brindar.DAL.Repositorio
{
    public class ProveedoresDALImple : IProveedoresServicio
    {
        BrindarEntities ctx = new BrindarEntities();

        //Registro proveedor
        public void RegistrarProveedor(Proveedores p)
        {
            ctx.Proveedores.Add(p);
            ctx.SaveChanges();
        }

        //Activar/desactivar premium
        public void UsuarioPremium(int IdProveedor, bool Premium)
        {
            var ServicioPremium = ctx.Proveedores.Find(IdProveedor);
            ServicioPremium.Premium = Premium;
            ctx.SaveChanges();
        }
    }
}
