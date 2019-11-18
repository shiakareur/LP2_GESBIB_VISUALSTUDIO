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
        private ServicioJava.usuario var_usuario;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }



        public frmPerfilGestor()
        {
            InitializeComponent();
        }

        public frmPerfilGestor(frmLogin formLogin, ServicioJava.usuario _user) //con paramtero this 
        {
            var_formLogin = formLogin;
            var_usuario = _user;
            
            InitializeComponent();
            lblNombreUsuario.Text = var_usuario.nombre;
            customizeDesign(); // <---- para los PANELES
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
        //...................PANELES v2 ................................

        private void customizeDesign()
        {
            panelDistribucion.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDistribucion.Visible == true)
                panelDistribucion.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            //alterna la visibilidad del submenu actual con el submenu anterior

            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //...................PANELES v2 ................................


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

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = false;

            frmCapacitaciones frmCapa = new frmCapacitaciones();
            frmCapa.MdiParent = this;
            frmCapa.Show();
            frmCapa.Location = new Point(0, 0);
        }

        private void btnDistribucionPersonal_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDistribucion);
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            frmDistribucionSemestre formDistSemestre = new frmDistribucionSemestre(var_usuario);
            formDistSemestre.MdiParent = this;
            formDistSemestre.Show();
            formDistSemestre.Location = new Point(0, 0);
            formDistSemestre.Size = new Size(934, 675);

            hideSubMenu();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            frmDistribuirPersonalSemana formDistSemana = new frmDistribuirPersonalSemana(var_usuario);
            formDistSemana.MdiParent = this;
            formDistSemana.Show();
            formDistSemana.Location = new Point(0, 0);
            formDistSemana.Size = new Size(934, 675);

            hideSubMenu();
        }
    }
}
