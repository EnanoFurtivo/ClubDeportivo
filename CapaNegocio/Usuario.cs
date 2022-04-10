namespace CapaNegocio
{
    public class Usuario
    {
        private readonly string Nombre;
        private readonly string Clave;

        public Usuario(string nombre, string clave)
        {
            this.Nombre = nombre;
            this.Clave = clave;
        }
    }
}