﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaDatos;

namespace CapaNegocio
{
    public abstract class Socio : Usuario
    {
        protected bool Estado;
        protected List<RegistroActividad> RegistroActividades;
        protected CuentaCorriente CuentaCorriente;

        public Socio(int dni, string nombre, string clave) : base(dni, nombre, clave)
        {
            this.Estado = true;
            this.RegistroActividades = new List<RegistroActividad>();
            this.CuentaCorriente = new CuentaCorriente(this);
        }

        /// <summary>
        /// Devuelve las actividades del mes actual.
        /// Si no hay registros de actividad devuelve null.
        /// </summary>
        public List<RegistroActividad> GetActividades()
        {
            if (this.RegistroActividades.Count < 1)
                return null;

            List<RegistroActividad> resultList = new List<RegistroActividad>();

            int mes = DateTime.Now.Month;

            foreach (RegistroActividad rActividad in this.RegistroActividades)
                if (rActividad.Fecha.Month == mes) //traer actividades del mes anterior
                    resultList.Add(rActividad);

            return resultList;
        }

        /// <summary>
        /// Devuelve las actividades del mes anterior.
        /// Si no hay registros de actividad devuelve null.
        /// </summary>
        public List<RegistroActividad> GetActividadesMesAnterior()
        {
            if (this.RegistroActividades.Count < 1)
                return null;

            List<RegistroActividad> resultList = new List<RegistroActividad>();

            int mes = DateTime.Now.Month - 1;
            if (mes < 1) mes = 12;

            foreach (RegistroActividad rActividad in this.RegistroActividades)
                if (rActividad.Fecha.Month == mes) //traer actividades del mes anterior
                    resultList.Add(rActividad);

            return resultList;
        }

        public List<RegistroActividad> ActividadesSocio()
        {
            return this.RegistroActividades;
        }

        /// <summary>
        /// Registra un nuevo pago para el socio
        /// </summary>
        public void RegistrarPago(string descripcion, double monto)
        {
            this.CuentaCorriente.RegistrarPago(descripcion, monto);
        }

        /// <summary>
        /// Obtiene el saldo del socio
        /// </summary>
        public double GetSaldo()
        {
            return this.CuentaCorriente.GetSaldo();
        }

        public abstract void GenerarDeuda();

        /// <summary>
        /// Le asigna una actividad al socio
        /// </summary>
        public void AsignarActividad(Actividad actividad)
        {
            RegistroActividad ra = new RegistroActividad(DateTime.Now, actividad);
            this.RegistroActividades.Add(ra);
        }

        /// <summary>
        /// Desvincula una actividad del socio
        /// </summary>
        public void DesvincularActividad(RegistroActividad registroActividad)
        {
            this.RegistroActividades.Remove(registroActividad);
        }

        //BASE DE DATOS
      /*  public void RecuperarRegistroActividades()
        {
            int idActividad;
            Actividad actividad;
            DateTime fecha;

            ArrayList datosActividad = DatosBd.RecuperarRegistroActividades();

            for (int i = 0; i <= datosActividad.Count - 4; i = i + 4)
            {
                idActividad = int.Parse(datosActividad[i].ToString());
                actividad =
                fecha = (DateTime)datosActividad[i + 3].ToString();

                RegistroActividades.Add(new RegistroActividad(fecha, actividad));
            }
        } */
    }
}
