﻿using System;
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

        private void buttonAgregarActividad_Click(object sender, EventArgs e)
        {
            string idStr = this.textBoxId.Text;
            int id;
            if (!ValidarId(idStr, out id))
                return;

            string desc = this.textBoxDesc.Text;
            if (!ValidarDescripcion(desc))
                return;

            string costoStr = this.textBoxCosto.Text;
            double costo;
            if (!ValidarCosto(costoStr, out costo))
                return;

            string cantMaxStr = this.textBoxCantMax.Text;
            int cantMax;
            if (!ValidarCantMax(cantMaxStr, out cantMax))
                return;

            string horario = this.textBoxHorario.Text;
            if (!ValidarHorario(horario))
                return;

            Profesor profesor = (Profesor)this.comboBoxProfesor.SelectedItem;
            Actividades.AgregarActividad(id, desc, costo, cantMax, profesor, horario);
            ResultId = id;
            this.Close();
        }
        private bool ValidarDescripcion(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Se esperaba una descripcion", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarHorario(string horario)
        {
            if (horario == "")
            {
                MessageBox.Show("Se esperaba un dia y horario", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarId(string idStr, out int id)
        {
            if (idStr == "")
            {
                MessageBox.Show("Se esperaba un id", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                id = -1;
                return false;
            }

            if (!int.TryParse(idStr, out id))
            {
                MessageBox.Show("El id debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                id = -1;
                return false;
            }

            return true;
        }
        private bool ValidarCosto(string costoStr, out double costo)
        {
            if (costoStr == "")
            {
                MessageBox.Show("Se esperaba un costo", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                costo = -1;
                return false;
            }

            if (!double.TryParse(costoStr, out costo))
            {
                MessageBox.Show("El costo debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                costo = -1;
                return false;
            }

            return true;
        }
        private bool ValidarCantMax(string cantMaxStr, out int cantMax)
        {
            if (cantMaxStr == "")
            {
                MessageBox.Show("Se esperaba una cantidad de participantes", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cantMax = -1;
                return false;
            }

            if (!int.TryParse(cantMaxStr, out cantMax))
            {
                MessageBox.Show("La cantidad de participantes debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cantMax = -1;
                return false;
            }

            return true;
        }
    }
}
