using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class ClsArchivo : IntSalidas
    {
        public void emprimirDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Estado);
        }

        public void imprimirCliente(AbsCliente clientes)
        {
            //ciclo para que el evento se ejecute infinatamente hasta que el archivo quede liberado
            //contador
            int contador = 0;
            bool swith = true;
            while (swith) {

                //pondremos un try cath para atrapar el error
                try
                {
                    //objeto para escribir en un archivo
                    //actualiza el contenido del mismo archivo
                    StreamWriter stringWriter = new StreamWriter(@"C:\Users\Angel\Documents\ArchivoPrueba.log", true);
                    stringWriter.WriteLine(clientes.Id);
                    stringWriter.WriteLine(clientes.Nombre);
                    stringWriter.WriteLine(clientes.Clave);
                    stringWriter.Close();
                    Console.WriteLine("Archivo creado");
                    swith = false;
                }
                catch (Exception e)
                {
                    //solucion para cuando hay un archivo abierto y otra app desea abrir el archivo
                    /*tenemos un swhith y un contador, esta app ejecutara el mismo proceso 1000 si la otra app termina
                     * antes de que finalicen los 1000 procesos pues esta app se ejecura
                     * nani xsxsxs
                    */
                    contador++;
                    if(contador >= 1000)
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
