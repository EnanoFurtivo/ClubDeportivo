using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaControl
{
    class ProfesorController: UsuarioController
    {
        private List<Profesor> ListaProfesor = new List<Profesor>();

        public void AgregarProfesor(Profesor profesor)
        {
            ListaProfesor.Add(profesor);
        }

        public void EliminarProfesor(Profesor profesor)
        {
            ListaProfesor.Remove(profesor);
        }

        public Profesor GetProfesor(int dni)
        {
            return this.ListaProfesor.Find(u => u.Dni == dni);
        }
    }
}
