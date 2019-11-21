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
    public partial class frmValidaciones : Form
    {
        List<ServicioJava.inasistencia> listaSolicitudes=new List<ServicioJava.inasistencia>();
        private Form var_formGestor;
        ServicioJava.personal personalSeleccionado;
        BindingList<ServicioJava.inasistencia> lista;

        public frmValidaciones()
        {
            InitializeComponent();
        }
        public frmValidaciones(Form formPerfil, ServicioJava.usuario usuario)
        {
            InitializeComponent();
            var_formGestor = formPerfil;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalBiblioteca formBuscar = new frmBuscarPersonalBiblioteca();
            if (formBuscar.ShowDialog() == DialogResult.OK) {
                personalSeleccionado = formBuscar.Personal;
                txtNombre.Text = personalSeleccionado.nombre +" " +personalSeleccionado.apellido;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<TextBox> listaTXT = new List<TextBox>{ txtDescripcionVal1, txtDescripcionVal2, txtDescripcionVal3, txtDescripcionVal4 };
            List<DateTimePicker> listaDTP = new List<DateTimePicker> { dtpFecha1, dtpFecha2, dtpFecha3, dtpFecha4};
            List<TextBox> listaHI = new List<TextBox> { txtHoraIni1, txtHoraIni2, txtHoraIni3, txtHoraIni4};
            List<TextBox> listaHF = new List<TextBox> { txtHoraFin1, txtHoraFin2, txtHoraFin3, txtHoraFin4 };
            lista = new BindingList<ServicioJava.inasistencia>(Program.DBController.listarHorasLibre(personalSeleccionado.id, -1));
            
            int j = 0;
            foreach (ServicioJava.inasistencia i in lista){
                listaSolicitudes.Add(i);
                listaTXT[j].Text = i.motivo;
                listaDTP[j].Value = i.fecha;
                listaHI[j].Text = i.horaInicio;
                listaHF[j].Text = i.horaFin;

                j++;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //poner el panel BIPO en visible
            ((frmPerfilGestor)var_formGestor).PanelBIPO.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<RadioButton> listaRBSI = new List<RadioButton> { rbSi1 , rbSi2 , rbSi3 , rbSi4 };
            List<RadioButton> listaRBNO = new List<RadioButton> { rbNo1 , rbNo2, rbNo3, rbNo4};



            int i = 0;
            foreach (RadioButton rSi in listaRBSI) {
                if (rSi.Checked) {
                    listaSolicitudes[i].personal = new ServicioJava.personal();
                    listaSolicitudes[i].personal.id = personalSeleccionado.id;

                    ServicioJava.tipoInasistencia _tipoIna = new ServicioJava.tipoInasistencia();
                    _tipoIna.id = 4;     
                    listaSolicitudes[i].tipoInasistencia = _tipoIna;
                    listaSolicitudes[i].justificado = 1;
                    Program.DBController.actualizarInasistencia(listaSolicitudes[i]);
                }
                i++;

            }
            int j = 0;
            foreach (RadioButton rNo in listaRBNO)
            {
                if (rNo.Checked)
                {
                    listaSolicitudes[j].personal = new ServicioJava.personal();
                    listaSolicitudes[j].personal.id = personalSeleccionado.id;

                    ServicioJava.tipoInasistencia _tipoIna = new ServicioJava.tipoInasistencia();
                    _tipoIna.id = 4;
                    listaSolicitudes[j].tipoInasistencia = _tipoIna;
                    listaSolicitudes[j].justificado = 0;
                    Program.DBController.actualizarInasistencia(listaSolicitudes[j]);
                }
                j++;

            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionVal4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraIni4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoraFin4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void rbSi4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
