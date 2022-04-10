using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Actividad
    {
        public int id;
        public string descripcion;
        public double costo;
        public int cantMaxParticipantes;
        private List<Horario> horarios;
        private Profesor profesor;

        public Actividad(int unId, string unaDescripcion, double unCosto, int unaCantMaxParticipantes)
        {
            this.id = unId;
            this.descripcion = unaDescripcion;
            this.costo = unCosto;
            this.cantMaxParticipantes = unaCantMaxParticipantes;
        }
    }
}
