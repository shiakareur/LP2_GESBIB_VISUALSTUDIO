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
    public partial class frmLogin : Form
    {
        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();       
                
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            //KeyValuePair<String, ServicioJava.usuario> a = new KeyValuePair<>(servTA.validarUsuario("bbenrique@gmail.com", "987654"));
            ServicioJava.pairStringUsuario userV = servTA.validarUsuario(placeHolderUsuario.Text, txtcontraseña.Text);
            if (userV.nombreTipo == "")
            {
            }
            else if (userV.nombreTipo == "ADMINISTRADOR")
            {
                frmPerfilAdministrador frmPerfilAdministrador = new frmPerfilAdministrador(this, userV.user);
                frmPerfilAdministrador.Visible = true;
                this.Visible = false;
            }
            else if (userV.nombreTipo == "PERSONAL")
            {
                string tipoP = servTA.hallarTipoUsuario(userV.user.id);
                if (tipoP == "PRACTICANTE") { }
                else if (tipoP == "AUXILIAR") { }
                else if (tipoP == "BIBLIOTECARIO")
                {
                    frmPerfilBibliotecario formBibliotecario = new frmPerfilBibliotecario(this, userV.user);
                    formBibliotecario.Visible = true;
                    this.Visible = false;
                }
                else if (tipoP == "GESTOR") {
                    frmPerfilGestor formGestor = new frmPerfilGestor(this, userV.user);
                    formGestor.Visible = true;
                    this.Visible = false;
                }
            }

            //------------------

            /*
                //abrir diferentes usuarios
                if (placeHolderUsuario.Text=="ariana")
            {
                frmPerfilAdministrador formPAdmin = new frmPerfilAdministrador(this);
                formPAdmin.Visible = true;
                this.Visible = true;
            }

            //KeyValuePair<String, ServicioJava.usuario> a = new KeyValuePair<>(servTA.validarUsuario("bbenrique@gmail.com", "987654"));

            else if (placeHolderUsuario.Text == "practicante")
            {
                frmPerfilPracticante frmPracticante = new frmPerfilPracticante(this);
                frmPracticante.Visible = true;
                this.Visible = true;
            }
            else if (placeHolderUsuario.Text == "auxiliar")
            {
                frmPerfilAuxiliar frmAuxiliar = new frmPerfilAuxiliar(this);
                frmAuxiliar.Visible = true;
                this.Visible = true;
            }
            else if (placeHolderUsuario.Text == "gaston")
            {
                frmPerfilGestor frmGestor = new frmPerfilGestor(this);
                frmGestor.Visible = true;
                this.Visible = true;
            }
            else
            {
                //BIBLIOTECARIO
                frmPerfilBibliotecario formBibliotecario = new frmPerfilBibliotecario(this);
                formBibliotecario.Visible = true;
                this.Visible = false;
            }*/


        }

        private void placeHolderUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
