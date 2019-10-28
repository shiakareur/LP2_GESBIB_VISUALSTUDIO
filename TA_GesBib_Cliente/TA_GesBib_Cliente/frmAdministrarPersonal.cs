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
    public partial class frmAdministrarPersonal : Form
    {

        //SE AGREGO 

        private frmPerfilAdministrador var_formPerfilAdmin;
        public frmAdministrarPersonal()
        {
            InitializeComponent();
        }

        public frmAdministrarPersonal(frmPerfilAdministrador formPerfilAdmin)
        {
            var_formPerfilAdmin = formPerfilAdmin;
            InitializeComponent();
        }

        private void frmAdministrarPersonal_Load(object sender, EventArgs e)
        {   
           
            //this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //var_formPerfilAdmin.LblBienvenido.Visible = true;
            //var_formPerfilAdmin.PanelAviso.Visible = true;
        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
