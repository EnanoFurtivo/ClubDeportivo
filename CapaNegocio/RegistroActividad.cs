using System;

namespace CapaNegocio
{
    internal class RegistroActividad
    {
        public DateTime Fecha { get; internal set; }
        public Actividad Actividad { get; internal set; }

        public RegistroActividad(DateTime fecha, Actividad actividad)
        {
            this.Fecha = fecha;
            this.Actividad = actividad;
        }
    }
}