using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brindar.Logica.Modelo;

namespace Brindar.Logica.Servicio
{
    public interface ISalonesServicio
    {
        //Registrar un salon
        void RegistrarSalon(Salones s);
        //Editar un salon
        void EditarSalon(int IdSalon, Salones s);
        //Borrar un salon
        void BorrarSalon(int IdSalon);
        //Trae lista de todos los salones disponibles
        List<Salones> TraerSalones();
        //Trae lista de salones por id de localidad
        List<Salones> TraerSalonesPorLocalidad(int IdLocalidad);
        //Trae salón por id del proveedor
        Salones TraerSalonPorProveedor(int IdProveedor);
    }
}
