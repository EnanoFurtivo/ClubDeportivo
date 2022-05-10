using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControl;
using CapaNegocio;

namespace ClubDeportivo
{
    public partial class FormLogin : Form
    {
        private string clave;
        UsuarioController Usuarios;
        ActividadController Actividades = new ActividadController();
        string LugarBase;

        public FormLogin()
        {
            InitializeComponent();
            LugarBase = Application.StartupPath;
            UsuarioController.PonerPathABaseAccess(LugarBase);
            Usuarios = new UsuarioController();
//          Usuarios = UsuarioController.Recuperar(); 
//            Actividades = ActividadController.Recuperar();

            List<Usuario> lista = Usuarios.MostrarLista(typeof(Administrador));

            if (lista.Count==0)
                PrimerUsuario();

        }

        public void PrimerUsuario()
        {
            FormAgregarUsuario form = new FormAgregarUsuario(Actividades, Usuarios);
            form.ShowDialog();
        }

        private bool ValidarDni(string dniStr, out int dni)
        {
            if (dniStr == "")
            {
                MessageBox.Show("Se esperaba un dni", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni = -1;
                return false;
            }

            if (!int.TryParse(dniStr, out dni))
            {
                MessageBox.Show("El dni debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni = -1;
                return false;
            }

            return true;
        }
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                MessageBox.Show("Se esperaba una clave", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string dniStr = this.textBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            this.clave = textBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            if (Usuarios.ValidarCredenciales(dni, clave) == true)
            {
                FormAdministrador form = new FormAdministrador(dni, Usuarios, Actividades);
                //this.Hide();
                form.ShowDialog();
            }
            else
                MessageBox.Show("El dni o clave ingresada es incorrecta", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

      /*  private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {           
            if (Usuarios.Guardar()&& Actividades.guardar())
                MessageBox.Show("GUARDADO OK");
            else
                MessageBox.Show("ERROR AL GUARDAR");            
        }*/
    }
}
