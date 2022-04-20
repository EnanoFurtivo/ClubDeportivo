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
        ActividadController Actividades = new ActividadController();
        UsuarioController Usuarios = new UsuarioController();

        string label = "";
        string labelSingular = "";
        object lista = null;
        string typeStr = "";
        string Tipo = "";

        public FormAdministrador(int dni)
        {
            InitializeComponent();

            Administrador usuario = (Administrador)Usuarios.GetUsuario(dni);

            //Completar datos del formulario//
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
                    lista = Actividades.MostrarLista();
                    break;

                case "Modificar profesores":
                    lista = Usuarios.MostrarLista(typeof(Profesor));
                    break;

                case "Modificar socios del club":
                    lista = Usuarios.MostrarLista(typeof(SocioClub));
                    break;

                case "Modificar socios de actividades":
                    lista = Usuarios.MostrarLista(typeof(SocioActividades));
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
            Usuario usuario = (Usuario)listBox.SelectedItem;
            Usuarios.RemoveUsuario(usuario.Dni);
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
