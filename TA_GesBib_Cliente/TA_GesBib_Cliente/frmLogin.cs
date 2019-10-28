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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //abrir diferentes usuarios
            if (placeHolderUsuario.Text=="Administrador")
            {
                frmPerfilAdministrador formPAdmin = new frmPerfilAdministrador();
                formPAdmin.Visible = true;
                this.Visible = true;
            }
            else
            {
                frmPerfilBibliotecario formBibliotecario = new frmPerfilBibliotecario();
                formBibliotecario.Visible = true;
                this.Visible = true;
            }
            //frmPerfilAdministrador formPAdmin = new frmPerfilAdministrador();
            //formPAdmin.Visible = true;
            //this.Visible = true;


            //frmPerfilBibliotecario formBibliotecario = new frmPerfilBibliotecario();
            //formBibliotecario.Visible = true;
            //this.Visible = true;

        }

        private void placeHolderUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
