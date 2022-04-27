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
        string label = "";
        string labelSingular = "";
        object lista = null;
        private bool GroupBoxAsignarActividades;
        string typeStr = "";
        string Tipo = "";
        bool[] BotonesActivos = null;
        private bool GroupBoxPagos;
        private bool ListaActividades;
        private bool GroupBoxUsuarios;
        private bool GroupBoxActividades;
        UsuarioController Usuarios;
        ActividadController Actividades;

        public FormAdministrador(int dni, UsuarioController UsuariosC, ActividadController ActividadesC)
        {
            InitializeComponent();

            Usuarios = UsuariosC;
            Actividades = ActividadesC;
            Administrador usuario = (Administrador)Usuarios.GetUsuario(dni);

            //Completar datos del formulario//
            labelBienvenida.Text = "Bienvenido/a de nuevo, " + usuario.Nombre;
            toolStripComboBox1.SelectedIndex = 0;
            CambiarFormulario("Modificar actividades");
        }

        private void RefrescarLista(bool clear = false, bool clearActividades = false)
        {
            switch (Tipo)
            {
                case "Modificar actividades":
                    listBox.DataSource = null;
                    lista = Actividades.MostrarLista();
                    break;

                case "Modificar profesores":
                    listBox.DataSource = null;
                    lista = Usuarios.MostrarLista(typeof(Profesor));
                    break;

                case "Modificar socios del club":
                    listBox.DataSource = null;
                    lista = Usuarios.MostrarLista(typeof(SocioClub));
                    break;

                case "Modificar socios de actividades":
                    listBox.DataSource = null;
                    lista = Usuarios.MostrarLista(typeof(SocioActividades));
                    break;

                case "Registrar pago":
                    listBox.DataSource = null;
                    lista = Usuarios.MostrarLista(typeof(SocioActividades)).Concat(Usuarios.MostrarLista(typeof(SocioClub))).Cast<Usuario>().ToList();
                    break;

                case "Asignar actividad":
                    Socio s = (Socio)listBox.SelectedItem;
                    
                    listBox.DataSource = null;
                    lista = Usuarios.MostrarLista(typeof(SocioActividades)).Concat(Usuarios.MostrarLista(typeof(SocioClub))).Cast<Usuario>().ToList();
                    
                    if (s != null)
                    {
                        listBoxActividadesSocio.DataSource = null;
                        this.listBoxActividadesSocio.DataSource = s.ActividadesSocio();

                        if (clearActividades)
                            listBoxActividadesSocio.ClearSelected();
                    }
                    break;
            }

            listBox.DataSource = lista;

            if(clear)
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
            GroupBoxPagos = false;
            GroupBoxAsignarActividades = false;
            ListaActividades = false;
            GroupBoxUsuarios = false;
            GroupBoxActividades = false;

            switch (tipo)
            {
                case "Modificar actividades":
                    GroupBoxActividades = true;
                    label = "actividades";
                    labelSingular = "Actividad";
                    typeStr = "Actividad";
                    break;

                case "Modificar profesores":
                    GroupBoxUsuarios = true;
                    label = "profesores";
                    labelSingular = "Profesor";
                    BotonesActivos[1] = false;
                    typeStr = "Profesor";
                    break;

                case "Modificar socios del club":
                    GroupBoxUsuarios = true;
                    label = "socios";
                    labelSingular = "Socio Club";
                    BotonesActivos[1] = false;
                    typeStr = "Socio";
                    break;

                case "Modificar socios de actividades":
                    GroupBoxUsuarios = true;
                    label = "socios";
                    labelSingular = "Socio Actividad";
                    BotonesActivos[1] = false;
                    typeStr = "Socio";
                    break;

                case "Registrar pago":
                    GroupBoxPagos = true;
                    label = "socios";
                    labelSingular = "socio";
                    typeStr = "Socio";
                    break;

                case "Asignar actividad":
                    GroupBoxAsignarActividades = true;
                    label = "socios";
                    labelSingular = "socio";
                    ListaActividades = true;
                    comboBoxAsignarActividad.DataSource = Actividades.MostrarLista();
                    typeStr = "Socio";
                    break;
            }

            labelLista.Text = label;

            groupBoxModificarActividad.Visible = GroupBoxActividades;
            groupBoxModificarUsuario.Visible = GroupBoxUsuarios;
            groupBoxRegistrarPago.Visible = GroupBoxPagos;
            groupBoxAsignarActividad.Visible = GroupBoxAsignarActividades;

            listBoxActividadesSocio.Visible = ListaActividades;

            buttonAgregar.Text = "Agregar "+labelSingular;
            buttonModificar.Text = "Modificar "+labelSingular;
            buttonEliminar.Text = "Eliminar "+labelSingular;

            buttonAgregar.Visible = BotonesActivos[0];
            buttonModificar.Visible = BotonesActivos[1];
            buttonEliminar.Visible = BotonesActivos[2];
            
            RefrescarLista(true);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Form form = new FormAgregarUsuario(Actividades, Usuarios);
            form.ShowDialog();
            RefrescarLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)listBox.SelectedItem;
            Usuarios.RemoveUsuario(usuario.Dni);

            RefrescarLista(true);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("ClubDeportivo.FormModificar" + typeStr);
            Form form = (Form)Activator.CreateInstance(type, Actividades, Usuarios);
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
            
            if(s==null)
                return;

            s.AsignarActividad((Actividad)comboBoxAsignarActividad.SelectedItem);
            RefrescarLista();
        }

        private void buttonAgregarActividad_Click(object sender, EventArgs e)
        {
            Form form = new FormAgregarActividad(Usuarios, Actividades);
            form.ShowDialog();
            RefrescarLista();
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            Actividad actividad = (Actividad)listBox.SelectedItem;

            if (actividad == null)
                return;

            Form form = new FormModificarActividad(actividad, Usuarios, Actividades);
            form.ShowDialog();
            RefrescarLista();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tipo == "Asignar actividad")
            {

                Socio s = (Socio)listBox.SelectedItem;

                if(s != null)
                {
                    listBoxActividadesSocio.DataSource = null;

                    List<RegistroActividad> listaTmp = s.GetActividades();
                    this.listBoxActividadesSocio.DataSource = listaTmp;

                    
                    listBoxActividadesSocio.ClearSelected();
                }
            }
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBox.SelectedItem;

            if (s == null)
                return;

            RegistroActividad ra = (RegistroActividad)listBoxActividadesSocio.SelectedItem;
            s.DesvincularActividad(ra);
            RefrescarLista(false, true);
        }

        private void listBoxActividadesSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxActividadesSocio.SelectedItem != null)
                buttonEliminarActividad.Enabled = true;
            else
                buttonEliminarActividad.Enabled = false;
        }

        private void buttonEliminarActividadLista_Click(object sender, EventArgs e)
        {
            Actividad actividad = (Actividad)listBox.SelectedItem;

            if (actividad == null)
                return;

            Actividades.EliminarActividad(actividad);

            RefrescarLista(true);
        }

        private void toolStripButtonGenerarDeuda_Click(object sender, EventArgs e)
        {
            Usuarios.GenerarDeuda();
        }
    }
}
