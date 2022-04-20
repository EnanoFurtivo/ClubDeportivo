using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class SocioClub : Socio
    {
        private static int MaxActividades = 5;
        private double Cuota;

        public SocioClub(int dni, string nombre, string clave, double cuota) : base(dni, nombre, clave)
        {
            this.Cuota = cuota;
        }

        public override double GenerarDeuda()
        {
            throw new NotImplementedException();
        }
    }
}
