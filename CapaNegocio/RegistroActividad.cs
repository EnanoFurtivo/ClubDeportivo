using System;

namespace CapaNegocio
{
    public class RegistroActividad
    {
        public DateTime Fecha { get; internal set; }
        public Actividad Actividad { get; internal set; }

        public RegistroActividad(DateTime fecha, Actividad actividad)
        {
            this.Fecha = fecha;
            this.Actividad = actividad;
        }
        public override string ToString()
        {
            return this.Actividad.Descripcion + " - " + this.Fecha.ToString();
        }
    }
}