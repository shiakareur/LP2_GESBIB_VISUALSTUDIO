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

        public Panel PanelAviso { get => panelAviso; set => panelAviso = value; }
        public Label LblBienvenido { get => lblBienvenido; set => lblBienvenido = value; }
                      

        private frmLogin var_formLogin;

        // aver lo de jin

        private frmRegistrar_Bibliotecario var_frmRegistrar_Bibliotecario;
        private frmSolicitar_Bibliotecario var_frmSolicitar_Bibliotecario;

        public frmPerfilBibliotecario()
        {
            InitializeComponent();
        }

        //con paramtero this 
        public frmPerfilBibliotecario(frmLogin formLogin)
        {
            var_formLogin = formLogin;
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();            
            this.var_formLogin.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // aca se tiene q llamar a los estados para que pongan todos en blanco

            //Componentes.Nuevo();


            if(var_frmRegistrar_Bibliotecario == null)
            {              
                var_frmRegistrar_Bibliotecario = new frmRegistrar_Bibliotecario(this);
                var_frmRegistrar_Bibliotecario.MdiParent = this;

                //...add
                var_frmRegistrar_Bibliotecario.StartPosition = FormStartPosition.Manual;
                var_frmRegistrar_Bibliotecario.Left = 0;
                var_frmRegistrar_Bibliotecario.Top =  0;
                //...


                var_frmRegistrar_Bibliotecario.Show();
            }
            else
            {
                var_frmRegistrar_Bibliotecario.Visible = true;
            }

            //....
            if(var_frmSolicitar_Bibliotecario != null)
            {
                var_frmSolicitar_Bibliotecario.Visible = false;
                //todos los demas formularios

            }

            lblBienvenido.Visible = false;
            panelAviso.Visible = false;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (var_frmSolicitar_Bibliotecario == null)
            {             
                var_frmSolicitar_Bibliotecario = new frmSolicitar_Bibliotecario(this);
                var_frmSolicitar_Bibliotecario.MdiParent = this;
                //...add
                var_frmSolicitar_Bibliotecario.StartPosition = FormStartPosition.Manual;
                var_frmSolicitar_Bibliotecario.Left = 0;
                var_frmSolicitar_Bibliotecario.Top = 0;
                //
                var_frmSolicitar_Bibliotecario.Show();
            }
            else
            {
                var_frmSolicitar_Bibliotecario.Visible = true;
            }

            //....
            if (var_frmRegistrar_Bibliotecario != null)
            {
                var_frmRegistrar_Bibliotecario.Visible = false;
                //todos los demas formularios

            }
                       
            lblBienvenido.Visible = false;
            panelAviso.Visible = false;
        }
    }
}
