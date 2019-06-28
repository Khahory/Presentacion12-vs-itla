using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
   abstract class AbsCliente
    {
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Clave{ get; set; }

    }
}
