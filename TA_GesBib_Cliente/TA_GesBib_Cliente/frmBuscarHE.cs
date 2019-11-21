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
    public partial class frmBuscarHE : Form
    {
        private ServicioJava.horaExtra hESeleccionada;
        private int var_id_usuario;
        ServicioJava.ServicioClient DBController = new ServicioJava.ServicioClient();
        public frmBuscarHE(int id_usuario)
        {
            InitializeComponent();
            dgvHorasExtra.AutoGenerateColumns = false;
            dtpFechaSeleccionada.Value = DateTime.Today;
            var_id_usuario = id_usuario;
            dgvHorasExtra.DataSource = DBController.listarHorasExtraPorFecha(var_id_usuario, dtpFechaSeleccionada.Value);
        }
        public ServicioJava.horaExtra HESeleccionada { get => hESeleccionada; set => hESeleccionada = value; }
        //private void dgvHorasExtra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{

        //    ServicioJava.horaExtra hEFila = (ServicioJava.horaExtra)dgvHorasExtra.Rows[e.RowIndex].DataBoundItem;
        //    dgvHorasExtra.Rows[e.RowIndex].Cells["Biblioteca"].Value = ServicioJava.horaExtra.biblioteca.nombre;
        //}
        //private void dgvGestores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{

        //    ServicioJava.gestor gestorFila = (ServicioJava.gestor)dgvHorasExtra.Rows[e.RowIndex].DataBoundItem;
        //    dgvHorasExtra.Rows[e.RowIndex].Cells["Biblioteca"].Value = gestorFila.biblioteca.nombre;
        //}

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            hESeleccionada = (ServicioJava.horaExtra)dgvHorasExtra.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvHorasExtra.DataSource = DBController.listarHorasExtraPorFecha(var_id_usuario, dtpFechaSeleccionada.Value);
        }
    }
}
