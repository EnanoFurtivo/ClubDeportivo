using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;

namespace CapaControl
{
    [Serializable]
    public class SocioActividadesController : SocioController
    {
        private static List<SocioActividades> ListaSocioActividades = new List<SocioActividades>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            ListaSocioActividades.Add(new SocioActividades(dni, nombre, clave));
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
            throw new NotImplementedException();
        }
        public override List<Usuario> MostrarLista()
        {
            return ListaSocioActividades.Cast<Usuario>().ToList();
        }
        public bool Guardar()
        {
            return DatosSocioActividad.Guardar(this);
        }

        public static UsuarioController Recuperar()
        {
            SocioActividadesController dat = (SocioActividadesController)DatosSocioActividad.Recuperar();

            if (dat == null)
                dat = new SocioActividadesController();
            return dat;
        }
    }
}
