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
        public frmCapacitaciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //poner el panel BIPO en visible

        }

        private void btnCrearDiaCapa_Click(object sender, EventArgs e)
        {
            frmCrearDiaCapacitacion frmCrearDiaPA = new frmCrearDiaCapacitacion();
            frmCrearDiaPA.Show();
            frmCrearDiaPA.Location = new Point(0, 0);
        }
    }
}
