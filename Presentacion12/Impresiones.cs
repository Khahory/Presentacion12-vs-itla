using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class Impresiones : IntSalidas
    {
        public void emprimirDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Estado);
        }

        //metodo para atrapar el error
        public void imprimirCliente(AbsCliente clientes)
        {
            try
            {
                Console.WriteLine(clientes.Id);
                Console.WriteLine(clientes.Nombre);
                Console.WriteLine(clientes.Clave);
            }
            catch (Exception e)
            {
                throw e;
            }

            
        }
    }
}
