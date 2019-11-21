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
    public partial class frmBuscarPersonalBiblioteca : Form
    {
        BindingList<ServicioJava.bibliotecario> listaPersonal;
        ServicioJava.personal personal;

        public personal Personal { get => personal; set => personal = value; }

        public frmBuscarPersonalBiblioteca()
        {
            InitializeComponent();
            dgvPersonal.AutoGenerateColumns = false;
            listaPersonal = new BindingList<ServicioJava.bibliotecario>(Program.DBController.listarBibliotecarios("",""));
            dgvPersonal.DataSource = listaPersonal;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            personal = (ServicioJava.personal)dgvPersonal.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
