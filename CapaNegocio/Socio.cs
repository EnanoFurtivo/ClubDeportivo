using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public abstract class Socio : Usuario
    {
        private bool Estado;
        private List<RegistroActividad> RegistroActividades;
        private CuentaCorriente CuentaCorriente;

        public Socio(int dni, string nombre, string clave) : base(dni, nombre, clave)
        {
            this.Estado = true;
            this.RegistroActividades = new List<RegistroActividad>();
            this.CuentaCorriente = new CuentaCorriente(this);
        }

        /// <summary>
        /// Devuelve las actividades del mes actual.
        /// Si no hay registros de actividad devuelve null.
        /// </summary>
        public List<Actividad> GetActividades()
        {
            if (this.RegistroActividades.Count < 1)
                return null;

            List<Actividad> resultList = new List<Actividad>();

            foreach (RegistroActividad rActividad in this.RegistroActividades)
                if (rActividad.Fecha.Month == DateTime.Now.Month)
                    resultList.Add(rActividad.Actividad);

            return resultList;
        }

        /// <summary>
        /// Registra un nuevo pago para el socio
        /// </summary>
        public void RegistrarPago(string descripcion, double monto)
        {
            this.CuentaCorriente.RegistrarPago(descripcion, monto);
        }

        /// <summary>
        /// Obtiene el saldo del socio
        /// </summary>
        public double GetSaldo()
        {
            return this.CuentaCorriente.GetSaldo();
        }

        public abstract double GenerarDeuda();

        /// <summary>
        /// Devuelve la cantidad de actividades en las que esta registrado el socio
        /// </summary>
        public double CountActividades()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Le asigna una actividad al socio
        /// </summary>
        public void AsignarActividad(Actividad actividad)
        {
            RegistroActividad ra = new RegistroActividad(DateTime.Now, actividad);
            this.RegistroActividades.Add(ra);
        }

        /// <summary>
        /// Desvincula una actividad del socio
        /// </summary>
        public double DesvincularActividad()
        {
            throw new NotImplementedException();
        }
    }
}
