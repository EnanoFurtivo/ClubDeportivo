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
        
        //Para Access 2000-2003
        private static string LugarBase;
        private static string Str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\Persistencia\basePersonas.mdb
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        //Para todos
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
                /*
                List<ArrayList> datosP = new List<ArrayList>();
                ArrayList persona;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    persona = new ArrayList();
                    
                    for(int j=0;j<2;j++)
                        persona.Add(Ds.Tables[0].Rows[i].ItemArray[j].ToString());

                    datosP.Add(persona);

                }
                */
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
                /*
                List<ArrayList> datosP = new List<ArrayList>();
                ArrayList persona;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    persona = new ArrayList();
                    
                    for(int j=0;j<2;j++)
                        persona.Add(Ds.Tables[0].Rows[i].ItemArray[j].ToString());

                    datosP.Add(persona);

                }
                */
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
                /*
                List<ArrayList> datosP = new List<ArrayList>();
                ArrayList persona;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    persona = new ArrayList();
                    
                    for(int j=0;j<2;j++)
                        persona.Add(Ds.Tables[0].Rows[i].ItemArray[j].ToString());

                    datosP.Add(persona);

                }
                */
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
    }
}
