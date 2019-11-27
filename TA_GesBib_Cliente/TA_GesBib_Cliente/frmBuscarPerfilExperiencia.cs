using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_GesBib_Cliente.ServicioJava;

namespace TA_GesBib_Cliente
{
    public partial class frmBuscarPerfilExperiencia : Form
    {
        private ServicioJava.perfilExperiencia pESeleccionada;
        public frmBuscarPerfilExperiencia()
        {
            InitializeComponent();
            dgvPerfiles.AutoGenerateColumns = false;
            dgvPerfiles.DataSource = Program.DBController.listarPerfilExperiencia();
        }

        public perfilExperiencia PESeleccionada { get => pESeleccionada; set => pESeleccionada = value; }

        private void btnSeleccionarBib_Click(object sender, EventArgs e)
        {
            PESeleccionada = (ServicioJava.perfilExperiencia)dgvPerfiles.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvGestores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ServicioJava.perfilExperiencia perfilFila = (ServicioJava.perfilExperiencia)dgvPerfiles.Rows[e.RowIndex].DataBoundItem;
            dgvPerfiles.Rows[e.RowIndex].Cells["Nombre"].Value = perfilFila.nombrePerfil;
        }

    }
}
