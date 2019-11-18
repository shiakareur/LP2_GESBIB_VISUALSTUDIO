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

        private ServicioJava.usuario var_usuario;

        private frmLogin var_formLogin;

        private frmRegHE var_frmRegistrarHE_Practicante;
        private frmRegInasistencias var_frmRegistrarInasis_Practicante;

        private frmSolicitarHL var_frmSolicitarHL_Practicante;
        private frmSolicitarCambioTurno var_frmSolicitarCambioTurno_Practicante;

        private frmRespuestaValidaciones var_frmRespuestasSolicitudes_Practicante;
        private frmVisualizarHorarios var_frmVerHorarios_Practicante;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }


        public frmPerfilPracticante()
        {
            InitializeComponent();
            customizeDesign();
        }


        public frmPerfilPracticante(frmLogin formLogin, ServicioJava.usuario _usuario) //con paramtero this 
        {
            var_usuario = _usuario;
            var_formLogin = formLogin;
            InitializeComponent();
            customizeDesign();
            lblNombreUsuario.Text = _usuario.nombre;
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

        private void muestraMensajeCerraroGuardarCambios()
        {
            //mostramos mensaje de error
            MessageBox.Show("Cierre o guarde los cambios !",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        private void btnReg_HE_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = false;
            //preguntar si hay algun form "activo" para no cargar este form

            if ((var_frmRegistrarInasis_Practicante != null &&
                        var_frmRegistrarInasis_Practicante.Visible == true) ||
                    (var_frmSolicitarHL_Practicante!= null &&
                        var_frmSolicitarHL_Practicante.Visible == true) ||
                    (var_frmSolicitarCambioTurno_Practicante != null &&
                        var_frmSolicitarCambioTurno_Practicante.Visible == true) ||
                    (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
                    (var_frmVerHorarios_Practicante != null &&
                        var_frmVerHorarios_Practicante.Visible == true))
            {

                this.muestraMensajeCerraroGuardarCambios();

            }
            else
            {
                //seguimos con nuestra programacion
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmRegistrarHE_Practicante == null)
                {
                    var_frmRegistrarHE_Practicante = new frmRegHE(this, TipoPerfil.PerfilPracticante,
                    var_usuario);
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
                    var_frmRegistrarHE_Practicante.limpiarComponentes();
                    var_frmRegistrarHE_Practicante.estadoComponentes(Estado.Inicial);
                    var_frmRegistrarHE_Practicante.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Practicante != null)
                {
                    var_frmSolicitarHL_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                if (var_frmRegistrarInasis_Practicante != null)
                {
                    var_frmRegistrarInasis_Practicante.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmSolicitarCambioTurno_Practicante != null)
                {
                    var_frmSolicitarCambioTurno_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                lblBienvenido.Visible = false;
                panelAviso.Visible = false;

                //escondemos el submenu
                hideSubMenu();
            }
        }

        private void btnReg_Inas_Click(object sender, EventArgs e)
        {

            panelBIPO.Visible = false;

            if ((var_frmRegistrarHE_Practicante != null &&
                        var_frmRegistrarHE_Practicante.Visible == true) ||
               (var_frmSolicitarHL_Practicante != null &&
                       var_frmSolicitarHL_Practicante.Visible == true) ||
               (var_frmSolicitarCambioTurno_Practicante != null &&
                        var_frmSolicitarCambioTurno_Practicante.Visible == true) ||
               (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
               (var_frmVerHorarios_Practicante != null &&
                        var_frmVerHorarios_Practicante.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
            {
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmRegistrarInasis_Practicante == null)
                {
                    var_frmRegistrarInasis_Practicante = new frmRegInasistencias(this, TipoPerfil.PerfilPracticante, var_usuario);
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
                    var_frmRegistrarInasis_Practicante.limpiarComponentes();
                    var_frmRegistrarInasis_Practicante.estadoComponentes(Estado.Inicial);
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


        }





        private void btnSolicitar_HLibres_Click(object sender, EventArgs e)
        {

            panelBIPO.Visible = false;

            if ((var_frmRegistrarHE_Practicante != null &&
                        var_frmRegistrarHE_Practicante.Visible == true) ||
               (var_frmRegistrarInasis_Practicante != null &&
                        var_frmRegistrarInasis_Practicante.Visible == true) ||
               (var_frmSolicitarCambioTurno_Practicante != null &&
                        var_frmSolicitarCambioTurno_Practicante.Visible == true) ||
               (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
               (var_frmVerHorarios_Practicante != null &&
                        var_frmVerHorarios_Practicante.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
            {
                //aca llamamos al formulario de solicitar horas libres
                if (var_frmSolicitarHL_Practicante == null)
                {
                    var_frmSolicitarHL_Practicante = new frmSolicitarHL(this, TipoPerfil.PerfilPracticante,
                        var_usuario);
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
                    var_frmSolicitarHL_Practicante.limpiarComponentes();
                    var_frmSolicitarHL_Practicante.estadoComponentes(Estado.Inicial);
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

            panelBIPO.Visible = false;

            if ((var_frmRegistrarHE_Practicante != null &&
                        var_frmRegistrarHE_Practicante.Visible == true) ||
               (var_frmRegistrarInasis_Practicante != null &&
                        var_frmRegistrarInasis_Practicante.Visible == true) ||
               (var_frmSolicitarHL_Practicante != null &&
                        var_frmSolicitarHL_Practicante.Visible == true) ||
               (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
               (var_frmVerHorarios_Practicante != null &&
                        var_frmVerHorarios_Practicante.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
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

                    var_frmSolicitarCambioTurno_Practicante.limpiarComponentes();
                    var_frmSolicitarCambioTurno_Practicante.estadoComponentes(Estado.Inicial);
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

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = false;

            if ((var_frmRegistrarInasis_Practicante != null &&
                        var_frmRegistrarInasis_Practicante.Visible == true) ||
                (var_frmSolicitarHL_Practicante != null &&
                        var_frmSolicitarHL_Practicante.Visible == true) ||
                (var_frmSolicitarCambioTurno_Practicante != null &&
                        var_frmSolicitarCambioTurno_Practicante.Visible == true) ||
                (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
                (var_frmVerHorarios_Practicante != null &&
                        var_frmVerHorarios_Practicante.Visible == true))
            {

                this.muestraMensajeCerraroGuardarCambios();

            }
            else
            {

                //seguimos con nuestra programacion
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmRespuestasSolicitudes_Practicante == null)
                {
                    var_frmRespuestasSolicitudes_Practicante = new frmRespuestaValidaciones(this, TipoPerfil.PerfilPracticante);
                    var_frmRespuestasSolicitudes_Practicante.MdiParent = this;

                    //...add
                    var_frmRespuestasSolicitudes_Practicante.StartPosition = FormStartPosition.Manual;
                    var_frmRespuestasSolicitudes_Practicante.Left = 0;
                    var_frmRespuestasSolicitudes_Practicante.Top = 0;
                    //...


                    var_frmRespuestasSolicitudes_Practicante.Show();
                }
                else
                {
                    //var_frmRespuestasSolicitudes_Practicante.limpiarComponentes();
                    //var_frmRespuestasSolicitudes_Practicante.estadoComponentes(Estado.Inicial);
                    var_frmRespuestasSolicitudes_Practicante.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Practicante != null)
                {
                    var_frmSolicitarHL_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                if (var_frmRegistrarInasis_Practicante != null)
                {
                    var_frmRegistrarInasis_Practicante.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmSolicitarCambioTurno_Practicante != null)
                {
                    var_frmSolicitarCambioTurno_Practicante.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmRegistrarHE_Practicante != null)
                {
                    var_frmRegistrarHE_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                lblBienvenido.Visible = false;
                panelAviso.Visible = false;

                //escondemos el submenu
                hideSubMenu();
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = true;
        }

        private void btnVisualizarHorarios_Click(object sender, EventArgs e)
        {
            panelBIPO.Visible = false;

            if ((var_frmRegistrarInasis_Practicante != null &&
                        var_frmRegistrarInasis_Practicante.Visible == true) ||
                (var_frmSolicitarHL_Practicante != null &&
                        var_frmSolicitarHL_Practicante.Visible == true) ||
                (var_frmSolicitarCambioTurno_Practicante != null &&
                        var_frmSolicitarCambioTurno_Practicante.Visible == true) ||
                (var_frmRespuestasSolicitudes_Practicante != null &&
                        var_frmRespuestasSolicitudes_Practicante.Visible == true) ||
                (var_frmRegistrarHE_Practicante != null &&
                        var_frmRegistrarHE_Practicante.Visible == true))
            {

                this.muestraMensajeCerraroGuardarCambios();

            }
            else
            {

                //seguimos con nuestra programacion
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmVerHorarios_Practicante == null)
                {
                    var_frmVerHorarios_Practicante = new frmVisualizarHorarios(this, TipoPerfil.PerfilPracticante);
                    var_frmVerHorarios_Practicante.MdiParent = this;

                    //...add
                    var_frmVerHorarios_Practicante.StartPosition = FormStartPosition.Manual;
                    var_frmVerHorarios_Practicante.Left = 0;
                    var_frmVerHorarios_Practicante.Top = 0;
                    //...


                    var_frmVerHorarios_Practicante.Show();
                }
                else
                {
                    //var_frmRespuestasSolicitudes_Practicante.limpiarComponentes();
                    //var_frmRespuestasSolicitudes_Practicante.estadoComponentes(Estado.Inicial);
                    var_frmVerHorarios_Practicante.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Practicante != null)
                {
                    var_frmSolicitarHL_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                if (var_frmRegistrarInasis_Practicante != null)
                {
                    var_frmRegistrarInasis_Practicante.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmSolicitarCambioTurno_Practicante != null)
                {
                    var_frmSolicitarCambioTurno_Practicante.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmRegistrarHE_Practicante != null)
                {
                    var_frmRegistrarHE_Practicante.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                lblBienvenido.Visible = false;
                panelAviso.Visible = false;

                //escondemos el submenu
                hideSubMenu();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
