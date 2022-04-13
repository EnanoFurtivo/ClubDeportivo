using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ClubDeportivo
{
    public partial class FormLogin : Form
    {
        private string nombre;
        private string clave;
        private Usuario usuario;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.nombre = textBoxUsuario.Text;
            this.clave = textBoxClave.Text;

            if (usuario == null)
                MessageBox.Show("No hay ningun usuario en la lista");
                else if (usuario.ValidarClave(clave) == false)
                    MessageBox.Show("El usuario no existe");
                else
                {
                    Club clb = new Club();
                    clb.ShowDialog();
                }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario regUs = new RegistrarUsuario();
            regUs.ShowDialog();
        }
    }
}
