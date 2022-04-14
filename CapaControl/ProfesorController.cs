using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    public class ProfesorController : UsuarioController
    {
        private static List<Profesor> ListaProfesor = new List<Profesor>();

        public override void AddUsuario(int dni, string nombre, string clave)
        {
            ListaProfesor.Add(new Profesor(dni, nombre, clave));
        }

        public override Usuario GetUsuario(int dni)
        {
            return ListaProfesor.Find(u => u.Dni == dni);
        }

        public override void RemoveUsuario(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
