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
    public partial class frmAdministrarGestores : Form
    {

        //SE AGREGO 

        private frmPerfilAdministrador var_formPerfilAdmin;



        public frmAdministrarGestores()
        {
            InitializeComponent();
        }

        public frmAdministrarGestores(frmPerfilAdministrador formPerfilAdmin)
        {
            var_formPerfilAdmin = formPerfilAdmin;
            InitializeComponent();
        }

        private void frmAdministrarGestores_Load(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
            //var_formPerfilAdmin.LblBienvenido.Visible = true;
            //var_formPerfilAdmin.PanelAviso.Visible = true;

           
           
        }

        private void frmAdministrarGestores_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.var_formPerfilAdmin.LblBienvenido.Visible = true;
            //this.var_formPerfilAdmin.PanelAviso.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            //var_formPerfilAdmin.LblBienvenido.Visible = true;
            //var_formPerfilAdmin.PanelAviso.Visible = true;
        }
    }
}
