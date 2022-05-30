using CapaDatos;
using System;
using System.Collections;
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

        private void agregarEnDB(string unaRazon, double unMonto)
        {
            ArrayList lista = new ArrayList()
            {
                this.Socio.Dni,
                DateTime.Now,
                unMonto,
                unaRazon
            };
            DatosBd.GuardarCuentaCorriente(lista);
        }
        public double AgregarDeuda(string unaRazon, double unMonto)
        {
            this.Saldo -= unMonto;
            agregarEnDB(unaRazon, unMonto);
            return this.Saldo;
        }

        internal void RegistrarPago(string descripcion, double monto)
        {
            agregarEnDB(descripcion, monto);
            this.Saldo += monto;
        }
    }
}