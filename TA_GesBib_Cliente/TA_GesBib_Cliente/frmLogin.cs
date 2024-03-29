﻿using System;
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
            ServicioJava.personalBiblioteca datosUsuario = servTA.informacionPersonalBiblioteca(placeHolderUsuario.Text);
            if (userV.nombreTipo == "")
            {
                MessageBox.Show("ERROR , ¡Su usuario o contraseña no coincidden!",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                if (tipoP == "PRACTICANTE") {
                    frmPerfilPracticante frmPerfilPracticante = new frmPerfilPracticante(this, userV.user, datosUsuario);
                    frmPerfilPracticante.Visible = true;
                    this.Visible = false;
                }
                else if (tipoP == "AUXILIAR") {
                    frmPerfilAuxiliar frmPerfilAuxiliar = new frmPerfilAuxiliar(this, userV.user, datosUsuario);
                    frmPerfilAuxiliar.Visible = true;
                    this.Visible = false;
                }
                
                else if (tipoP == "BIBLIOTECARIO")
                {
                    frmPerfilBibliotecario formBibliotecario = new frmPerfilBibliotecario(this, userV.user,datosUsuario);
                    formBibliotecario.Visible = true;
                    this.Visible = false;
                }
                else if (tipoP == "GESTOR") {
                    frmPerfilGestor formGestor = new frmPerfilGestor(this, userV.user, datosUsuario);
                    formGestor.Visible = true;
                    this.Visible = false;
                }
            }
            this.placeHolderUsuario.Text="";
            this.placeHolderUsuario.PlaceHolderText = "username@example.com";
            this.txtcontraseña.Text = "";
        }

        private void placeHolderUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOlvideCredenciales_Click(object sender, EventArgs e)
        {
            frmRecuperarClave formRC = new frmRecuperarClave(this);
            this.Visible = false;
            formRC.Show();
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar ==(char)13)          
                this.btnAcceder_Click(sender, e);
            
        }
    }
}
