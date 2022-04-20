using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;

namespace CapaControl
{
    public sealed class SocioClubController : SocioController
    {
        private static List<SocioClub> ListaSocioClub = new List<SocioClub>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            Usuario usuario = new SocioClub(dni, nombre, clave, 10);
            ListaSocioClub.Add((SocioClub)usuario);
        }

        public override Usuario GetUsuario(int dni)
        {
            return ListaSocioClub.Find(u => u.Dni == dni);
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
            Usuario usuario = GetUsuario(dni);
            ListaSocioClub.Remove((SocioClub)usuario);
        }

        public override List<Usuario> MostrarLista()
        {
            return ListaSocioClub.Cast<Usuario>().ToList();
        }


        public bool Guardar()
        {
            return DatosSocioClub.Guardar(this);
        }

        public static UsuarioController Recuperar()
        {
            SocioClubController dat = (SocioClubController)DatosSocioClub.Recuperar();

            if (dat == null)
                dat = new SocioClubController();
            return dat;
        }

    }
}
