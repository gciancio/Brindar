using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface IProveedoresServicio
    {
        //Registro proveedor
	    void RegistrarProveedor(Proveedores p);
	    //Activar/desactivar premium
	    void UsuarioPremium(int IdProveedor, bool Premium);
    }
}
