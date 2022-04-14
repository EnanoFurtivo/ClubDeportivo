using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    public class SocioClubController : SocioController
    {
        private static List<SocioClub> ListaSocioClub = new List<SocioClub>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            ListaSocioClub.Add(new SocioClub(dni, nombre, clave, 10));
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
