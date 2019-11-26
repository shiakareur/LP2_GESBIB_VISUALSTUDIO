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

    public partial class frmConfigurar : Form
    {
        private ServicioJava.usuario var_usuario;
        //private ServicioJava.personal var_personal;
        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        public frmConfigurar()
        {
            InitializeComponent();
        }

        public frmConfigurar(Form formPerfilPersonal, TipoPerfil tipoPerfil, ServicioJava.usuario _user,ServicioJava.personal _personal)
        {
            var_usuario = _user;
            //var_personal = _personal;
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            //Para mostrar los datos

            InitializeComponent();
            txtNombre.Text = var_usuario.nombre;
            txtApellido.Text = var_usuario.apellido;
            txtCorreo.Text = var_usuario.email;
            //txtCodigo.Text = var_personal.codigo;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            switch (var_tipoPerfil)
            {
                /*case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    this.var_perfilBibliotecario.LblBienvenido.Visible = true;
                    this.var_perfilBibliotecario.PanelAviso.Visible = true;
                    break;*/
                case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    //((frmPerfilBibliotecario)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    //((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                default:
                break;
            }



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
