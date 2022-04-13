using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    class SocioController : UsuarioController
    {
        private List<Socio> ListaSocio = new List<Socio>();

        public void AgregarSocio(Socio socio)
        {
            ListaSocio.Add(socio);
        }

        public void EliminarSocio(Socio socio)
        {
            ListaSocio.Remove(socio);
        }

        public Socio GetSocio(int dni)
        {
            return this.ListaSocio.Find(u => u.Dni == dni);
        }
    }
}
