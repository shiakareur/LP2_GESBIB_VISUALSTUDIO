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
    public partial class frmBuscarCapacitacion : Form
    {
        private ServicioJava.capacitacion capacitacionSeleccionada;
        public frmBuscarCapacitacion()
        {
            InitializeComponent();
            dgvBuscarCapacitacion.AutoGenerateColumns = false;
            dgvBuscarCapacitacion.DataSource = Program.DBController.listarCapacitaciones();
        }
        public ServicioJava.capacitacion CapacitacionSeleccionada { get => capacitacionSeleccionada; set => capacitacionSeleccionada = value; }
        private void btnSeleccionarBib_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
