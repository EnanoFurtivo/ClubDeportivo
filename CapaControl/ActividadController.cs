using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    class ActividadesController
    {
        List<Actividad> ListActividad = new List<Actividad>();

        public ActividadesController(){ ; }

        public void AgregarActividad(Actividad actividad)
        {
            this.ListActividad.Add(actividad);
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
    }
}