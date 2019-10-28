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
    public partial class frmPerfilAdministrador : Form
    {
        //public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        //public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }
        //frmAdministrarGestores formAdminGestores = new frmAdministrarGestores();


        public frmPerfilAdministrador()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void btnAdministrarGestores_Click(object sender, EventArgs e)
        {

            //para bloquear acceso a otros botones del menu
            //btnAdministrarPersonal.Enabled = false;
            //btnAdministrarGestores.Enabled = false;

            //Para restringir acceso a otros botones



            //frmAdministrarGestores formAdminGestores = new frmAdministrarGestores();
            frmAdministrarGestores formAdminGestores = new frmAdministrarGestores(this);
            formAdminGestores.MdiParent = this;
            //SE USARÁ ENABLES, NO SHOWDIALOG PORQUE NO FUNCIONA CON MDI :(
            formAdminGestores.Show();

            //formAdminGestores.Visible = true;
     
            //lblBienvenido.Visible = false;
            //panelAviso.Visible = false;
        }

        private void frmPerfilAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnAdministrarPersonal_Click(object sender, EventArgs e)
        {
            //frmAdministrarGestores formAdminGestores = new frmAdministrarGestores();
            frmAdministrarPersonal formAdminPersonal = new frmAdministrarPersonal(this);
            formAdminPersonal.MdiParent = this;
            formAdminPersonal.Show();

            //formAdminGestores.Visible = true;

            //lblBienvenido.Visible = false;
            //panelAviso.Visible = false;
        }

        private void btnAdministrarBbiliotecas_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministrarPersonal_Click_1(object sender, EventArgs e)
        {
            //frmAdministrarGestores formAdminGestores = new frmAdministrarGestores();
            frmAdministrarPersonal formAdminPersonal = new frmAdministrarPersonal(this);
            formAdminPersonal.MdiParent = this;
            formAdminPersonal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
