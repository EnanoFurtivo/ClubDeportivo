using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    public class SocioActividadesController : SocioController
    {
        private static List<SocioActividades> ListaSocioActividades = new List<SocioActividades>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            ListaSocioActividades.Add(new SocioActividades(dni, nombre, clave));
        }

        public override Usuario GetUsuario(int dni)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsuario(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
