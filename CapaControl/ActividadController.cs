using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;
using System.Collections;

namespace CapaControl
{
    public sealed class ActividadController
    {
        private List<Actividad> ListActividad;
        private UsuarioController Usuario;

        public ActividadController(UsuarioController usuario)
        {
            Usuario = usuario;
            ListActividad = new List<Actividad>();
            this.RecuperarActividad();
        }

        public bool AgregarActividad(int id, string desc, double costo, int cantMax, Profesor profesor, string horario)
        {
            Actividad actividad = new Actividad(id, desc, costo, cantMax, profesor, horario);
            bool todoBien = false;

            if (actividad != null)
            {
                todoBien = DatosBd.GuardarActividad(actividad.PasarARelacional());
                if (todoBien)
                    this.ListActividad.Add(actividad);
            }
            return todoBien;
        }

        public void EliminarActividad(Actividad actividad)
        {
            ListActividad.Remove(actividad);
            DatosBd.EliminarActividad(actividad.Id);
        }

        public Actividad GetActividad(int idActividad)
        {
            return ListActividad.Find(u => u.Id == idActividad);
        }
        public Actividad GetActividad(string nombre)
        {
            return ListActividad.Find(u => u.Descripcion == nombre);
        }
        public bool ModificarActividad(int idActividad, int cantMaxParticipantes, string descripcion, double costo, Profesor profesor, string horario)
        {
            Actividad actividad = this.GetActividad(idActividad);
            actividad.Descripcion = descripcion;    
            actividad.Profesor = profesor;
            actividad.Horario = horario;
            actividad.Costo = costo;
            actividad.CantMaxParticipantes = cantMaxParticipantes;

            bool todoBien = false;

            if (actividad != null)
                todoBien = DatosBd.ModificarActividad(actividad.PasarARelacional());
            
            return todoBien;
        }

        public List<Actividad> MostrarLista()
        {
            return this.ListActividad;
        }

        public void RecuperarActividad()
        {
            int id;
            string desc;
            double costo;
            int cantMaxParticipantes;
            string horario;
            int dniProfesor;
            Profesor profesor;

            ArrayList datosActividad = DatosBd.RecuperarActividad();

            for (int i = 0; i <= datosActividad.Count - 6; i = i + 6)
            {
                id = int.Parse(datosActividad[i].ToString());
                desc = datosActividad[i + 1].ToString();
                costo = double.Parse(datosActividad[i + 2].ToString());
                cantMaxParticipantes = int.Parse(datosActividad[i + 3].ToString());
                horario = datosActividad[i + 4].ToString();
                dniProfesor = int.Parse(datosActividad[i + 5].ToString());
                profesor = (Profesor)Usuario.GetUsuario(dniProfesor);

                ListActividad.Add(new Actividad(id, desc, costo, cantMaxParticipantes, profesor, horario));
            }
        }
    }
}