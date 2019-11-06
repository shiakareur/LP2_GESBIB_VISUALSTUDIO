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
      
            
    public partial class frmPerfilBibliotecario : Form
    {
        //se agrego
        private frmLogin var_formLogin;

        private frmRegHE var_frmRegistrarHE_Bibliotecario;
        private frmRegInasistencias var_frmRegistrarInasis_Bibliotecario;

        private frmSolicitarHL var_frmSolicitarHL_Bibliotecario;
        private frmSolicitarCambioTurno var_frmSolicitarCambioTurno_Bibliotecario;

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }                   
         

        public frmPerfilBibliotecario()
        {
            InitializeComponent();
            customizeDesign();
        }

        
        public frmPerfilBibliotecario(frmLogin formLogin) //con paramtero this 
        {
            var_formLogin = formLogin;
            InitializeComponent();
            customizeDesign(); // <---- para los PANELES
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

        private void btnDistribuir_Personal_Click(object sender, EventArgs e)
        {

            

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
            //......
            //preguntar si hay algun form "activo" para no cargar este form
          
              if (  (var_frmRegistrarInasis_Bibliotecario != null &&
                        var_frmRegistrarInasis_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarHL_Bibliotecario != null &&    
                        var_frmSolicitarHL_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarCambioTurno_Bibliotecario != null &&
                        var_frmSolicitarCambioTurno_Bibliotecario.Visible == true))
                {

                this.muestraMensajeCerraroGuardarCambios();

                }
            else
            {              

                //seguimos con nuestra programacion
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmRegistrarHE_Bibliotecario == null)
                {
                    var_frmRegistrarHE_Bibliotecario = new frmRegHE(this,TipoPerfil.PerfilBibliotecario);
                    var_frmRegistrarHE_Bibliotecario.MdiParent = this;

                    //...add
                    var_frmRegistrarHE_Bibliotecario.StartPosition = FormStartPosition.Manual;
                    var_frmRegistrarHE_Bibliotecario.Left = 0;
                    var_frmRegistrarHE_Bibliotecario.Top = 0;
                    //...


                    var_frmRegistrarHE_Bibliotecario.Show();
                }
                else
                {
                    var_frmRegistrarHE_Bibliotecario.limpiarComponentes();
                    var_frmRegistrarHE_Bibliotecario.estadoComponentes(Estado.Inicial);
                    var_frmRegistrarHE_Bibliotecario.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Bibliotecario != null)
                {
                    var_frmSolicitarHL_Bibliotecario.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                if (var_frmRegistrarInasis_Bibliotecario != null)
                {
                    var_frmRegistrarInasis_Bibliotecario.Visible = false;
                    //todos los demas formularios

                }

                if (var_frmSolicitarCambioTurno_Bibliotecario != null)
                {
                    var_frmSolicitarCambioTurno_Bibliotecario.Visible = false;
                    //todos los demas formularios

                }

                //hoy agregeishion

                lblBienvenido.Visible = false;
                panelAviso.Visible = false;

                //escondemos el submenu
                hideSubMenu();
            }
     
         

            //....

            

        }

        private void btnReg_Inas_Click(object sender, EventArgs e)
        {


            if((var_frmRegistrarHE_Bibliotecario != null &&
                        var_frmRegistrarHE_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarHL_Bibliotecario != null &&
                        var_frmSolicitarHL_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarCambioTurno_Bibliotecario != null &&
                        var_frmSolicitarCambioTurno_Bibliotecario.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
            {
                //aca llamamos al formulario de registrar Horas extras
                if (var_frmRegistrarInasis_Bibliotecario == null)
                {
                    var_frmRegistrarInasis_Bibliotecario = new frmRegInasistencias(this,TipoPerfil.PerfilBibliotecario);
                    var_frmRegistrarInasis_Bibliotecario.MdiParent = this;

                    //...add
                    var_frmRegistrarInasis_Bibliotecario.StartPosition = FormStartPosition.Manual;
                    var_frmRegistrarInasis_Bibliotecario.Left = 0;
                    var_frmRegistrarInasis_Bibliotecario.Top = 0;
                    //...


                    var_frmRegistrarInasis_Bibliotecario.Show();
                }
                else
                {
                    var_frmRegistrarInasis_Bibliotecario.limpiarComponentes();
                    var_frmRegistrarInasis_Bibliotecario.estadoComponentes(Estado.Inicial);
                    var_frmRegistrarInasis_Bibliotecario.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Bibliotecario != null)
                {
                    var_frmSolicitarHL_Bibliotecario.Visible = false;
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
            if((var_frmRegistrarHE_Bibliotecario != null &&
                        var_frmRegistrarHE_Bibliotecario.Visible == true) ||
                    (var_frmRegistrarInasis_Bibliotecario != null &&
                        var_frmRegistrarInasis_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarCambioTurno_Bibliotecario != null &&
                        var_frmSolicitarCambioTurno_Bibliotecario.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
            {
                //aca llamamos al formulario de solicitar horas libres
                if (var_frmSolicitarHL_Bibliotecario == null)
                {
                    var_frmSolicitarHL_Bibliotecario = new frmSolicitarHL(this,TipoPerfil.PerfilBibliotecario);
                    var_frmSolicitarHL_Bibliotecario.MdiParent = this;

                    //...add
                    var_frmSolicitarHL_Bibliotecario.StartPosition = FormStartPosition.Manual;
                    var_frmSolicitarHL_Bibliotecario.Left = 0;
                    var_frmSolicitarHL_Bibliotecario.Top = 0;
                    //...


                    var_frmSolicitarHL_Bibliotecario.Show();
                }
                else
                {
                    var_frmSolicitarHL_Bibliotecario.limpiarComponentes();
                    var_frmSolicitarHL_Bibliotecario.estadoComponentes(Estado.Inicial);
                    var_frmSolicitarHL_Bibliotecario.Visible = true;
                }

                //....
                if (var_frmSolicitarCambioTurno_Bibliotecario != null)
                {
                    var_frmSolicitarCambioTurno_Bibliotecario.Visible = false;
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

        private void frmPerfilBibliotecario_Load(object sender, EventArgs e)
        {
            //escondemos los paneles
            //panelBtn_Registrar.Hide();
            //panelBtn_Solicitar.Hide();
        }

        private void btnSolicitar_CambioTurno_Click(object sender, EventArgs e)
        {
            if((var_frmRegistrarHE_Bibliotecario != null &&
                        var_frmRegistrarHE_Bibliotecario.Visible == true) ||
                    (var_frmRegistrarInasis_Bibliotecario != null &&
                        var_frmRegistrarInasis_Bibliotecario.Visible == true) ||
                    (var_frmSolicitarHL_Bibliotecario != null &&
                        var_frmSolicitarHL_Bibliotecario.Visible == true))
            {
                this.muestraMensajeCerraroGuardarCambios();
            }
            else
            {
                //aca llamamos al formulario de solicitar cambio de turno
                if (var_frmSolicitarCambioTurno_Bibliotecario == null)
                {
                    var_frmSolicitarCambioTurno_Bibliotecario = new frmSolicitarCambioTurno(this,TipoPerfil.PerfilBibliotecario);
                    var_frmSolicitarCambioTurno_Bibliotecario.MdiParent = this;

                    //...add

                    

                    var_frmSolicitarCambioTurno_Bibliotecario.StartPosition = FormStartPosition.Manual;
                    var_frmSolicitarCambioTurno_Bibliotecario.Left = 0;
                    var_frmSolicitarCambioTurno_Bibliotecario.Top = 0;
                    //...


                    var_frmSolicitarCambioTurno_Bibliotecario.Show();
                }
                else
                {
                    
                    var_frmSolicitarCambioTurno_Bibliotecario.limpiarComponentes();
                    var_frmSolicitarCambioTurno_Bibliotecario.estadoComponentes(Estado.Inicial);
                    var_frmSolicitarCambioTurno_Bibliotecario.Visible = true;
                }

                //....
                if (var_frmSolicitarHL_Bibliotecario != null)
                {
                    var_frmSolicitarHL_Bibliotecario.Visible = false;
                    //todos los demas formularios

                }

                lblBienvenido.Visible = false;
                panelAviso.Visible = false;

                //escondemos el submenu
                hideSubMenu();
            }
            
        }
    }
}
