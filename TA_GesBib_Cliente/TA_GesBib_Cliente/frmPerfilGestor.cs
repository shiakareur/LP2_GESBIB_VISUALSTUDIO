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
    public partial class frmPerfilGestor : Form
    {

        private frmLogin var_formLogin;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }



        public frmPerfilGestor()
        {
            InitializeComponent();
        }

        public frmPerfilGestor(frmLogin formLogin) //con paramtero this 
        {
            var_formLogin = formLogin;
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.var_formLogin.Visible = true;
        }

        private void btnAsignarTurnos_Click(object sender, EventArgs e)
        {

            //lblBienvenido.Visible = false;
            //panelAviso.Visible = false;

            panelBIPO.Visible = false;

            frmAsignarTurnos frmAsignar_turno = new frmAsignarTurnos(this);
            frmAsignar_turno.MdiParent = this;
            frmAsignar_turno.Show();
            frmAsignar_turno.Location = new Point(0, 0);




        }

        private void btnAdmPerfilesExp_Click(object sender, EventArgs e)
        {
            //lblBienvenido.Visible = false;
            //panelAviso.Visible = false;

            panelBIPO.Visible = false;

            frmAdminPerfilesExp frmAdminPerfilExp = new frmAdminPerfilesExp(this);
            frmAdminPerfilExp.MdiParent = this;
            frmAdminPerfilExp.Show();
            frmAdminPerfilExp.Location = new Point(0, 0);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = true;
        }
    }
}
