using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControl
{
    [Serializable]
    public class AdministradorController : UsuarioController
    {
        private static List<Administrador> ListaAdministrador = new List<Administrador>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            ListaAdministrador.Add(new Administrador(dni, nombre, clave));
        }

        public override Usuario GetUsuario(int dni)
        {
            return ListaAdministrador.Find(u => u.Dni == dni);
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
             return ListaAdministrador.Cast<Usuario>().ToList();
        }
        public bool Guardar()
        {
            return DatosAdministrador.Guardar(this);
        }

        public static AdministradorController Recuperar()
        {
            AdministradorController dat = (AdministradorController)DatosAdministrador.Recuperar();

            if (dat == null)
                dat = new AdministradorController();
            return dat;
        }
    }
}
