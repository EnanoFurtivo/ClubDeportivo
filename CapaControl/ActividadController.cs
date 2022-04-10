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

        public ActividadesController()
        {

        }

        public bool AgregarActividad(Actividad actividad)
        {
            this.ListActividad.Add(actividad);
        }

        public bool EliminarActividad(Actividad actividad)
        {
            this.ListActividad.Remove(actividad);
        }

        public void ModificarActividad(Actividad actividad)
        {
            
        }
    }
}