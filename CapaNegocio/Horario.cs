using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Horario
    {
        private DateTime HorarioInicio;
        private DateTime HorarioFin;

        public Horario(DateTime horarioInicio, DateTime horarioFin)
        {
            this.HorarioInicio = horarioInicio;
            this.HorarioFin = horarioFin;
        }
    }
}
