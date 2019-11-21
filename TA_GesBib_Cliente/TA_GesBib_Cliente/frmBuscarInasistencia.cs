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
    public partial class frmBuscarInasistencia : Form
    {
        private ServicioJava.inasistencia inasistenciaSeleccionada;
        private int var_id_usuario;
        ServicioJava.ServicioClient DBController = new ServicioJava.ServicioClient();
        public frmBuscarInasistencia(int id_usuario)
        {
            InitializeComponent();
            dgvInasistencias.AutoGenerateColumns = false;
            dtpFechaSeleccionada.Value = DateTime.Today;
            var_id_usuario = id_usuario;
            dgvInasistencias.DataSource = DBController.listarInasistenciasPorFecha(var_id_usuario, dtpFechaSeleccionada.Value);
        }
        public ServicioJava.inasistencia InasistenciaSeleccionada { get => inasistenciaSeleccionada; set => inasistenciaSeleccionada = value; }
        private void dgvInasistencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.inasistencia inasistenciaFila = (ServicioJava.inasistencia)dgvInasistencias.Rows[e.RowIndex].DataBoundItem;
            dgvInasistencias.Rows[e.RowIndex].Cells[0].Value = inasistenciaFila.fecha;
            dgvInasistencias.Rows[e.RowIndex].Cells[1].Value = inasistenciaFila.horaInicio;
            dgvInasistencias.Rows[e.RowIndex].Cells[2].Value = inasistenciaFila.horaFin;
            dgvInasistencias.Rows[e.RowIndex].Cells[3].Value = inasistenciaFila.tipoInasistencia.nombre;
        }
        //private void dgvGestores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{

        //    ServicioJava.gestor gestorFila = (ServicioJava.gestor)dgvGestores.Rows[e.RowIndex].DataBoundItem;
        //    dgvGestores.Rows[e.RowIndex].Cells["Biblioteca"].Value = gestorFila.biblioteca.nombre;
        //}

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            inasistenciaSeleccionada = (ServicioJava.inasistencia)dgvInasistencias.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvInasistencias.DataSource = DBController.listarInasistenciasPorFecha(var_id_usuario, dtpFechaSeleccionada.Value);
        }
    }
}
