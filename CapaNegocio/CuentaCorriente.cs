using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CuentaCorriente
    {
        private int id;
        private Socio socio;
        private double monto;

        public CuentaCorriente(Socio unSocio)
        {
            this.socio = unSocio;
        }

        public double GetDeuda()
        {
            return monto;
        }

        public double AgregarDeuda(string unaRazon, double unMonto)
        {
            string razon = unaRazon;

            return monto += unMonto;
        }

        public void AgregarPago(double unMonto)
        {
            monto -= unMonto;
        }
    }
}
