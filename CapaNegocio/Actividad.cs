using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Actividad
    {
        private int Id;
        private string Descripcion;
        public double Costo { get; set; }
        public int CantMaxParticipantes { get; set; }
        private List<Horario> Horarios;
        private Profesor Profesor;

        public Actividad(int unId, string unaDescripcion, double unCosto, int unaCantMaxParticipantes)
        {
            this.Id = unId;
            this.Descripcion = unaDescripcion;
            this.Costo = unCosto;
            this.CantMaxParticipantes = unaCantMaxParticipantes;
        }

        
    }
}
