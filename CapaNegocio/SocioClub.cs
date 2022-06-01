using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    public class SocioClub : Socio
    {
        private static int DescuentoExcedente = 50;
        private static int MaxActividades = 5;
        private double Cuota;
        private int Dni;
        private string Nombre;
        private string Clave;

        public SocioClub(int dni, string nombre, string clave, double cuota) : base(dni, nombre, clave)
        {
            this.Cuota = cuota;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Clave = clave;
        }

        public override void GenerarDeuda()
        {
            this.CuentaCorriente.AgregarDeuda("Cuota mes "+DateTime.Now.Month+"-"+DateTime.Now.Year, this.Cuota); //agregar cuota
            List<RegistroActividad> rActividades = this.GetActividadesMesAnterior();
            
            if (rActividades.Count > MaxActividades)
            {
                int i = rActividades.Count;
                foreach (var rActividad in rActividades)
                {
                    if (i > MaxActividades)
                    {
                        this.CuentaCorriente.AgregarDeuda("Deuda actividad " + rActividad.Actividad.Descripcion + " " + DateTime.Now.Month + "-" + DateTime.Now.Year, rActividad.Actividad.Costo*DescuentoExcedente/100);
                    }
                    i--;
                }
            }
        }

        public ArrayList PasarARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(this.Dni);
            datos.Add(this.Nombre);
            datos.Add(this.Clave);
            datos.Add(this.Cuota);

            return datos;
        }
    }
}
