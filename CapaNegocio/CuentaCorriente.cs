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
        private double saldo;

        public CuentaCorriente(Socio unSocio)
        {
            this.socio = unSocio;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public double AgregarDeuda(string unaRazon, double unMonto)
        {
            string razon = unaRazon;
            return this.saldo += unMonto;
        }

        public void AgregarPago(double unMonto)
        {
            this.saldo -= unMonto;
        }
    }
}