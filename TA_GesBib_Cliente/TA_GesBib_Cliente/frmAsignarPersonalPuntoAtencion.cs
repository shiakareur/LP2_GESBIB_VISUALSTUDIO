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
        System.Windows.Forms.BindingSource bindingSource2 = new System.Windows.Forms.BindingSource();
        List<String> horas = new List<String> { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};
        List<String> horas2 = new List<String> { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};
        ServicioJava.personal personal = new ServicioJava.personal();

        public frmAsignarPersonalPuntoAtencion()
        {
            InitializeComponent();
            bindingSource1.DataSource = horas;
            bindingSource2.DataSource = horas2;

            cmbHoraIni.DataSource = bindingSource1.DataSource;
            cmbHoraFin.DataSource = bindingSource2.DataSource;
            dgvPersonal.AutoGenerateColumns = false;

            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "Name";
        }

        public frmAsignarPersonalPuntoAtencion(ServicioJava.biblioteca bib, ServicioJava.puntosAtencion puntoA, DateTime fecha, int col)
        {
            InitializeComponent();
            bindingSource1.DataSource = horas;
            bindingSource2.DataSource = horas2;

            cmbHoraIni.DataSource = bindingSource1.DataSource;
            cmbHoraFin.DataSource = bindingSource2.DataSource;
            dgvPersonal.AutoGenerateColumns = false;

            txtBib.Text = bib.nombre;
            txtPtoAtencion.Text = puntoA.nombre;
            txtCantMin.Text = puntoA.cant_min_pers.ToString();
            txtCantOpt.Text = puntoA.cant_opt_pers.ToString();
            txtPerfil.Text = puntoA.perfilExperiencia.nombrePerfil;
            dtpFecha.Value = fecha;
            cmbHoraIni.SelectedIndex = col-1;
            cmbHoraFin.SelectedIndex = col;


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

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalDisponible formBuscar = new frmBuscarPersonalDisponible();
            if (formBuscar.ShowDialog() == DialogResult.OK) {
                //personal=
            }
            //dtpFecha.Value, (string)cmbHoraFin.SelectedItem, (string)cmbHoraFin.SelectedValue, txtPerfil.Text

            //   frmBuscarInasistencia var_frmBuscarInasistencia = new frmBuscarInasistencia(var_usuario.id);
            //if (var_frmBuscarInasistencia.ShowDialog() == DialogResult.OK)
            //{
            //    var_inasistencia_seleccionada = var_frmBuscarInasistencia.InasistenciaSeleccionada;

            //    cmbTipo_Inasistencia.SelectedValue = var_inasistencia_seleccionada.tipoInasistencia.id;
            //    dtpRegInasis.Value = var_inasistencia_seleccionada.fecha;
            //    txtHIni_Inasis.Text = var_inasistencia_seleccionada.horaInicio;
            //    txtHFin_Inasis.Text = var_inasistencia_seleccionada.horaFin;
            //    txtDescripcion_HE.Text = var_inasistencia_seleccionada.motivo;
            //}
        }
    }
}
