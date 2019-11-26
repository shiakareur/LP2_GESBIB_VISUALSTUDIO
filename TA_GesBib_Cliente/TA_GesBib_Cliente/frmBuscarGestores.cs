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
    public partial class frmBuscarGestores : Form
    {
        private ServicioJava.gestor gestorSeleccionado;
        ServicioJava.ServicioClient DBController = new ServicioJava.ServicioClient();
        public frmBuscarGestores()
        {
            InitializeComponent();
            dgvGestores.AutoGenerateColumns = false;
            dgvGestores.DataSource = DBController.listarGestores(txtNombre.Text, txtApellido.Text);
        }
        public frmBuscarGestores(string cad)
        {
            InitializeComponent();
            dgvGestores.AutoGenerateColumns = false;
            dgvGestores.DataSource = DBController.listarGestores(txtNombre.Text, txtApellido.Text);
        }
        public ServicioJava.gestor GestorSeleccionado { get => gestorSeleccionado; set => gestorSeleccionado = value; }
        private void dgvGestores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ServicioJava.gestor gestorFila = (ServicioJava.gestor)dgvGestores.Rows[e.RowIndex].DataBoundItem;
            dgvGestores.Rows[e.RowIndex].Cells["Biblioteca"].Value = gestorFila.biblioteca.nombre;
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            GestorSeleccionado = (ServicioJava.gestor)dgvGestores.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvGestores.DataSource = DBController.listarGestores(txtNombre.Text, txtApellido.Text);
        }
    }
}
