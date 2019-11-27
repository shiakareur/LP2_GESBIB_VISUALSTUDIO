using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_GesBib_Cliente.ServicioJava;

namespace TA_GesBib_Cliente
{
    public partial class frmCambiarClaveConfig : Form
    {
        ServicioJava.usuario var_usuario;
        public frmCambiarClaveConfig(ServicioJava.usuario _user)
        {
            InitializeComponent();
            var_usuario = _user;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validar:
            if (txtClaveNueva.Text != txtClaveNueva2.Text)
            {
                MessageBox.Show("¡Las claves tienen que ser iguales!");
            }
            else
            {
                Program.DBController.cambiarContrasenaConfig(var_usuario.id,txtClaveNueva.Text);
                MessageBox.Show("¡La clave se guardó con éxito!");
            }
        }
    }
}
