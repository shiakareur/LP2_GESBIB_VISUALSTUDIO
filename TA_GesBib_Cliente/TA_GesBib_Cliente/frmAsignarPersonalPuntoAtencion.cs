using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_GesBib_Cliente.ServicioJava;

namespace TA_GesBib_Cliente
{
    public partial class frmAsignarPersonalPuntoAtencion : Form
    {

        System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        System.Windows.Forms.BindingSource bindingSource2 = new System.Windows.Forms.BindingSource();
        List<String> horas = new List<String> { "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};
        List<String> horas2 = new List<String> { "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};
        ServicioJava.personal personal = new ServicioJava.personal();
        BindingList<ServicioJava.distribucionPersonal> listaDistPAForm=new BindingList<distribucionPersonal>();
        BindingList<ServicioJava.distribucionPersonal> listaNuevos=new BindingList<ServicioJava.distribucionPersonal>();


        ServicioJava.biblioteca bibForm;
        DateTime fechaForm;
        string horaIniForm, horaFinForm;
        ServicioJava.puntosAtencion puntoAtForm;
        ServicioJava.perfilExperiencia perfilForm;
        int cant = 0;

        public BindingList<distribucionPersonal> ListaDistPAForm { get => listaDistPAForm; set => listaDistPAForm = value; }
        public BindingList<distribucionPersonal> ListaNuevos { get => listaNuevos; set => listaNuevos = value; }

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

        public frmAsignarPersonalPuntoAtencion(ServicioJava.biblioteca bib, ServicioJava.puntosAtencion puntoA, BindingList<ServicioJava.distribucionPersonal> listaDistPA, DateTime fecha, int col)
        {
            InitializeComponent();
            bindingSource1.DataSource = horas;
            bindingSource2.DataSource = horas2;

            cmbHoraIni.DataSource = bindingSource1.DataSource;
            cmbHoraFin.DataSource = bindingSource2.DataSource;
            dgvPersonal.AutoGenerateColumns = false;

            bibForm = bib;
            fechaForm = fecha;
            ListaDistPAForm = listaDistPA;
            puntoAtForm = puntoA;



            txtBib.Text = bib.nombre;
            txtPtoAtencion.Text = puntoA.nombre;
            txtCantMin.Text = puntoA.cant_min_pers.ToString();
            txtCantOpt.Text = puntoA.cant_opt_pers.ToString();
            txtPerfil.Text = puntoA.perfilExperiencia.nombrePerfil;
            dtpFecha.Value = fecha;
            cmbHoraIni.SelectedIndex = col-1;
            cmbHoraFin.SelectedIndex = col;


            //llenar el dgv

            foreach (ServicioJava.distribucionPersonal d in ListaDistPAForm) {
                int finDist = Convert.ToInt32(d.horaFin.Substring(0, 2));
                int iniAsig = Convert.ToInt32(horas[col - 1].Substring(0, 2));
                int iniDist = Convert.ToInt32(d.horaInicio.Substring(0, 2));
                int finAsig = Convert.ToInt32(horas2[col].Substring(0, 2));


                if((iniAsig>=finDist) || (iniDist >= finAsig))
                {
                    continue;
                }
                else
                {
                    dgvPersonal.Rows.Add(d.personal.codigo, d.personal.nombre + " " + d.personal.apellido, d.horaInicio, d.horaFin);
                }

                    
                //dgvPersonal.Rows[cant].Cells[0].Value = d.personal.codigo;
                //dgvPersonal.Rows[cant].Cells[1].Value = d.personal.nombre + " " + d.personal.apellido;
                cant++;

            }

            horaFinForm = horas2[col]+":00";
            horaIniForm = horas[col-1]+":00";
            perfilForm = puntoA.perfilExperiencia;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServicioJava.distribucionPersonal d = new ServicioJava.distribucionPersonal();
            d.fecha = dtpFecha.Value;
            d.fechaSpecified = true;
            d.horaInicio = (string)cmbHoraIni.SelectedItem;
            d.horaFin = (string)cmbHoraFin.SelectedItem;
            d.personal = personal;
            d.puntoAtencion = puntoAtForm;

            ListaNuevos.Add(d);


            dgvPersonal.Rows.Add(personal.codigo, personal.nombre+" "+personal.apellido, d.horaInicio, d.horaFin);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //listaNuevos.Remove()
            dgvPersonal.Rows.Remove(dgvPersonal.CurrentRow);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (ServicioJava.distribucionPersonal d in ListaNuevos) {
                ServicioJava.distribucionPersonal nuevo = new ServicioJava.distribucionPersonal();
                //nuevo.fecha = d.fecha;
                //nuevo.fechaSpecified = true;
                //nuevo.horaInicio = d.horaInicio;
                //nuevo.horaFin = d.horaFin;
                //nuevo.personal = d.personal;
                //nuevo.puntoAtencion = d.puntoAtencion;


                //ListaDistPAForm.Add(nuevo);
                Program.DBController.insertarDistribucionPersonal(d);
            }
            this.DialogResult = DialogResult.OK;

        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalDisponible formBuscar = new frmBuscarPersonalDisponible(bibForm,fechaForm, horaIniForm, horaFinForm,perfilForm.nombrePerfil );
            if (formBuscar.ShowDialog() == DialogResult.OK) {
                personal = formBuscar.PersonalSeleccionado;
                txtCod.Text = personal.codigo;
                txtNombre.Text = personal.nombre + " "+personal.apellido;
                //txtPerfil.Text = perfilForm.nombrePerfil;
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
