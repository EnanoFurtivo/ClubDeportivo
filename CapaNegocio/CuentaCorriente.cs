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
        private int Id;
        private Socio Socio;
        private double Saldo;

        public CuentaCorriente(Socio socio)
        {
            this.Socio = socio;
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