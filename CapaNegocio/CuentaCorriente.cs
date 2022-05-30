using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class CuentaCorriente
    {
        private Socio Socio;
        private double Saldo;

        public CuentaCorriente(Socio socio, double saldo)
        {
            this.Socio = socio;
            this.Saldo = saldo;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public double AgregarDeuda(string unaRazon, double unMonto)
        {
            string razon = unaRazon;

            return this.Saldo -= unMonto;
        }

        internal void RegistrarPago(string descripcion, double monto)
        {
            this.Saldo += monto;
        }
    }
}