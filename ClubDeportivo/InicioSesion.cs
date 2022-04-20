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
        UsuarioController usuarios;

        public FormLogin()
        {
            InitializeComponent();
            usuarios = UsuarioController.Recuperar(); 
            this.comboBoxTipoUsuario.DataSource = Enum.GetValues(typeof(EUsuario));
            UsuarioController controller;
            int i = 0;

            controller = new AdministradorController();
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;

            controller = new SocioClubController();
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;


            controller = new SocioActividadesController();
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;


            controller = new ProfesorController();
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
            controller.AddUsuario(i, "lol" + i, "dea"); i++;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.dni = int.Parse(textBoxDni.Text);
            this.clave = textBoxClave.Text;

            EUsuario tipoUsuario = (EUsuario)this.comboBoxTipoUsuario.SelectedItem;

            UsuarioController controller;
            switch (tipoUsuario)
            {
                case EUsuario.Administrador:
                    //controller = new AdministradorController();

                    if (controller.ValidarCredenciales(dni, clave) == true)
                    {
                        FormAdministrador form = new FormAdministrador(controller, dni);
                        this.Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;


                case EUsuario.Profesor:
                    //controller = new ProfesorController();
                    
                    if (controller.ValidarCredenciales(dni, clave) == true)
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
                   // controller = new SocioClubController();

                    if (controller.ValidarCredenciales(dni, clave) == true)
                    {
                        FormSocioClub form = new FormSocioClub();
                        this.Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("El dni o clave ingresada es incorrecta");

                    break;

                case EUsuario.SocioActividades:
                    //controller = new SocioActividadesController();

                    if (controller.ValidarCredenciales(dni, clave) == true)
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
            this.Hide();
            registrar.ShowDialog();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (usuarios.Guardar())
                    MessageBox.Show("GUARDADO OK");
                else
                    MessageBox.Show("ERROR AL GUARDAR");
            }
        }
    }
}
