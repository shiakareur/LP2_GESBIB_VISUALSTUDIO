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
    public partial class frmSolicitarHL : Form
    {

        private frmPerfilBibliotecario var_perfilBibliotecario;
        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        public frmSolicitarHL()
        {
            InitializeComponent();
        }

        public frmSolicitarHL(frmPerfilBibliotecario formPerfBiblio)
        {
            var_perfilBibliotecario = formPerfBiblio;
            InitializeComponent();
        }
        public frmSolicitarHL(Form formPerfilPersonal, TipoPerfil tipoPerfil)
        {
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (var_tipoPerfil)
            {
                case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    this.var_perfilBibliotecario.LblBienvenido.Visible = true;
                    this.var_perfilBibliotecario.PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    ((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
