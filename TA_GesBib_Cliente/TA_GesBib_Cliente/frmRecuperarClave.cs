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
    public partial class frmRecuperarClave : Form
    {
        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();       
                
        public frmRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
           int res=  Program.DBController.enviarToken(txtcorreoREC.Text);
            if (res == 0)
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el código");
                frmCambiarClave formCC = new frmCambiarClave();
                formCC.Show();
                this.Visible = false;
            }
        }
    }
}
