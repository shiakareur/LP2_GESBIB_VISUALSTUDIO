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
    public partial class frmBuscarPersonalConTodo : Form
    {
        private ServicioJava.personalBiblioteca personalSeleccionado;

        public personalBiblioteca PersonalSeleccionado { get => personalSeleccionado; set => personalSeleccionado = value; }

        public frmBuscarPersonalConTodo()
        {
            InitializeComponent();
            dgvPersonal.AutoGenerateColumns = false;
            dgvPersonal.DataSource = Program.DBController.listartodosobrepersonal(txtNombre.Text);
        }
        private void dgvPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ServicioJava.personalBiblioteca personal = (ServicioJava.personalBiblioteca)dgvPersonal.Rows[e.RowIndex].DataBoundItem;
            dgvPersonal.Rows[e.RowIndex].Cells["Codigo"].Value = personal.codigo;
            dgvPersonal.Rows[e.RowIndex].Cells["Nombres"].Value = personal.nombre;
            dgvPersonal.Rows[e.RowIndex].Cells["Apellidos"].Value = personal.apellido;
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            personalSeleccionado = (ServicioJava.personalBiblioteca)dgvPersonal.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvPersonal.DataSource = Program.DBController.listartodosobrepersonal(txtNombre.Text);
        }
    }
}
