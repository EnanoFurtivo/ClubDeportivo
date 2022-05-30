using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class DatosBd
    {       
        private static string LugarBase;
        private static string Str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        private static DataSet Ds;

        public static void PonerPathBaseAccess(string l)
        {
            LugarBase = l + @"\ClubDeportivo.accdb";
            DatosBd.Str += LugarBase;
        }

        public static bool GuardarSocio(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 4)
            {
                try
                {
                    int dni = int.Parse(datos[0].ToString());
                    string nombre = datos[1].ToString();
                    string clave = datos[2].ToString();
                    double cuota = int.Parse(datos[3].ToString());
                    string strCmd = "INSERT INTO socio(dni, nombre, clave, cuota) VALUES ('" + dni + "','" + nombre + "','" + clave + "','" + cuota + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarSocios()
        {

            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM socio ORDER BY dni";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;


        }
        public static void EliminarSocio(int dni)
        {
            try
            {
                string strCmd = "DELETE FROM socio WHERE dni=" + dni + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool GuardarAdministrador(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 3)
            {
                try
                {
                    int dni = int.Parse(datos[0].ToString());
                    string nombre = datos[1].ToString();
                    string clave = datos[2].ToString();
                    string strCmd = "INSERT INTO administrador(dni, nombre, clave) VALUES ('" + dni + "','" +  nombre + "','" + clave + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarAdministrador()
        {

            ArrayList datos = new ArrayList();

            try
            {
                
                
                string strCmd = "SELECT * FROM administrador ORDER BY dni";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;


        }
        public static void EliminarAdministrador(int dni)
        {
            try
            {
                string strCmd = "DELETE FROM administrador WHERE dni=" + dni + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool GuardarProfesor(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 3)
            {
                try
                {
                    int dni = int.Parse(datos[0].ToString());
                    string nombre = datos[1].ToString();
                    string clave = datos[2].ToString();
                    string strCmd = "INSERT INTO profesor(dni, nombre, clave) VALUES ('" + dni + "','" + nombre + "','" + clave + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarProfesor()
        {

            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM profesor ORDER BY dni";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;


        }
        public static void EliminarProfesor(int dni)
        {
            try
            {
                string strCmd = "DELETE FROM profesor WHERE dni=" + dni + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool GuardarActividad(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 6)
            {
                try
                {
                    int id = int.Parse(datos[0].ToString());
                    string desc = datos[1].ToString();
                    double costo = double.Parse(datos[2].ToString());
                    int cantMaxParticipantes = int.Parse((datos[3].ToString()).ToString());
                    string horario = datos[4].ToString();
                    int dniProfesor = int.Parse(datos[5].ToString());
                    string strCmd = "INSERT INTO actividad(id, descripcion, costo, cantMaxParticipantes, horario, dniProfesor) VALUES ('" + id + "','" + desc + "','" + costo + "','" + cantMaxParticipantes + "','" + horario + "','" + dniProfesor + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }

        public static bool ModificarActividad(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 6)
            {
                try
                {
                    int id = int.Parse(datos[0].ToString());
                    string desc = datos[1].ToString();
                    double costo = double.Parse(datos[2].ToString());
                    int cantMaxParticipantes = int.Parse((datos[3].ToString()).ToString());
                    string horario = datos[4].ToString();
                    int dniProfesor = int.Parse(datos[5].ToString());
                    string strCmd = "UPDATE actividad set descripcion='" + desc + "' ,costo='" + costo + "' ,cantMaxParticipantes='" + cantMaxParticipantes + "' ,horario='" + horario + "' ,dniProfesor='" + dniProfesor + "' WHERE id=" + id + "";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarActividad()
        {

            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM actividad ORDER BY id";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }
        public static void EliminarActividad(int id)
        {
            try
            {
                string strCmd = "DELETE FROM actividad WHERE id=" + id + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }
        public static bool GuardarRegistroActividad(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 3)
            {
                try
                {
                    int dniSocio = int.Parse(datos[0].ToString());
                    int idActividad = int.Parse(datos[1].ToString());
                    DateTime fecha = DateTime.Parse(datos[2].ToString());
                    string fechaStr = fecha.Month.ToString() + "/" + fecha.Day.ToString() + "/" + fecha.Year.ToString();
                    string strCmd = "INSERT INTO registroActividad(dniSocio, idActividad, fecha) VALUES ('" + dniSocio + "','" + idActividad + "',#" + fechaStr + "#)";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarRegistroActividades(int dni)
        {

            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM registroActividad WHERE dniSocio=" + dni;
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }
        public static void EliminarRegistroActividad(int dniSocio, int idActividad, DateTime fecha)
        {
            try
            {
                string fechaStr = fecha.Month.ToString()+"/"+fecha.Day.ToString() +"/"+fecha.Year.ToString();
                string strCmd = "DELETE FROM registroActividad WHERE dniSocio = " + dniSocio + " AND idActividad = " + idActividad + " AND fecha =#" + fechaStr + "#";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool GuardarCuentaCorriente(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 4)
            {
                try
                {
                    int dniSocio = int.Parse(datos[0].ToString());
                    DateTime fecha = DateTime.Parse(datos[1].ToString());
                    string fechaStr = fecha.Month.ToString() + "/" + fecha.Day.ToString() + "/" + fecha.Year.ToString();
                    double monto = double.Parse(datos[2].ToString());
                    string descripcion = datos[3].ToString();
                    string strCmd = "INSERT INTO cuentaCorriente(dniSocio, fecha, monto, descripcion) VALUES (" + dniSocio + ",#" + fechaStr + "#," + monto + ",'" + descripcion + "')";
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;

        }
        public static ArrayList RecuperarCuentaCorriente(int dni)
        {

            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM cuentaCorriente WHERE dniSocio=" + dni;
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }
    }
}
