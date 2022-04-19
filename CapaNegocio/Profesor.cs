namespace CapaNegocio
{
    public class Profesor : Usuario
    {
        public Profesor(int dni, string nombre, string clave) : base(dni, nombre, clave) {; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}