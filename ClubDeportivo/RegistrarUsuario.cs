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

namespace ClubDeportivo
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(EUsuario));
        }

        //Validaciones//
        private bool ValidarNombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Se esperaba un nombre de usuario", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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
        private bool ValidarTipoUsuario(EUsuario tipoUsuario)
        {
            //if (!OpcionesComboBox.Contains(tipoUsuario))
            //{
                //MessageBox.Show("Se esperaba un tipo de usuario valido", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return false;
            //}

            return true;
        }

        //eventos//
        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible = false;
            EUsuario tipoUsuario = (EUsuario)this.comboBoxTipoUsuario.SelectedItem;

            if (tipoUsuario == EUsuario.SocioClub)
                visible = true;

            this.textBoxCuota.Visible = visible;
            this.labelCuota.Visible = visible;
        }
        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            string nombre = this.textBoxUsuario.Text;
            if (!ValidarNombre(nombre))
                return;

            string dniStr = this.textBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string clave = this.textBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            EUsuario tipoUsuario = (EUsuario)this.comboBoxTipoUsuario.SelectedItem;
            if (!ValidarTipoUsuario(tipoUsuario))
                return;

            UsuarioController controller;
            switch (tipoUsuario)
            {
                case EUsuario.Administrador:
                    controller.AddAdministrador(dni, nombre, clave);
                    break;

                case EUsuario.Profesor:
                    controller.AddProfesor(dni, nombre, clave);
                    break;

                case EUsuario.SocioClub:
                    controller.AddSocioClub(dni, nombre, clave);
                    break;

                case EUsuario.SocioActividades:
                    controller.AddSocioActividades(dni, nombre, clave);
                    break;

                default:
                    MessageBox.Show("Error interno del sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            this.Close();
        }
    }
}
