using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClubDeportivo
{
    public partial class FormLogin : Form
    {
        private string nombre;
        private string clave;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.nombre = textBoxUsuario.Text;
            this.clave = textBoxClave.Text;


        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
