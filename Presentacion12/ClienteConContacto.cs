using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class ClienteConContacto : ClientesBase
    {
        //constructor
        public ClienteConContacto()
        {
            _Direcciones = new clsDirecciones();

        }

        public ClienteConContacto(int pId, string pNombre, string pClave, string pTelefono, string pEmail, string pClalle
                                                                        , string pColonia, string pEstado)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            Telefono = pTelefono;
            Email = pEmail;
            _Direcciones = new clsDirecciones();
            Direcciones.Calle = pClalle;
            Direcciones.Colonia = pColonia;
            Direcciones.Estado = pEstado;

        }

        //variables
        public string Telefono{ get; set; }
        public string Email { get; set; }
        internal clsDirecciones Direcciones { get => _Direcciones; set => _Direcciones = value; }

        private clsDirecciones _Direcciones;
   

    }
}
