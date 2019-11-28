using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_GesBib_Cliente
{
    public partial class frmCambiarClave : Form
    {
        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();
        private frmRecuperarClave var_recu;
                
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        public frmCambiarClave(frmRecuperarClave perfRecu)
        {
            var_recu = perfRecu;           
            InitializeComponent();
            this.txtCorreo.Text = var_recu.TxtcorreoREC.Text;

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            int res = Program.DBController.cambiarContrasenaToken(txtCorreo.Text,txtcontraseña.Text,txttoken.Text);
            if (res == 0)
            {
                MessageBox.Show("No se logró restablecer la contraseña");
                frmLogin formIni = new frmLogin();
                formIni.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Contraseña restablecida");
                frmLogin formIni = new frmLogin();
                formIni.Show();
                this.Visible = false;
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.var_recu.Visible = true;
        }
    }
}
