using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    public sealed class SocioActividadesController : SocioController
    {
        private static List<SocioActividades> ListaSocioActividades = new List<SocioActividades>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            Socio socio = new SocioActividades(dni, nombre, clave);
            ListaSocioActividades.Add((SocioActividades)socio);
        }

        public override Usuario GetUsuario(int dni)
        {
            return ListaSocioActividades.Find(u => u.Dni == dni);
        }

        public override bool ValidarCredenciales(int dni, string clave)
        {
            Usuario u = null;

            if ((u = this.GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;

            return true;
        }

        public override void RemoveUsuario(int dni)
        {
            Socio socio = (Socio)GetUsuario(dni);
            ListaSocioActividades.Remove((SocioActividades)socio);
        }
        public override List<Usuario> MostrarLista()
        {
            return ListaSocioActividades.Cast<Usuario>().ToList();
        }
    }
}
