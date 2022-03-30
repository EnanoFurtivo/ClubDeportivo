using System;

namespace CapaNegocio
{
    internal class CuentaCorriente
    {
        private Socio socio;

        public CuentaCorriente(Socio socio)
        {
            this.socio = socio;
        }

        internal double GetDeuda()
        {
            throw new NotImplementedException();
        }

        internal double GenerarDeuda()
        {
            throw new NotImplementedException();
        }

        internal void RegistrarPago(string descripcion, double monto)
        {
            throw new NotImplementedException();
        }
    }
}