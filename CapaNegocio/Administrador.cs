using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Administrador : Usuario
    {
        public Administrador(int dni, string nombre, string clave) : base(dni, nombre, clave) { ; }

    }
}
