using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
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
    }
}
