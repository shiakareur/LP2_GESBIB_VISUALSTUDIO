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
    public partial class frmAsignarTurnos : Form
    {


        private frmPerfilGestor var_formPerfilGestor;

        public frmAsignarTurnos()
        {
            InitializeComponent();
        }

        public frmAsignarTurnos(frmPerfilGestor formPerfilGestor)
        {
            var_formPerfilGestor = formPerfilGestor;
            InitializeComponent();
        }

        private void frmAsignarTurnos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var_formPerfilGestor.PanelBIPO.Visible = true;
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
