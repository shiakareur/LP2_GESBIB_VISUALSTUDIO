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
    public partial class frmModificarDiaCapacitacion : Form
    {
        ServicioJava.diaCapacitacion diaCapacitacionSeleccionada;
        public frmModificarDiaCapacitacion()
        {
            InitializeComponent();
        }
        public frmModificarDiaCapacitacion(DateTime dato1, String dato2, String dato3)
        {
            InitializeComponent();
            dtpFechaIng.Value = dato1;
            dtpHoraIni.Value = Convert.ToDateTime(dato2);
            dtpHoraFin.Value = Convert.ToDateTime(dato3);
        }
        public diaCapacitacion DiaCapacitacionSeleccionada { get => diaCapacitacionSeleccionada; set => diaCapacitacionSeleccionada = value; }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            diaCapacitacionSeleccionada = new ServicioJava.diaCapacitacion();
            diaCapacitacionSeleccionada.fecha = dtpFechaIng.Value;
            diaCapacitacionSeleccionada.fechaSpecified = true;
            diaCapacitacionSeleccionada.hora_ini = dtpHoraIni.Value.ToString();
            diaCapacitacionSeleccionada.hora_fin = dtpHoraFin.Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
