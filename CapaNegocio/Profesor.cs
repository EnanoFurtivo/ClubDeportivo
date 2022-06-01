using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    public class Profesor : Usuario
    {
        int Dni;
        string Nombre;
        string Clave;
        public Profesor(int dni, string nombre, string clave) : base(dni, nombre, clave)
        {
            Dni = dni;
            Nombre = nombre;
            Clave = clave;
        }

        public ArrayList PasarARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(this.Dni);
            datos.Add(this.Nombre);
            datos.Add(this.Clave);

            return datos;
        }
    }
}