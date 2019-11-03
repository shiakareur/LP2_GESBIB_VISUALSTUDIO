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
    //creo como atributos los formularios de mi menu d cada booton
    //al aser click pregunto si es null(para ver si ya lo he creado y no hacer otro)
    //if(form == null){
    //    //aca pongo visible false a todos  los demas que EXISTEN (OTRO if X CADA UNO)
    //    form = new frmTipoFrm();
    //}else{
    //    form.Visible = true; //es xq en algun momento lo he puesto false
    //}


    public partial class frmPerfilPracticante : Form
    {
        //se agrego
        private frmLogin var_formLogin;

        private frmRegHE var_frmRegistrarHE_Practicante;
        private frmRegInasistencias var_frmRegistrarInasis_Practicante;

        private frmSolicitarHL var_frmSolicitarHL_Practicante;
        private frmSolicitarCambioTurno var_frmSolicitarCambioTurno_Practicante;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }


        public frmPerfilPracticante()
        {
            InitializeComponent();
            customizeDesign();
        }


        public frmPerfilPracticante(frmLogin formLogin) //con paramtero this 
        {
            var_formLogin = formLogin;
            InitializeComponent();
            customizeDesign();
        }

        //...................PANELES v2 ................................

        private void customizeDesign()
        {
            panelBtn_Registrar.Visible = false;
            panelBtn_Solicitar.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBtn_Registrar.Visible == true)
                panelBtn_Registrar.Visible = false;

            if (panelBtn_Solicitar.Visible == true)
                panelBtn_Solicitar.Visible = false;
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



        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            showSubMenu(panelBtn_Registrar);

        }

        private void btnDistribuir_Personal_Click(object sender, EventArgs e)
        {



        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBtn_Solicitar);
        }



        private void btnReg_HE_Click(object sender, EventArgs e)
        {

            //aca llamamos al formulario de registrar Horas extras
            if (var_frmRegistrarHE_Practicante == null)
            {
                var_frmRegistrarHE_Practicante = new frmRegHE(this, TipoPerfil.PerfilPracticante);
                var_frmRegistrarHE_Practicante.MdiParent = this;

                //...add
                var_frmRegistrarHE_Practicante.StartPosition = FormStartPosition.Manual;
                var_frmRegistrarHE_Practicante.Left = 0;
                var_frmRegistrarHE_Practicante.Top = 0;
                //...


                var_frmRegistrarHE_Practicante.Show();
            }
            else
            {
                var_frmRegistrarHE_Practicante.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Practicante != null)
            {
                var_frmSolicitarHL_Practicante.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;

            //escondemos el submenu
            hideSubMenu();

        }

        private void btnReg_Inas_Click(object sender, EventArgs e)
        {

            //aca llamamos al formulario de registrar Horas extras
            if (var_frmRegistrarInasis_Practicante == null)
            {
                var_frmRegistrarInasis_Practicante = new frmRegInasistencias(this, TipoPerfil.PerfilPracticante);
                var_frmRegistrarInasis_Practicante.MdiParent = this;

                //...add
                var_frmRegistrarInasis_Practicante.StartPosition = FormStartPosition.Manual;
                var_frmRegistrarInasis_Practicante.Left = 0;
                var_frmRegistrarInasis_Practicante.Top = 0;
                //...


                var_frmRegistrarInasis_Practicante.Show();
            }
            else
            {
                var_frmRegistrarInasis_Practicante.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Practicante != null)
            {
                var_frmSolicitarHL_Practicante.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;

            //escondemos el submenu
            hideSubMenu();


        }





        private void btnSolicitar_HLibres_Click(object sender, EventArgs e)
        {

            //aca llamamos al formulario de solicitar horas libres
            if (var_frmSolicitarHL_Practicante == null)
            {
                var_frmSolicitarHL_Practicante = new frmSolicitarHL(this, TipoPerfil.PerfilPracticante);
                var_frmSolicitarHL_Practicante.MdiParent = this;

                //...add
                var_frmSolicitarHL_Practicante.StartPosition = FormStartPosition.Manual;
                var_frmSolicitarHL_Practicante.Left = 0;
                var_frmSolicitarHL_Practicante.Top = 0;
                //...


                var_frmSolicitarHL_Practicante.Show();
            }
            else
            {
                var_frmSolicitarHL_Practicante.Visible = true;
            }

            //....
            if (var_frmSolicitarCambioTurno_Practicante != null)
            {
                var_frmSolicitarCambioTurno_Practicante.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;

            //escondemos el submenu
            hideSubMenu();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.var_formLogin.Visible = true;
        }

        private void frmPerfilPracticante_Load(object sender, EventArgs e)
        {
            //escondemos los paneles
            //panelBtn_Registrar.Hide();
            //panelBtn_Solicitar.Hide();
        }

        private void btnSolicitar_CambioTurno_Click(object sender, EventArgs e)
        {
            //aca llamamos al formulario de solicitar cambio de turno
            if (var_frmSolicitarCambioTurno_Practicante == null)
            {
                var_frmSolicitarCambioTurno_Practicante = new frmSolicitarCambioTurno(this, TipoPerfil.PerfilPracticante);
                var_frmSolicitarCambioTurno_Practicante.MdiParent = this;

                //...add
                var_frmSolicitarCambioTurno_Practicante.StartPosition = FormStartPosition.Manual;
                var_frmSolicitarCambioTurno_Practicante.Left = 0;
                var_frmSolicitarCambioTurno_Practicante.Top = 0;
                //...


                var_frmSolicitarCambioTurno_Practicante.Show();
            }
            else
            {
                var_frmSolicitarCambioTurno_Practicante.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Practicante != null)
            {
                var_frmSolicitarHL_Practicante.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;

            //escondemos el submenu
            hideSubMenu();
        }
    }
}
