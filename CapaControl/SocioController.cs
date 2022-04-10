using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
    class SocioController : UsuarioController
    {
        private List<Socio> ListaSocio = new <Socio> ();

        public void AgregarSocio()
        {
            ListaSocio.Add(Socio);
        }

        public void EliminarSocio()
        {
            ListaSocio.Remove(Socio);
        }

        public Socio GetSocio(int dni)
        {
            return this.ListaSocio.Find(u => u.Dni == Dni);
        }
    }
}
