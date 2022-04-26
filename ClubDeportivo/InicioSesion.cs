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

namespace ClubDeportivo
{
    public partial class FormLogin : Form
    {
        private int dni;
        private string clave;
        UsuarioController Usuarios = new UsuarioController();
        ActividadController Actividades = new ActividadController();

        public FormLogin()
        {
            InitializeComponent();
            Usuarios = UsuarioController.Recuperar(); 
            Actividades = ActividadController.Recuperar();
            int i = 0;
            Usuarios.AddAdministrador(i, "Bruno", "pass"); i++;

            /*//controller = new AdministradorController();
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddAdministrador(i, "unusuario" + i, "pass"); i++;

            // controller = new SocioClubController();
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            Usuarios.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;


            //controller = new SocioActividadesController();
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddSocioActividades(i, "unusuario" + i, "pass"); i++;


            //controller = new ProfesorController();
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;
            Usuarios.AddProfesor(i, "unusuario" + i, "pass"); i++;

            //Usuarios.Guardar();*/
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.dni = int.Parse(textBoxDni.Text);
            this.clave = textBoxClave.Text;

            if (Usuarios.ValidarCredenciales(dni, clave) == true)
            {
                FormAdministrador form = new FormAdministrador(dni, Usuarios, Actividades);
                //this.Hide();
                form.ShowDialog();
            }
            else
                MessageBox.Show("El dni o clave ingresada es incorrecta");
        }

       private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {           
            if (Usuarios.Guardar()&& Actividades.guardar())
                MessageBox.Show("GUARDADO OK");
            else
                MessageBox.Show("ERROR AL GUARDAR");            
        }
    }
}
