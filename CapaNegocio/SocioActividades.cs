using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class SocioActividades : Socio
    {
        public SocioActividades(string nombre, string clave) : base(nombre, clave) { ; }

        public override double GenerarDeuda()
        {
            throw new NotImplementedException();
        }
    }
}
