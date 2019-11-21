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
        ServicioJava.personal personalSeleccionado;
        BindingList<ServicioJava.inasistencia> lista;

        public frmValidaciones()
        {
            InitializeComponent();
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
                listaTXT[j].Text = i.motivo;
                listaDTP[j].Value = i.fecha;
                listaHI[j].Text = i.horaInicio;
                listaHF[j].Text = i.horaFin;

                j++;

            }
        }
    }
}
