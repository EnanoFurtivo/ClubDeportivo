using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;

namespace CapaControl
{
    [Serializable]
    public class ActividadController
    {
        List<Actividad> ListActividad = new List<Actividad>();

        public void AgregarActividad(int id, string desc, double costo, int CantMax, Profesor profesor, List<Horario> listaHorarios)
        {
            this.ListActividad.Add(new Actividad(id, desc, costo, CantMax, profesor, listaHorarios));
        }

        public void EliminarActividad(Actividad actividad)
        {
            this.ListActividad.Remove(actividad);
        }

        public void ModificarActividad(Actividad actividad, int cantMaxParticipantes, double costo)
        {
            actividad.Costo = costo;
            actividad.CantMaxParticipantes = cantMaxParticipantes;
        }

        public List<Actividad> MostrarLista()
        {
            return this.ListActividad;
        }
        public bool guardar()
        {
            return DatosActividad.Guardar(this);
        }

        public static ActividadController Recuperar()
        {
            ActividadController dat = (ActividadController)DatosActividad.Recuperar();
            if (dat == null)
                dat = new ActividadController();
            return dat;
        }
    }
}