using RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIWeb
{
    public partial class AltaPersona : System.Web.UI.Page
    {
        Administradora admin;
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        public void recuperarAdmin()
        {
            admin = (Administradora)Session["administra"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            recuperarAdmin();
            Persona per = null;
            try
            {
                int d = int.Parse(TextBox2.Text.Trim());
                string n = TextBox3.Text.Trim();
                per = new Persona(d, n);
               if(admin.ponerPersona(per))
                Response.Redirect("Inicio.aspx");
               else
                    Label1.Text = "Error al crear la persona. Verifique que el numero de DNI no esté repetido.";


            }
            catch (Exception ex)
            {
                Label1.Text = "Error al crear la persona: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}