using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControl;
using CapaNegocio;

namespace UIWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        UsuarioController Usuarios;
        ActividadController Actividades;
        Socio socioLogueado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recuperar();
                refrescarLista(Actividades.MostrarLista(), ListBoxActividades);

                if (socioLogueado != null)
                {
                    refrescarLista(socioLogueado.GetActividades(), ListBoxInscriptas);
                    double saldo = double.Parse(socioLogueado.GetSaldo().ToString());
                    string saldoStr = (saldo < 0) ? "    Deuda: " : "    Saldo a favor: ";
                    saldo = System.Math.Abs(saldo);


                    Label1.Text = saldoStr + "$" + saldo.ToString();
                }

                this.LabelBienvenida.Text = "Bienvenido/a de nuevo " + ((Usuario)socioLogueado).Nombre;
            }
        }
        public void recuperar()
        {
            Usuarios = (UsuarioController)Session["ucontrol"];
            Actividades = (ActividadController)Session["acontrol"];
            socioLogueado = (Socio)Session["socio"];
        }
        public void refrescarLista(List<Actividad> actividades, ListBox listBox)
        {
            listBox.Items.Clear();
            recuperar();
            for(int i=0;i<actividades.Count; i++)
                listBox.Items.Add(actividades[i].ToString());
        }
        public void refrescarLista(List<RegistroActividad> actividades, ListBox listBox)
        {
            listBox.Items.Clear();
            recuperar();
            if (actividades != null)
            {
                for (int i = 0; i < actividades.Count; i++)
                    listBox.Items.Add(actividades[i].ToString());
            }
        }
        protected void ButtonInscribirse_Click(object sender, EventArgs e)
        {
            recuperar();

            if(ListBoxActividades.SelectedIndex > -1 && !socioLogueado.ActividadRepetida(Actividades.GetActividadPorIndex(ListBoxActividades.SelectedIndex)))
            {
                socioLogueado.AsignarActividad(Actividades.GetActividadPorIndex(ListBoxActividades.SelectedIndex));

                ListBoxActividades.ClearSelection();
                refrescarLista(socioLogueado.GetActividades(), ListBoxInscriptas);
                Label2.Text = "    Inscripcion realizada";
            }
            else
            {
                ListBoxInscriptas.ClearSelection();
                refrescarLista(socioLogueado.GetActividades(), ListBoxInscriptas);
                Label2.Text = "    Ya estas inscripto en esta actividad";
            }

        }
        protected void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            recuperar();

            if (ListBoxInscriptas.SelectedIndex > -1)
            {
                socioLogueado.DesvincularActividad(socioLogueado.GetRegistroActividadPorIndex(ListBoxInscriptas.SelectedIndex));

                ListBoxInscriptas.ClearSelection();
                refrescarLista(socioLogueado.GetActividades(), ListBoxInscriptas);
                Label2.Text = "    Baja de actividad realizada";

            }
        }

        protected void ButCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }
    }
}