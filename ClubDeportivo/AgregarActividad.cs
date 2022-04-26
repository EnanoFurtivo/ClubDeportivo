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
    public partial class FormAgregarActividad : Form
    {
        List<Horario> ListaHorarios = new List<Horario>();
        ActividadController Actividades;
        UsuarioController Usuarios;
        public int ResultId = -1;

        public FormAgregarActividad(UsuarioController UsuarioC, ActividadController ActividadesC)
        {
            InitializeComponent();
            Actividades = ActividadesC;
            Usuarios = UsuarioC;
            this.comboBoxProfesor.DataSource = Usuarios.MostrarLista(typeof(Profesor));
        }

        private void buttonAgregarHorario_Click(object sender, EventArgs e)
        {
            DateTime horarioInicio = this.dateTimePickerHorarioInicio.Value;
            DateTime horarioFin = this.dateTimePickerHorarioFin.Value;

            Horario horarioActividad = new Horario(horarioInicio, horarioFin);
            ListaHorarios.Add(horarioActividad);
        }

        private void buttonAgregarActividad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxId.Text);
            string desc = this.textBoxDesc.Text;
            double costo = double.Parse(this.textBoxCosto.Text);
            int CantMax = int.Parse(this.textBoxCantMax.Text);
            Profesor profesor = (Profesor)this.comboBoxProfesor.SelectedItem;
            Actividades.AgregarActividad(id, desc, costo, CantMax, profesor, ListaHorarios);
            ResultId = id;
            this.Close();
        }
    }
}
