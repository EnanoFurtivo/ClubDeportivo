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
    public enum EUsuario
    {
        Administrador = 0,
        Profesor = 1,
        SocioClub = 2,
        SocioActividades = 3
    }

    public abstract class UsuarioController
    {
        public abstract bool ValidarCredenciales(int dni, string clave);
        public abstract Usuario GetUsuario(int dni);
        public abstract void RemoveUsuario(int dni);
        public abstract void AddUsuario(int dni, string nombre, string clave);

        public abstract List<Usuario> MostrarLista();

        //public abstract bool Guardar();

        //public abstract UsuarioController Recuperar();
    }
}
