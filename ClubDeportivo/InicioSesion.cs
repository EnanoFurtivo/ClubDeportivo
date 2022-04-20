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
            //Usuarios = UsuarioController.Recuperar(); 
            this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(EUsuario));
            //int i = 0;

           /* //controller = new AdministradorController();
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;
            controller.AddAdministrador(i, "unusuario" + i, "pass"); i++;

           // controller = new SocioClubController();
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;
            controller.AddSocioClub(i, "unusuario" + i, "pass", 10); i++;


            //controller = new SocioActividadesController();
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;
            controller.AddSocioActividades(i, "unusuario" + i, "pass"); i++;


            //controller = new ProfesorController();
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;
            controller.AddProfesor(i, "unusuario" + i, "pass"); i++;

            controller.Guardar();*/

            //Usuarios.Guardar();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.dni = int.Parse(textBoxDni.Text);
            this.clave = textBoxClave.Text;

            EUsuario tipoUsuario = (EUsuario)this.comboBoxTipoUsuario.SelectedItem;

            switch (tipoUsuario)
            {
                case EUsuario.Administrador:
                    //Usuarios = new AdministradorController();

                    if (Usuarios.ValidarCredenciales(dni, clave) == true)
                    {
                        FormAdministrador form = new FormAdministrador(dni);
                        this.Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;


                case EUsuario.Profesor:
                    //Usuarios = new ProfesorController();
                    
                    if (Usuarios.ValidarCredenciales(dni, clave) == true)
                    {
                        //COMENTADO EL PROFESOR NO ACCEDE AL SISTEMA SEGUN DIAGRAMA CU//
                        //FormProfesor form = new FormProfesor();
                        //this.Hide();
                        //form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;

                case EUsuario.SocioClub:
                   // Usuarios = new SocioClubController();

                    if (Usuarios.ValidarCredenciales(dni, clave) == true)
                    {
                        FormSocioClub form = new FormSocioClub();
                        this.Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;

                case EUsuario.SocioActividades:
                    //Usuarios = new SocioActividadesController();

                    if (Usuarios.ValidarCredenciales(dni, clave) == true)
                    {
                        FormSocioActividades form = new FormSocioActividades();
                        this.Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;

                default:
                    MessageBox.Show("Error interno del sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro registrar = new FormRegistro();
            //this.Hide();
            registrar.ShowDialog();
        }

       private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (Usuarios.Guardar())
                    MessageBox.Show("GUARDADO OK");
                else
                    MessageBox.Show("ERROR AL GUARDAR");
            }
        }
    }
}
