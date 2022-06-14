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
                    ListBoxInscriptas.Visible = true;
                    ButDesasignar.Visible = true;
                    ButInscribir.Visible = true;
                    Label1.Visible = true;

                    refrescarLista(socioLogueado.GetActividades(), ListBoxInscriptas);
                    double saldo = double.Parse(socioLogueado.GetSaldo().ToString());
                    string saldoStr = (saldo < 0) ? "    Deuda: " : "    Saldo a favor: ";
                    saldo = System.Math.Abs(saldo);


                    Label1.Text = saldoStr + "$" + saldo.ToString();
                }
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
            for (int i = 0; i < actividades.Count; i++)
                listBox.Items.Add(actividades[i].ToString());
        }
        protected void ButtonInscribirse_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            recuperar();

            if (ListBoxInscriptas.SelectedItem != null)
            {
                string textoRegistroActividad = ListBoxInscriptas.SelectedValue;
                int lugarGuion = textoRegistroActividad.IndexOf("-");
                string nombre = textoRegistroActividad.Substring(0, lugarGuion-1);
                Actividad act = Actividades.GetActividad(nombre);
                if (act != null)
                {
                    RegistroActividad ra = Usuarios.RecuperarRegistroActividad(act, socioLogueado);
                    socioLogueado.DesvincularActividad(ra);
                }
                ListBoxInscriptas.ClearSelection();
                Label2.Text = "    Baja de actividad realizada";
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}