using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Actividad
    {
        private int id;
        private string descripcion;
        private double costo { get; set; }
        private int cantMaxParticipantes { get; set; }
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
