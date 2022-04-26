using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class Actividad
    {
        public int Id;
        public string Descripcion;
        public double Costo { get; set; }
        public int CantMaxParticipantes { get; set; }
        public DateTime Horario;
        public List<Horario> Horarios;
        public Profesor Profesor;

        public Actividad(int unId, string unaDescripcion, double unCosto, int unaCantMaxParticipantes, Profesor profesor, List<Horario> horario)
        {
            this.Id = unId;
            this.Descripcion = unaDescripcion;
            this.Costo = unCosto;
            this.CantMaxParticipantes = unaCantMaxParticipantes;
            this.Profesor = profesor;
            //this.Horario = horario;
        }

        public override string ToString()
        {
            return this.Descripcion + " - $" + this.Costo;
        }
    }
}
