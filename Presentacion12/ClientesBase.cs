using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class ClientesBase : AbsCliente
    {
        //constructor
        public ClientesBase()
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
        }

        public ClientesBase(int pId, string pNombre, string pClave)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;

        }

        //override
        public override int Id { get; set ; }
        public override string Nombre { get; set; }
        public override string Clave { get; set; }
    }
}
