using System;
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
        }

        public void SetCuentaCorriente(CuentaCorriente cc)
        {
            this.CuentaCorriente = cc;
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
                return new List<RegistroActividad>();

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
        public bool AsignarActividad(Actividad actividad)
        {
            RegistroActividad ra = new RegistroActividad(DateTime.Now, actividad);

            ArrayList datos = new ArrayList();
            datos.Add(this.Dni);
            datos.Add(actividad.Id);
            datos.Add(DateTime.Now);

            bool todoBien = false;

            if (actividad != null)
            {
                todoBien = DatosBd.GuardarRegistroActividad(datos);
                if (todoBien)
                    this.RegistroActividades.Add(ra);
            }
            return todoBien;
        }

        /// <summary>
        /// Le asigna una actividad al socio
        /// </summary>
        public void AsignarActividad(Actividad actividad, DateTime fecha)
        {
            RegistroActividad ra = new RegistroActividad(fecha, actividad);
            this.RegistroActividades.Add(ra);
        }

        /// <summary>
        /// Desvincula una actividad del socio
        /// </summary>
        public void DesvincularActividad(RegistroActividad registroActividad)
        {
            this.RegistroActividades.Remove(registroActividad);
            DatosBd.EliminarRegistroActividad(this.Dni, registroActividad.Actividad.Id, registroActividad.Fecha);
        }
        public RegistroActividad GetRegistroActividadPorIndex(int i)
        {
            return RegistroActividades[i];
        }

        public bool ActividadRepetida(Actividad actividad)
        {
            string desc = actividad.Descripcion;
            bool estado = false;

            foreach (RegistroActividad rActividad in this.RegistroActividades)
                if (rActividad.Actividad.Descripcion == desc)
                    estado = true;
            
            return estado;
        }
    }
}
