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
                
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            int res = Program.DBController.cambiarContrasenaToken(txtCorreo.Text,txtcontraseña.Text,txttoken.Text);
            if (res == 0)
            {
                MessageBox.Show("No c logró :'v");
                frmLogin formIni = new frmLogin();
                formIni.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("C logró :'3");
                frmLogin formIni = new frmLogin();
                formIni.Show();
                this.Visible = false;
            }
        }
    }
}
