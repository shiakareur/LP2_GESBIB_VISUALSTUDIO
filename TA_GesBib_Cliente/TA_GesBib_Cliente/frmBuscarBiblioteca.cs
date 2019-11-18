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
    public partial class frmBuscarBiblioteca : Form
    {
        private ServicioJava.biblioteca bibliotecaSeleccionada;
        public frmBuscarBiblioteca()
        {
            InitializeComponent();
            dgvBibliotecas.AutoGenerateColumns = false;
            dgvBibliotecas.DataSource = Program.DBController.listarBibliotecasPorNombre(txtNombre.Text);
        }

        public ServicioJava.biblioteca BibliotecaSeleccionada { get => bibliotecaSeleccionada; set => bibliotecaSeleccionada = value; }

        private void btnSeleccionarBib_Click(object sender, EventArgs e)
        {
            BibliotecaSeleccionada = (ServicioJava.biblioteca)dgvBibliotecas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarBib_Click(object sender, EventArgs e)
        {
            dgvBibliotecas.DataSource = Program.DBController.listarBibliotecasPorNombre(txtNombre.Text);
        }

        private void dgvBibliotecas_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.biblioteca objBiblio = dgvBibliotecas.Rows[e.RowIndex].DataBoundItem as ServicioJava.biblioteca;
            dgvBibliotecas.Rows[e.RowIndex].Cells[0].Value = objBiblio.nombre;
            dgvBibliotecas.Rows[e.RowIndex].Cells[1].Value = objBiblio.gestor.nombre + " " + objBiblio.gestor.apellido;
        }
    }
}
