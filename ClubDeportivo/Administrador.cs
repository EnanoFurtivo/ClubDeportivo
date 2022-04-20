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
        bool[] BotonesActivos = null;
        bool RegistrarPagoButtons;
        bool AsignarActividadButtons;

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

                case "Registrar pago":
                    lista = Usuarios.MostrarLista(typeof(SocioActividades)).Concat(Usuarios.MostrarLista(typeof(SocioClub))).Cast<Usuario>().ToList();
                    break;

                case "Asignar actividad":
                    lista = Usuarios.MostrarLista(typeof(SocioActividades)).Concat(Usuarios.MostrarLista(typeof(SocioClub))).Cast<Usuario>().ToList();
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

            BotonesActivos = new bool[] { true, true, true };
            RegistrarPagoButtons = false;
            AsignarActividadButtons = false;

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
                    BotonesActivos[1] = false;
                    typeStr = "Profesor";
                    break;

                case "Modificar socios del club":
                    label = "socios";
                    labelSingular = "socio";
                    BotonesActivos[1] = false;
                    typeStr = "SocioClub";
                    break;

                case "Modificar socios de actividades":
                    label = "socios";
                    labelSingular = "socio";
                    BotonesActivos[1] = false;
                    typeStr = "SocioActividades";
                    break;

                case "Registrar pago":
                    label = "socios";
                    labelSingular = "socio";
                    BotonesActivos[0] = false;
                    BotonesActivos[1] = false;
                    BotonesActivos[2] = false;
                    RegistrarPagoButtons = true;
                    typeStr = "Socio";
                    break;

                case "Asignar actividad":
                    label = "socios";
                    labelSingular = "socio";
                    BotonesActivos[0] = false;
                    BotonesActivos[1] = false;
                    BotonesActivos[2] = false;
                    comboBoxAsignarActividad.DataSource = Actividades.MostrarLista();
                    AsignarActividadButtons = true;
                    typeStr = "Socio";
                    break;
            }

            labelLista.Text = label;

            buttonAgregar.Text = "Agregar "+labelSingular;
            buttonModificar.Text = "Modificar "+labelSingular;
            buttonEliminar.Text = "Eliminar "+labelSingular;

            buttonAgregar.Visible = BotonesActivos[0];
            buttonModificar.Visible = BotonesActivos[1];
            buttonEliminar.Visible = BotonesActivos[2];

            groupBoxRegistrarPago.Visible = RegistrarPagoButtons;
            groupBoxAsignarActividad.Visible = AsignarActividadButtons;
            
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

        private void buttonRegistrarPago_Click(object sender, EventArgs e)
        {
            double monto;
            if (double.TryParse(textBoxMonto.ToString(), out monto))
            {
                Socio s = (Socio)listBox.SelectedItem;
                s.RegistrarPago("una desc", monto);
            }
        }

        private void buttonAsignarActividad_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBox.SelectedItem;
            s.AsignarActividad((Actividad)comboBoxAsignarActividad.SelectedItem);
        }
    }
}
