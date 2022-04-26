using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DatosUsuarios
    {
        public static bool Guardar(object o)
        {
            bool ok = false;
            
            try
            {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream miArchivo = new FileStream("Usuarios.dat", FileMode.Create);
            bf.Serialize(miArchivo, o);
            miArchivo.Close();
            ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ok = false;
            }
            return ok;
        }

        public static object Recuperar()
        {
            try
            {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream miArchivo = new FileStream("Usuarios.dat", FileMode.Open);
            object o = bf.Deserialize(miArchivo);
            miArchivo.Close();
            return o;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
               return null;
            }
            
        }
    }
}
