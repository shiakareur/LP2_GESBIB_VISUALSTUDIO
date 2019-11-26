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
    public partial class frmCapacitaciones : Form
    {
        private Form var_formGestor;

        public frmCapacitaciones()
        {
            InitializeComponent();
        }

        public frmCapacitaciones(Form _formPerfilGestor)
        {
            var_formGestor = _formPerfilGestor;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            //poner el panel BIPO en visible
            ((frmPerfilGestor)var_formGestor).PanelBIPO.Visible = true;

        }

        private void btnCrearDiaCapa_Click(object sender, EventArgs e)
        {
            frmCrearDiaCapacitacion frmCrearDiaPA = new frmCrearDiaCapacitacion();
            frmCrearDiaPA.Show();
            frmCrearDiaPA.Location = new Point(0, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
