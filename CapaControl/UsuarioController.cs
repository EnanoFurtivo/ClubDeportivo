using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
    public enum EUsuario
    {
        Administrador = 0,
        Profesor = 1,
        SocioClub = 2,
        SocioActividades = 3
    }

    public abstract class UsuarioController
    {
        public bool ValidarCredenciales(int dni, string clave)
        {
            Usuario u = null;

            if ((u = this.GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;

            return true;
        }
      
        public abstract Usuario GetUsuario(int dni);
        public abstract void RemoveUsuario(int dni);
        public abstract void AddUsuario(int dni, string nombre, string clave);

    }
}
