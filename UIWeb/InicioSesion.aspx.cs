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
    public partial class InicioSesion: System.Web.UI.Page
    {
        UsuarioController Usuarios;
        ActividadController Actividades;
        static string LugarBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recuperar();

                if(LugarBase == null)
                {
                    string pathAux = Server.MapPath("/InicioSesion.aspx");
                    string[] path = pathAux.Split('\\');
                    path[path.Length - 1] = "bin";
                    path[path.Length - 2] = "ClubDeportivo";

                    string pathFinal = "";
                    foreach (string s in path)
                        pathFinal += s + "\\";

                    pathFinal += "Debug" + "\\";

                    LugarBase = pathFinal;

                    UsuarioController.PonerPathABaseAccess(LugarBase);

                    Usuarios = new UsuarioController();

                    Actividades = new ActividadController(Usuarios);
                    Usuarios.RecuperarRegistroActividades(Actividades);

                    Session["ucontrol"] = Usuarios;
                    Session["acontrol"] = Actividades;
                }
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
                LabelDeError.Text = "    Se esperaba un dni";
                dni = -1;
                return false;
            }

            if (!int.TryParse(dniStr, out dni))
            {
                LabelDeError.Text = "    El dni debe ser numerico";
                dni = -1;
                return false;
            }

            return true;
        }
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                LabelDeError.Text = "    Se esperaba una clave";
                return false;
            }

            return true;
        }
        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            recuperar();

            string dniStr = this.TxtBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string clave = this.TxtBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            if (Usuarios.ValidarCredenciales(dni, clave) == true)
            {
                Session["socio"] = Usuarios.GetUsuario(dni);
                TxtBoxDni.Text = string.Empty;
                TxtBoxClave.Text = string.Empty;
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                this.LabelDeError.Text = "    El dni o clave ingresada es incorrecta";
                TxtBoxDni.Text = string.Empty;
                TxtBoxClave.Text = string.Empty;
            }
        }
    }
}