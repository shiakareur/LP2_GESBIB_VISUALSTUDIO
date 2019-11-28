using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_GesBib_Cliente
{
    public partial class frmGenerarReportes : Form
    {
        public frmGenerarReportes()
        {
            InitializeComponent();
        }

        private void guardarReporteInasistencias_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (guardarReporteInasistencias.ShowDialog() == DialogResult.OK)
            {
                byte[] arreglo = Program.DBController.generarReporteInasistencias(Convert.ToInt32(textBox1.Text),
                                    Convert.ToDateTime(dateTimePicker5.Value), Convert.ToDateTime(dateTimePicker2.Value));

                File.WriteAllBytes(guardarReporteInasistencias.FileName + ".pdf", arreglo);
                //mensaje final
                MessageBox.Show("Se descargo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                byte[] arreglo = Program.DBController.generarReporteHorasTrabajadas(Convert.ToInt32(textBox3.Text),
                                    Convert.ToDateTime(dateTimePicker4.Value), Convert.ToDateTime(dateTimePicker1.Value));

                File.WriteAllBytes(saveFileDialog1.FileName + ".pdf", arreglo);
                //mensaje final
                MessageBox.Show("Se descargo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // saveFileDialog2
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                byte[] arreglo = Program.DBController.generarReporteDistribucion(Convert.ToInt32(textBox2.Text),
                                    Convert.ToDateTime(dtpFecha.Value), Convert.ToDateTime(dateTimePicker3.Value));

                File.WriteAllBytes(saveFileDialog2.FileName + ".pdf", arreglo);
                //mensaje final
                MessageBox.Show("Se descargo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
