using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public abstract class Usuario
    {
        public string Nombre { get; internal set; }
        public int Dni { get; internal set; }

        private readonly string Clave;

        public Usuario(int dni, string nombre, string clave)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Clave = clave;
        }

        public bool ValidarClave(string clave)
        {
            return (this.Clave == clave);
        }

        public override string ToString()
        {
            return this.Dni+" - "+this.Nombre;
        }
    }
}