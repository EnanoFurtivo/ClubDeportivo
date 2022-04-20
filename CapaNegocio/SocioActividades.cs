using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class SocioActividades : Socio
    {
        public SocioActividades(int dni, string nombre, string clave) : base(dni, nombre, clave) { ; }

        public override double GenerarDeuda()
        {
            throw new NotImplementedException();
        }
    }
}
