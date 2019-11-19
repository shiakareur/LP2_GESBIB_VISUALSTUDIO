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
    public partial class frmBuscarHL : Form
    {

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        public frmBuscarHL(ServicioJava.usuario _user)
        {
            InitializeComponent();
            dgvListaHL.AutoGenerateColumns = false;
            dgvListaHL.DataSource = servTA.listarHorasLibre(_user.id, -1);


        }

        private void dgvListaHL_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.inasistencia _inasis = dgvListaHL.Rows[e.RowIndex].DataBoundItem
                            as ServicioJava.inasistencia;

            dgvListaHL.Rows[e.RowIndex].Cells[0].Value = _inasis.fecha.ToString("yyyy/M/dd");
            dgvListaHL.Rows[e.RowIndex].Cells[1].Value = _inasis.horaInicio;
            dgvListaHL.Rows[e.RowIndex].Cells[2].Value = _inasis.horaFin;
            dgvListaHL.Rows[e.RowIndex].Cells[3].Value = _inasis.motivo;

        }
    }
}
