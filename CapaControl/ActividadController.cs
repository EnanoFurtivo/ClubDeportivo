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
    public sealed class ActividadController
    {
        private List<Actividad> ListActividad = new List<Actividad>();

        public void AgregarActividad(int id, string desc, double costo, int CantMax, Profesor profesor, List<Horario> listaHorarios)
        {
            ListActividad.Add(new Actividad(id, desc, costo, CantMax, profesor, listaHorarios));
        }

        public void EliminarActividad(Actividad actividad)
        {
            ListActividad.Remove(actividad);
        }

        public Actividad GetActividad(int idActividad)
        {
            return ListActividad.Find(u => u.Id == idActividad);
        }

        public void ModificarActividad(int idActividad, int cantMaxParticipantes, string descripcion, double costo, Profesor profesor, List<Horario> horarios)
        {
            Actividad actividad = this.GetActividad(idActividad);
            actividad.Descripcion = descripcion;    
            actividad.Profesor = profesor;
            actividad.Horarios = horarios;
            actividad.Costo = costo;
            actividad.CantMaxParticipantes = cantMaxParticipantes;
        }

        public List<Actividad> MostrarLista()
        {
            return ListActividad;
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