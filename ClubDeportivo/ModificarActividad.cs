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
    public partial class FormModificarActividad : Form
    {
        public List<Horario> ListaHorarios = new List<Horario>();
        ActividadController Actividades;
        UsuarioController Usuarios;
        Actividad Actividad;

        public FormModificarActividad(Actividad actividad, UsuarioController UsuariosC, ActividadController ActividadC)
        {
            InitializeComponent();
            Actividades = ActividadC;
            Usuarios = UsuariosC;
            Actividad = actividad;
            CompletarDatos();
        }

        private void CompletarDatos()
        {
            //setear datos de texto//
            this.textBoxId.Text = this.Actividad.Id.ToString();
            this.textBoxDesc.Text = this.Actividad.Descripcion;
            this.textBoxCosto.Text = this.Actividad.Costo.ToString();
            this.textBoxCantMax.Text = this.Actividad.CantMaxParticipantes.ToString();
            
            //setear profesor//
            this.comboBoxProfesor.DataSource = null;
            this.comboBoxProfesor.DataSource = Usuarios.MostrarLista(typeof(Profesor));
            this.comboBoxProfesor.SelectedItem = (Profesor)Usuarios.GetUsuario(Actividad.Profesor.Dni);

            //horarios
            this.ListaHorarios = Actividad.Horarios;
        }

        private void buttonAgregarHorario_Click(object sender, EventArgs e)
        {
            DateTime horarioInicio = this.dateTimePickerHorarioInicio.Value;
            DateTime horarioFin = this.dateTimePickerHorarioFin.Value;

            Horario horarioActividad = new Horario(horarioInicio, horarioFin);
            ListaHorarios.Add(horarioActividad);
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxId.Text);
            string desc = this.textBoxDesc.Text;
            double costo = double.Parse(this.textBoxCosto.Text);
            int CantMax = int.Parse(this.textBoxCantMax.Text);
            Profesor profesor = (Profesor)this.comboBoxProfesor.SelectedItem;
            Actividades.ModificarActividad(id, CantMax, desc, costo, profesor, ListaHorarios);
            this.Close();
        }
    }
}
