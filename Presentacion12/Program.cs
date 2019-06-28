using Presentacion12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class Program
    {
        static void Main(string[] args)
        {
            //dos maneras de agregarle los datos al cliente
            ClienteConContacto clientes = new ClienteConContacto(001, "Angel", "pass", "8493422380", "angeld05@live.com",
                                                                        "Dr. Mario Garcia", "Quisqueya", "Distrito");

            //  clsDirecciones direcciones = new clsDirecciones();

            //objeto
            IntSalidas imprimir;

            //leer una cadena de consola
            string cadena = Console.ReadLine();
            if (cadena == "1")
                imprimir = new Impresiones();
            else
                imprimir = new ClsArchivo();

            //otro try cath para mostrar el error
            try
            {
                imprimir.imprimirCliente(clientes);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error: " +e.Message);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
