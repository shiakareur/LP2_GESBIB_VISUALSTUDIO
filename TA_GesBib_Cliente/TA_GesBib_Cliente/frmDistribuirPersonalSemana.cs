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
    public partial class frmDistribuirPersonalSemana : Form
    {
        private ServicioJava.distribucionPersonal distrib = new ServicioJava.distribucionPersonal();
        ServicioJava.ServicioClient DBController = new ServicioJava.ServicioClient();

        public frmDistribuirPersonalSemana()
        {
            InitializeComponent();
            dgvDitribucion.Rows[0].Cells[1].Style.BackColor = Color.PowderBlue;
            //dgvDitribucion.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //Daywisegrid.Rows[RowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
        }
        public frmDistribuirPersonalSemana(ServicioJava.usuario usuario)
        {
            InitializeComponent();
            dgvDitribucion.Rows[0].Cells[1].Style.BackColor = Color.PowderBlue;

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDitribucion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {

                if (e.RowIndex >= 0 && e.ColumnIndex>=1)
                {
                    frmAsignarPersonalPuntoAtencion formAsignarPersonal = new frmAsignarPersonalPuntoAtencion();
                    formAsignarPersonal.ShowDialog();
                }
            }
            catch (Exception) {
                System.Console.Write("Error");

            }
        }


    }
}
