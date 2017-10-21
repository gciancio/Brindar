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
        public void RegistrarSalon(Salones s);
        //Editar un salon
        public void EditarSalon(int IdSalon, Salones s);
        //Borrar un salon
        public void BorrarSalon(int IdSalon);
        //Trae lista de todos los salones disponibles
        public List<Salones> TraerSalones();
        //Trae lista de salones por id de localidad
        public List<Salones> TraerSalonesPorLocalidad(int IdLocalidad);
        //Trae salón por id del proveedor
        public Salones TraerSalonPorProveedor(int IdProveedor);
    }
}
