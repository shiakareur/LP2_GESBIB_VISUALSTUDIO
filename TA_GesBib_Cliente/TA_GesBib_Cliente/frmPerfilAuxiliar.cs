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


    public partial class frmPerfilAuxiliar : Form
    {
        //se agrego
        private frmLogin var_formLogin;

        private frmRegHE var_frmRegistrarHE_Auxiliar;
        private frmRegInasistencias var_frmRegistrarInasis_Auxiliar;

        private frmSolicitarHL var_frmSolicitarHL_Auxiliar;
        private frmSolicitarCambioTurno var_frmSolicitarCambioTurno_Auxiliar;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }


        public frmPerfilAuxiliar()
        {
            InitializeComponent();
            customizeDesign();
        }


        public frmPerfilAuxiliar(frmLogin formLogin) //con paramtero this 
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
        

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBtn_Solicitar);
        }



        private void btnReg_HE_Click(object sender, EventArgs e)
        {

            //aca llamamos al formulario de registrar Horas extras
            if (var_frmRegistrarHE_Auxiliar == null)
            {
                var_frmRegistrarHE_Auxiliar = new frmRegHE(this, TipoPerfil.PerfilAuxiliar);
                var_frmRegistrarHE_Auxiliar.MdiParent = this;

                //...add
                var_frmRegistrarHE_Auxiliar.StartPosition = FormStartPosition.Manual;
                var_frmRegistrarHE_Auxiliar.Left = 0;
                var_frmRegistrarHE_Auxiliar.Top = 0;
                //...


                var_frmRegistrarHE_Auxiliar.Show();
            }
            else
            {
                var_frmRegistrarHE_Auxiliar.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Auxiliar != null)
            {
                var_frmSolicitarHL_Auxiliar.Visible = false;
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
            if (var_frmRegistrarInasis_Auxiliar == null)
            {
                var_frmRegistrarInasis_Auxiliar = new frmRegInasistencias(this, TipoPerfil.PerfilAuxiliar);
                var_frmRegistrarInasis_Auxiliar.MdiParent = this;

                //...add
                var_frmRegistrarInasis_Auxiliar.StartPosition = FormStartPosition.Manual;
                var_frmRegistrarInasis_Auxiliar.Left = 0;
                var_frmRegistrarInasis_Auxiliar.Top = 0;
                //...


                var_frmRegistrarInasis_Auxiliar.Show();
            }
            else
            {
                var_frmRegistrarInasis_Auxiliar.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Auxiliar != null)
            {
                var_frmSolicitarHL_Auxiliar.Visible = false;
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
            if (var_frmSolicitarHL_Auxiliar == null)
            {
                var_frmSolicitarHL_Auxiliar = new frmSolicitarHL(this, TipoPerfil.PerfilAuxiliar);
                var_frmSolicitarHL_Auxiliar.MdiParent = this;

                //...add
                var_frmSolicitarHL_Auxiliar.StartPosition = FormStartPosition.Manual;
                var_frmSolicitarHL_Auxiliar.Left = 0;
                var_frmSolicitarHL_Auxiliar.Top = 0;
                //...


                var_frmSolicitarHL_Auxiliar.Show();
            }
            else
            {
                var_frmSolicitarHL_Auxiliar.Visible = true;
            }

            //....
            if (var_frmSolicitarCambioTurno_Auxiliar != null)
            {
                var_frmSolicitarCambioTurno_Auxiliar.Visible = false;
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

        private void frmPerfilAuxiliar_Load(object sender, EventArgs e)
        {
            //escondemos los paneles
            //panelBtn_Registrar.Hide();
            //panelBtn_Solicitar.Hide();
        }

        private void btnSolicitar_CambioTurno_Click(object sender, EventArgs e)
        {
            //aca llamamos al formulario de solicitar cambio de turno
            if (var_frmSolicitarCambioTurno_Auxiliar == null)
            {
                var_frmSolicitarCambioTurno_Auxiliar = new frmSolicitarCambioTurno(this, TipoPerfil.PerfilAuxiliar);
                var_frmSolicitarCambioTurno_Auxiliar.MdiParent = this;

                //...add
                var_frmSolicitarCambioTurno_Auxiliar.StartPosition = FormStartPosition.Manual;
                var_frmSolicitarCambioTurno_Auxiliar.Left = 0;
                var_frmSolicitarCambioTurno_Auxiliar.Top = 0;
                //...


                var_frmSolicitarCambioTurno_Auxiliar.Show();
            }
            else
            {
                var_frmSolicitarCambioTurno_Auxiliar.Visible = true;
            }

            //....
            if (var_frmSolicitarHL_Auxiliar != null)
            {
                var_frmSolicitarHL_Auxiliar.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;

            //escondemos el submenu
            hideSubMenu();
        }
    }
}
