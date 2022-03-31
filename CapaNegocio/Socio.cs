using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Socio : Usuario
    {
        private bool Estado;
        private List<RegistroActividad> RegistroActividades;
        private CuentaCorriente CuentaCorriente;

        public Socio()
        {
            this.Estado = true;
            this.RegistroActividades = new List<RegistroActividad>();
            this.CuentaCorriente = new CuentaCorriente(this);
        }

        public List<Actividad> GetActividades()
        {
            //Leer todos los registros y devolver las actividades del mes actual//
            //Si no hay registros de actividad se devuelve null//

            if (this.RegistroActividades.Count < 1)
                return null;

            List<Actividad> resultList = new List<Actividad>();

            foreach (RegistroActividad rActividad in this.RegistroActividades)
                if (rActividad.Fecha.Month == DateTime.Now.Month)
                    resultList.Add(rActividad.Actividad);

            return resultList;
        }

        public void RegistrarPago(string descripcion, double monto)
        {
            this.CuentaCorriente.RegistrarPago(descripcion, monto);
        }

        public double GetDeuda()
        {
            //La cuenta corriente se encarga de administrar la deuda//
            return this.CuentaCorriente.GetDeuda();
        }

        public abstract double GenerarDeuda();
        //dependiendio del tipo de socio se genera dedua de manera distinta//

    }
}
