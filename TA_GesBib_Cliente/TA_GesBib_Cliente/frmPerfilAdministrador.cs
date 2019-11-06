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
     

        private frmLogin var_formLogin;
        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }

        public frmPerfilAdministrador()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }


        public frmPerfilAdministrador(frmLogin formLogin) //con paramtero this 
        {
            var_formLogin = formLogin;
            InitializeComponent();
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
            formAdminPersonal.Location = new Point(0, 0);
            //formAdminGestores.Visible = true;

            //lblBienvenido.Visible = false;
            //panelAviso.Visible = false;
        }

        private void btnAdministrarBbiliotecas_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministrarPersonal_Click_1(object sender, EventArgs e)
        {
            frmAdministrarPersonal formAdminPersonal = new frmAdministrarPersonal(this);
            formAdminPersonal.MdiParent = this;
            formAdminPersonal.Show();
            formAdminPersonal.Location = new Point(0, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmGestores_Click(object sender, EventArgs e)
        {

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;


            frmAdministrarGestores frmAdmGestores = new frmAdministrarGestores(this);
            frmAdmGestores.MdiParent = this;
            frmAdmGestores.Show();
            frmAdmGestores.Location = new Point(0, 0);
        }

        private void btnAdmBibliotecas_Click(object sender, EventArgs e)
        {

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;


            frmAdministrarBibliotecas frmAdmBibliotecas = new frmAdministrarBibliotecas(this);
            frmAdmBibliotecas.MdiParent = this;
            frmAdmBibliotecas.Show();
            frmAdmBibliotecas.Location = new Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.var_formLogin.Visible = true;
        }
    }
}
