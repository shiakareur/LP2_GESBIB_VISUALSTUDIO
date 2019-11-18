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
    public partial class frmAsignarPersonalPuntoAtencion : Form
    {

        System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        List<String> horas = new List<String> { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};


        public frmAsignarPersonalPuntoAtencion()
        {
            InitializeComponent();
            bindingSource1.DataSource = horas;

            cmbHoraIni.DataSource = bindingSource1.DataSource;
            cmbHoraFin.DataSource = bindingSource1.DataSource;
            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "Name";
        }

        private void frmAsignarPersonalPuntoAtencion_Load(object sender, EventArgs e)
        {

        }

        private void lblPuntoAtencion_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoraFin_Click(object sender, EventArgs e)
        {

        }

        private void lblHoraInicio_Click(object sender, EventArgs e)
        {

        }

        private void cmbHoraIni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHoraFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
