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
    public partial class FormLogin : Form
    {
        private int dni;
        private string clave;
        private UsuarioController usuarioController =  new UsuarioController();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.dni = int.Parse(textBoxDni.Text);
            this.clave = textBoxClave.Text;

            if (usuarioController.ValidarCredenciales(dni, clave)==true)
            {
                Club clb = new Club();
                clb.ShowDialog();
            }
            else
                 MessageBox.Show("El dni o clave ingresada es incorrecta");
        
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario regUs = new RegistrarUsuario();
            regUs.ShowDialog();
        }
    }
}
