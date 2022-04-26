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
    public partial class FormModificarProfesor : Form
    {
        //ProfesorController profesores = new ProfesorController();
        public List<Horario> listHorarios = new List<Horario>();
        ActividadController Actividades;
        Actividad Actividad;
        UsuarioController Usuarios;

        public FormModificarProfesor(Actividad actividad, UsuarioController UsuariosC, ActividadController ActividadesC)
        {
            InitializeComponent();
            Usuarios = UsuariosC;
            Actividades = ActividadesC;
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
            this.comboBoxProfesor.SelectedItem = Usuarios.GetUsuario(Actividad.Profesor.Dni);

            //horarios
            this.listHorarios = Actividad.Horarios;
        }

        private void buttonAgregarHorario_Click(object sender, EventArgs e)
        {
            DateTime horarioInicio = this.dateTimePickerHorarioInicio.Value;
            DateTime horarioFin = this.dateTimePickerHorarioFin.Value;

            Horario horarioActividad = new Horario(horarioInicio, horarioFin);
            listHorarios.Add(horarioActividad);
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxId.Text);
            string desc = this.textBoxDesc.Text;
            double costo = double.Parse(this.textBoxCosto.Text);
            int CantMax = int.Parse(this.textBoxCantMax.Text);
            Profesor profesor = (Profesor)this.comboBoxProfesor.SelectedItem;
            this.Actividades.ModificarActividad(id, CantMax, desc, costo, profesor, this.listHorarios);
            this.Close();
        }
    }
}
