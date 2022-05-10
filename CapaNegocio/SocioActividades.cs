using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    [Serializable]
    public class SocioActividades : Socio
    {
        private int Dni;
        private string Nombre;
        private string Clave;
        public SocioActividades(int dni, string nombre, string clave) : base(dni, nombre, clave)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Clave = clave;
        }
        public override void GenerarDeuda()
        {
            foreach (var rActividad in this.GetActividadesMesAnterior())
                this.CuentaCorriente.AgregarDeuda("Deuda actividad " + rActividad.Actividad.Descripcion + " " + DateTime.Now.Month + "-" + DateTime.Now.Year, rActividad.Actividad.Costo);
        }

        public ArrayList PasarARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(this.Dni);
            datos.Add(this.Nombre);
            datos.Add(this.Clave);
            datos.Add(0);

            return datos;
        }
    }
}
