using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Collections;

namespace CapaControl
{

    public enum EUsuario
    {
        Administrador = 0,
        Profesor = 1,
        SocioClub = 2,
        SocioActividades = 3
    }

    [Serializable]
    public class UsuarioController
    {
        private static List<Usuario> ListaUsuarios = new List<Usuario>();

        //ADD//
        public void AddSocioClub(int dni, string nombre, string clave, double cuota)
        {
            ListaUsuarios.Add(new SocioClub(dni, nombre, clave, cuota));
        }
        public void AddSocioActividades(int dni, string nombre, string clave)
        {
            ListaUsuarios.Add(new SocioActividades(dni, nombre, clave));
        }
        public void AddProfesor(int dni, string nombre, string clave)
        {
            ListaUsuarios.Add(new Profesor(dni, nombre, clave));
        }
        public void AddAdministrador(int dni, string nombre, string clave)
        {
            ListaUsuarios.Add(new Administrador(dni, nombre, clave));
        }

        //GET, REMOVE//
        public Usuario GetUsuario(int dni)
        {
            return ListaUsuarios.Find(u => u.Dni == dni);
        }
        public void RemoveUsuario(int dni)
        {
            ListaUsuarios.Remove(GetUsuario(dni));
        }

        //VALIDAR//
        public bool ValidarCredenciales(int dni, string clave)
        {
            Usuario u = null;

            if ((u = GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;

            return true;
        }

        //GET LIST//
        public List<Usuario> MostrarLista()
        {
            return ListaUsuarios;
        }
        public List<Usuario> MostrarLista(Type filterType)
        {
            List<Usuario> result = new List<Usuario>();

            foreach (var u in ListaUsuarios)
                if (u.GetType() == filterType)
                    result.Add(u);

            return result;
        }

        //SERIALIZAR
        public bool Guardar()
        {
            return DatosUsuarios.Guardar(this);
        }
        public static UsuarioController Recuperar()
        {
            UsuarioController dat = (UsuarioController)DatosUsuarios.Recuperar();

            if (dat == null)
                dat = new UsuarioController();

            return dat;
        }

    }
}
