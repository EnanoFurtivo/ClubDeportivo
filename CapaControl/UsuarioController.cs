using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
    public class UsuarioController
    {
        private List<Usuario> ListaUsuario = new List<Usuario>();
        
        public bool ValidarCredenciales(int dni, string clave)
        {
            Usuario u = null;

            if ((u = this.GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;

            return true;
        }


        public Usuario GetUsuario(int dni)
        {
            return this.ListaUsuario.Find(u => u.Dni == dni);
        }
    }
}
