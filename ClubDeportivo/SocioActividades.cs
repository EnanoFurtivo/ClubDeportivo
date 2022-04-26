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
    public partial class FormSocioActividades : Form
    {
        UsuarioController Usuarios;
        ActividadController Actividades;
        public FormSocioActividades(UsuarioController UsuariosC, ActividadController ActividadesC)
        {
            InitializeComponent();
            Usuarios = UsuariosC;
            Actividades = ActividadesC;
        }
    }
}
