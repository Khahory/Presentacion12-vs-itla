using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class clsDirecciones
    {
        //constructor
        public clsDirecciones()
        {
            Calle = string.Empty;
            Colonia = string.Empty;
            Estado = string.Empty;

            
        }

        //variables
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }

       
    }
}
