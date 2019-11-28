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
        //bytys
        private frmLogin var_login;

        public TextBox TxtcorreoREC { get => txtcorreoREC; set => txtcorreoREC = value; }
        //bytys

        public frmRecuperarClave()
        {
            InitializeComponent();
        }

        //bytys
        public frmRecuperarClave(frmLogin perfLogin)
        {
            var_login = perfLogin;
            InitializeComponent();
        }
        //bytys



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
                frmCambiarClave formCC = new frmCambiarClave(this);
                formCC.Show();
                this.Visible = false;
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.var_login.Visible = true;
        }
    }
}
