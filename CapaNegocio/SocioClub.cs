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
        private static int DescuentoExcedente = 50;
        private static int MaxActividades = 5;
        private double Cuota;

        public SocioClub(int dni, string nombre, string clave, double cuota) : base(dni, nombre, clave)
        {
            this.Cuota = cuota;
        }

        public override void GenerarDeuda()
        {
            this.CuentaCorriente.AgregarDeuda("Cuota mes "+DateTime.Now.Month+"-"+DateTime.Now.Year, this.Cuota); //agregar cuota
            List<RegistroActividad> rActividades = this.GetActividades();
            
            if (rActividades.Count > 5)
            {
                int i = 1;
                foreach (var rActividad in rActividades)
                {
                    if (i > 5)
                    {
                        this.CuentaCorriente.AgregarDeuda("Deuda actividad " + rActividad.Actividad.Descripcion + " " + DateTime.Now.Month + "-" + DateTime.Now.Year, rActividad.Actividad.Costo*DescuentoExcedente/100);
                    }
                    i++;
                }
            }
        }
    }
}
