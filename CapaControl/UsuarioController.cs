﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Collections;

namespace CapaControl
{

    public enum EUsuario
    {
        Administrador = 0,
        Profesor = 1,
        SocioClub = 2,
        SocioActividades = 3
    }

    public class UsuarioController
    {
        private List<Usuario> ListaUsuarios;

        public UsuarioController()
        {
            ListaUsuarios = new List<Usuario>();
            this.RecuperarAdministrador();
            this.RecuperarSocio();
            this.RecuperarProfesor();
        }

        //ADD//
        public bool AddSocioClub(int dni, string nombre, string clave, double cuota)
        {
            SocioClub socio = new SocioClub(dni, nombre, clave, cuota);
            bool todoBien = false;

            if(socio != null)
            {
                todoBien = DatosBd.GuardarSocio(socio.PasarARelacional());
                if(todoBien)
                    this.ListaUsuarios.Add(socio);
            }
            return todoBien;           
        }
        public bool AddSocioActividades(int dni, string nombre, string clave)
        {
            SocioActividades socio = new SocioActividades(dni, nombre, clave);
            bool todoBien = false;

            if (socio != null)
            {
                todoBien = DatosBd.GuardarSocio(socio.PasarARelacional());
                if (todoBien)
                    this.ListaUsuarios.Add(socio);
            }
            return todoBien;
        }
        public bool AddProfesor(int dni, string nombre, string clave)
        {
            Profesor profesor = new Profesor(dni, nombre, clave);
            bool todoBien = false;

            if (profesor != null)
            {
                todoBien = DatosBd.GuardarProfesor(profesor.PasarARelacional());
                if (todoBien)
                    this.ListaUsuarios.Add(profesor);
            }
            return todoBien;
        }
        public bool AddAdministrador(int dni, string nombre, string clave)
        {
            Administrador admin = new Administrador(dni, nombre, clave);
            bool todoBien = false;

            if (admin != null)
            {
                todoBien = DatosBd.GuardarAdministrador(admin.PasarARelacional());
                if (todoBien)
                    this.ListaUsuarios.Add(admin);
            }
            return todoBien;
        }

        //GET, REMOVE//
        public Usuario GetUsuario(int dni)
       {
            return ListaUsuarios.Find(u => u.Dni == dni);
        }
        public void RemoveUsuario(int dni)
        {
            object value = GetUsuario(dni);
            Type usuario = value.GetType();

            if (usuario.Equals(typeof(SocioActividades)))
                DatosBd.EliminarSocio(dni);
            else if (usuario.Equals(typeof(SocioClub)))
                DatosBd.EliminarSocio(dni);
            else if (usuario.Equals(typeof(Profesor)))
                DatosBd.EliminarProfesor(dni);

            ListaUsuarios.Remove(GetUsuario(dni));
        }

        //VALIDAR//
        public bool ValidarCredenciales(int dni, string clave)
        {
            Usuario u = null;

            if ((u = GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;

            return true;
        }

        //GET LIST//
        public List<Usuario> MostrarLista()
        {
            return ListaUsuarios;
        }
        public List<Usuario> MostrarLista(Type filterType)
        {
            List<Usuario> result = new List<Usuario>();

            if (filterType == typeof(Socio))
                result = MostrarLista(typeof(SocioActividades)).Concat(MostrarLista(typeof(SocioClub))).Cast<Usuario>().ToList();          
            else
            {
                foreach (var u in ListaUsuarios)
                    if (u.GetType() == filterType)
                        result.Add(u);
            }
            return result;
        }

        public void GenerarDeuda()
        {
            foreach (Socio socio in this.MostrarLista(typeof(Socio)))
                socio.GenerarDeuda();
        }

        //BASE DE DATOS ACCESS

        public static void PonerPathABaseAccess(string l)
        {
            DatosBd.PonerPathBaseAccess(l);
        }
        public void RecuperarRegistroActividades(ActividadController actividadController)
        {
            foreach (Socio socio in MostrarLista(typeof(Socio)))
            {
                int idActividad;
                DateTime fecha;
                ArrayList datosSocios = DatosBd.RecuperarRegistroActividades(socio.Dni);

                for (int i = 0; i <= datosSocios.Count - 2; i = i + 2)
                {
                    idActividad = int.Parse(datosSocios[i].ToString());
                    fecha = DateTime.Parse(datosSocios[i + 1].ToString());

                    socio.AsignarActividad(actividadController.GetActividad(idActividad), fecha);
                }
            }
        }
        public void RecuperarSocio()
        {
            int dni;
            string nombre;
            string clave;
            double cuota;
            ArrayList datosSocios = DatosBd.RecuperarSocios();

            for (int i = 0; i <= datosSocios.Count - 4; i = i + 4)
            {
                dni = int.Parse(datosSocios[i].ToString());
                nombre = datosSocios[i + 1].ToString();
                clave = datosSocios[i + 2].ToString();
                cuota = double.Parse(datosSocios[i + 3].ToString());
                
                Socio s;

                if(cuota > 0)
                    s = new SocioClub(dni, nombre, clave, cuota);
                else
                    s = new SocioActividades(dni, nombre, clave);

                ListaUsuarios.Add(s);

                ArrayList datosCC = DatosBd.RecuperarCuentaCorriente(dni);
                double saldo = 0;
                for (int j = 0; j <= datosCC.Count - 5; j += 5)
                    saldo += double.Parse(datosCC[j + 3].ToString());
                s.SetCuentaCorriente(new CuentaCorriente(s, saldo));
            }
        }

        public void RecuperarAdministrador()
        {
            int dni;
            string nombre;
            string clave;
            ArrayList datosAdministradores = DatosBd.RecuperarAdministrador();

            for (int i = 0; i <= datosAdministradores.Count - 3; i = i + 3)
            {
                dni = int.Parse(datosAdministradores[i].ToString());
                nombre = datosAdministradores[i + 1].ToString();
                clave = datosAdministradores[i + 2].ToString();

                ListaUsuarios.Add(new Administrador(dni, nombre, clave));
            }
        }

        public void RecuperarProfesor()
        {
            int dni;
            string nombre;
            string clave;
            ArrayList datosProfesores = DatosBd.RecuperarProfesor();

            for (int i = 0; i <= datosProfesores.Count - 3; i = i + 3)
            {
                dni = int.Parse(datosProfesores[i].ToString());
                nombre = datosProfesores[i + 1].ToString();
                clave = datosProfesores[i + 2].ToString();

                ListaUsuarios.Add(new Profesor(dni, nombre, clave));
            }
        }
    }
}
