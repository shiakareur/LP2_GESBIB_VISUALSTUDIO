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
        ServicioJava.ServicioClient DBController = new ServicioJava.ServicioClient();

        
        public frmBuscarBiblioteca()
        {
            InitializeComponent();
            dgvBibliotecas.AutoGenerateColumns = false;
            dgvBibliotecas.DataSource = DBController.listarBibliotecas();
        }

        public ServicioJava.biblioteca BibliotecaSeleccionada { get => bibliotecaSeleccionada; set => bibliotecaSeleccionada = value; }

        private void dgvGestores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.biblioteca bibliotecaFila = (ServicioJava.biblioteca)dgvBibliotecas.Rows[e.RowIndex].DataBoundItem;
            dgvBibliotecas.Rows[e.RowIndex].Cells["Gestor"].Value = bibliotecaFila.gestor.nombre+" "+ bibliotecaFila.gestor.apellido;
        }

        private void btnSeleccionarBib_Click(object sender, EventArgs e)
        {
            BibliotecaSeleccionada = (ServicioJava.biblioteca)dgvBibliotecas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarBib_Click(object sender, EventArgs e)
        {
            dgvBibliotecas.DataSource = DBController.listarBibliotecasPorNombre(bibliotecaSeleccionada.nombre);
        }
    }
}
