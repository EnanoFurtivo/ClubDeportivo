using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    public class Actividad
    {
        public int Id;
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public int CantMaxParticipantes { get; set; }
        public string Horario;
        public Profesor Profesor;

        public Actividad(int unId, string unaDescripcion, double unCosto, int unaCantMaxParticipantes, Profesor profesor, string horario)
        {
            this.Id = unId;
            this.Descripcion = unaDescripcion;
            this.Costo = unCosto;
            this.CantMaxParticipantes = unaCantMaxParticipantes;
            this.Profesor = profesor;
            this.Horario = horario;
        }

        public override string ToString()
        {
            return this.Descripcion + " - $" + this.Costo + " - " + this.Horario;
        }

        public ArrayList PasarARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(this.Id);
            datos.Add(this.Descripcion);
            datos.Add(this.Costo);
            datos.Add(this.CantMaxParticipantes);
            datos.Add(this.Horario);
            datos.Add(this.Profesor.Dni);

            return datos;
        }
    }
}
