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
    public partial class FormAgregarProfesor : Form
    {
        //ProfesorController profesores = new ProfesorController();
        public List<Horario> listHorarios = new List<Horario>();
        ActividadController actividad = new ActividadController();
        UsuarioController Usuarios;

        public FormAgregarProfesor()
        {
            InitializeComponent();
            this.comboBoxProfesor.DataSource = Usuarios.MostrarLista(typeof(Profesor));
        }

        private void buttonAgregarHorario_Click(object sender, EventArgs e)
        {
            DateTime horarioInicio = this.dateTimePickerHorarioInicio.Value;
            DateTime horarioFin = this.dateTimePickerHorarioFin.Value;

            Horario horarioActividad = new Horario(horarioInicio, horarioFin);
            listHorarios.Add(horarioActividad);
        }

        private void buttonAgregarActividad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxId.Text);
            string desc = this.textBoxDesc.Text;
            double costo = double.Parse(this.textBoxCosto.Text);
            int CantMax = int.Parse(this.textBoxCantMax.Text);
            Profesor profesor = (Profesor)this.comboBoxProfesor.SelectedItem;
            this.actividad.AgregarActividad(id, desc, costo, CantMax, profesor, this.listHorarios);
            this.Close();
        }
    }
}
