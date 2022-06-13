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
        Socio socioLogueado = null;
        string LugarBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Recuperar datos
                string pathAux = Server.MapPath("/Inicio.aspx");
                string[] path = pathAux.Split('\\');
                path[path.Length - 1] = "bin";
                path[path.Length - 2] = "ClubDeportivo";

                string pathFinal = "";
                foreach (string s in path)
                    pathFinal += s + "\\";

                pathFinal += "Debug" + "\\";

                LugarBase = pathFinal;

                //C:\Users\Bruno\source\repos\EnanoFurtivo\ClubDeportivo\UIWeb\Inicio.aspx

                UsuarioController.PonerPathABaseAccess(LugarBase);
                Usuarios = new UsuarioController();
                Actividades = new ActividadController(Usuarios);
                Usuarios.RecuperarRegistroActividades(Actividades);
                Session["ucontrol"] = Usuarios;
                Session["acontrol"] = Actividades;
            }
            else
                recuperar();

            //Leer usuario y clave de la sesion
            if (Session["socio"] != null)
            {
              //  int dni;

               // string dniStr = Session["dni"].ToString();
                socioLogueado = (Socio)Session["socio"];

              //  LabelError.Text = "hola" +" "+ dniStr + " " + clave;


               // if (!ValidarDni(dniStr, out dni))
                //    return;

               // if (!ValidarClave(clave))
                  //  return;

               // if (Usuarios.ValidarCredenciales(dni, clave) == true)
                  //  socioLogueado = (Socio)Usuarios.GetUsuario(dni);
                
            }

            //Mostrar/ocultar lista inscriptas, botones y label deuda
            //Llenar listas y completar deuda

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
        public void recuperar()
        {
            Usuarios = (UsuarioController)Session["ucontrol"];
            Actividades = (ActividadController)Session["acontrol"];
        }
        private bool ValidarDni(string dniStr, out int dni)
        {
            if (dniStr == "")
            {
                LabelError.Text = "    Se esperaba un dni";
                dni = -1;
                return false;
            }

            if (!int.TryParse(dniStr, out dni))
            {
                LabelError.Text = "    El dni debe ser numerico";
                dni = -1;
                return false;
            }

            return true;
        }
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                LabelError.Text = "    Se esperaba una clave";
                return false;
            }

            return true;
        }
        public void refrescarLista(List<Actividad> actividades, ListBox listBox)
        {
            listBox.Items.Clear();
            for(int i=0;i<actividades.Count; i++)
                listBox.Items.Add(actividades[i].ToString());
        }
        public void refrescarLista(List<RegistroActividad> actividades, ListBox listBox)
        {
            listBox.Items.Clear();
            for (int i = 0; i < actividades.Count; i++)
                listBox.Items.Add(actividades[i].ToString());
        }
        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
           // recuperar();
            string dniStr = this.TextBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string clave = TextBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            if (Usuarios.ValidarCredenciales(dni, clave) == true)
            {
                //Session["dni"] = dniStr;
                Session["socio"] = Usuarios.GetUsuario(dni);
                Response.Redirect(Request.RawUrl);
            }
            else
                LabelError.Text = "    El dni o clave ingresada es incorrecta" + dni.ToString() +" "+ clave;
        }
        protected void ButtonInscribirse_Click(object sender, EventArgs e)
        {

        }
        protected void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            //RegistroActividad ra = (RegistroActividad)listBoxInscriptas.SelectedItem;
            //s.DesvincularActividad(ra);
            //RefrescarLista(false, true);
        }
    }
}