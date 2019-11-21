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
    public partial class frmBuscarPersonalDisponible : Form
    {
        ServicioJava.personal personalSeleccionado = new ServicioJava.personal();
        public frmBuscarPersonalDisponible()
        {
            InitializeComponent();

        }
        public frmBuscarPersonalDisponible(DateTime fecha, string horaIni, string horaFin, string perfil)
        {
            InitializeComponent();
            try
            {
                dgvPersonal.DataSource = Program.DBController.listarUsuariosLibres(fecha, horaIni, horaFin, perfil);

            }
            catch (Exception ex)
            {
                System.Console.Write("Error");
            }
        }

        public personal PersonalSeleccionado { get => personalSeleccionado; set => personalSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            personalSeleccionado = (ServicioJava.personal)dgvPersonal.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
