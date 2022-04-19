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
    public partial class FormAdministrador : Form
    {
        ActividadController actividades = new ActividadController();

        public FormAdministrador(UsuarioController admin, int dni)
        {
            InitializeComponent();
            Usuario usuario = admin.GetUsuario(dni);
            labelBienvenida.Text = "Bienvenido/a de nuevo, " + usuario.Nombre;
            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = actividades.MostrarLista();
            listBoxActividades.ClearSelected();
        }

        private void buttonAgregarActividad_Click(object sender, EventArgs e)
        {
            FormAgregarActividad form = new FormAgregarActividad();
            form.ShowDialog();
        }

        private void buttonRefrescarLista_Click(object sender, EventArgs e)
        {
            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = actividades.MostrarLista();
            listBoxActividades.ClearSelected();
        }
    }
}
