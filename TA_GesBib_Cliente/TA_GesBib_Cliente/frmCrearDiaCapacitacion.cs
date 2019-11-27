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
    public partial class frmCrearDiaCapacitacion : Form
    {
        ServicioJava.diaCapacitacion diaCapacitacionSeleccionada;
        public frmCrearDiaCapacitacion()
        {
            InitializeComponent();
        }

        public diaCapacitacion DiaCapacitacionSeleccionada { get => diaCapacitacionSeleccionada; set => diaCapacitacionSeleccionada = value; }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diaCapacitacionSeleccionada = new ServicioJava.diaCapacitacion();
            diaCapacitacionSeleccionada.fecha = dtpFechaIng.Value;
            diaCapacitacionSeleccionada.fechaSpecified = true;
            diaCapacitacionSeleccionada.hora_ini = dtpHoraIni.Value.ToString();
            diaCapacitacionSeleccionada.hora_fin = dtpHoraFin.Value.ToString()
                ;
            this.DialogResult = DialogResult.OK;
        }
    }
}
