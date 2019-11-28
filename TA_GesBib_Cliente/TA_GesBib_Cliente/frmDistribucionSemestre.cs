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
    public partial class frmDistribucionSemestre : Form
    {

        private Form var_perfil;

        public frmDistribucionSemestre()
        {
            InitializeComponent();
        }
        public frmDistribucionSemestre(Form formPerfil, ServicioJava.usuario user)
        {
            var_perfil = formPerfil;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((frmPerfilGestor)this.var_perfil).PanelBIPO.Visible = true;
        }


    }
}
