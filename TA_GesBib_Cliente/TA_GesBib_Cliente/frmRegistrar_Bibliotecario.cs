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
    public partial class frmRegistrar_Bibliotecario : Form
    {
        private frmPerfilBibliotecario var_perfilBibliotecario;
        public frmRegistrar_Bibliotecario()
        {
            

            InitializeComponent();

            //this.var_perfilBibliotecario.Location = new System.Drawing.Point(0, 0);
            //aca poner el location




        }

        public frmRegistrar_Bibliotecario(frmPerfilBibliotecario formPerfBiblio)
        {
            var_perfilBibliotecario = formPerfBiblio;
            InitializeComponent();
        }

        //boton click cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
                       

            this.var_perfilBibliotecario.LblBienvenido.Visible = true;
            this.var_perfilBibliotecario.PanelAviso.Visible = true;
        }

        private void btnRegistrar_HE_Click(object sender, EventArgs e)
        {
            //llamar al servicio

            //ServicioArianator.insertarHorasExtra();

        }

        private void btnRegistrar_Inasis_Click(object sender, EventArgs e)
        {
            //llamar al servicio

            //ServicioArianator.insertarInasistencia();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();


            this.var_perfilBibliotecario.LblBienvenido.Visible = true;
            this.var_perfilBibliotecario.PanelAviso.Visible = true;
        }
    }
}
