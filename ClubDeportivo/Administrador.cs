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
        SocioClubController sociosClub = new SocioClubController();
        SocioActividadesController sociosActividades = new SocioActividadesController();
        ProfesorController profesores = new ProfesorController();

        string label = "";
        string labelSingular = "";
        object lista = null;
        string typeStr = "";
        string Tipo = "";

        public FormAdministrador(UsuarioController admin, int dni)
        {
            InitializeComponent();
            Usuario usuario = admin.GetUsuario(dni);
            labelBienvenida.Text = "Bienvenido/a de nuevo, " + usuario.Nombre;
            toolStripComboBox1.SelectedIndex = 0;
            CambiarFormulario("Modificar actividades");
        }

        private void RefrescarLista()
        {
            listBox.DataSource = null;

            switch (Tipo)
            {
                case "Modificar actividades":
                    lista = actividades.MostrarLista();
                    break;

                case "Modificar profesores":
                    lista = profesores.MostrarLista();
                    break;

                case "Modificar socios del club":
                    lista = sociosClub.MostrarLista();
                    break;

                case "Modificar socios de actividades":
                    lista = sociosActividades.MostrarLista();
                    break;
            }

            listBox.DataSource = lista;
            listBox.ClearSelected();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarFormulario(this.toolStripComboBox1.SelectedItem.ToString());
        }

        private void CambiarFormulario(string tipo)
        {
            Tipo = tipo;

            switch (tipo)
            {
                case "Modificar actividades":
                    label = "actividades";
                    labelSingular = "actividad";
                    typeStr = "Actividad";
                    break;

                case "Modificar profesores":
                    label = "profesores";
                    labelSingular = "profesor";
                    typeStr = "Profesor";
                    break;

                case "Modificar socios del club":
                    label = "socios";
                    labelSingular = "socio";
                    typeStr = "SocioClub";
                    break;

                case "Modificar socios de actividades":
                    label = "socios";
                    labelSingular = "socio";
                    typeStr = "SocioActividades";
                    break;

                case "Registrar pago":

                    break;
            }

            labelLista.Text = label;
            buttonAgregar.Text = "Agregar "+labelSingular;
            buttonModificar.Text = "Modificar "+labelSingular;
            buttonEliminar.Text = "Eliminar "+labelSingular;
            RefrescarLista();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("ClubDeportivo.FormAgregar"+typeStr);
            Form form = (Form)Activator.CreateInstance(type);
            form.ShowDialog();
            RefrescarLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("CapaControl." + typeStr + "Controller, CapaControl");
            UsuarioController controller = (UsuarioController)Activator.CreateInstance(type);
            Usuario usuario = (Usuario)listBox.SelectedItem;
            controller.RemoveUsuario(usuario.Dni);
            RefrescarLista();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("ClubDeportivo.FormModificar" + typeStr);
            Form form = (Form)Activator.CreateInstance(type);
            form.ShowDialog();
            RefrescarLista();
        }

    }
}
