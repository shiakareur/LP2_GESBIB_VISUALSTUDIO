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
    public partial class frmCrearPuntoAtencion : Form
    {
        ServicioJava.puntosAtencion puntoAtCreado;

        public puntosAtencion PuntoAtCreado { get => puntoAtCreado; set => puntoAtCreado = value; }

        public frmCrearPuntoAtencion()
        {
            InitializeComponent();
            cmbPerfil.DataSource = new BindingList<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

            //Indicamos la Propiedad que debería visualizarse
            cmbPerfil.DisplayMember = "NombrePerfil";
            cmbPerfil.ValueMember = "Id";

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            puntoAtCreado = new ServicioJava.puntosAtencion();
            puntoAtCreado.nombre = txtNombre.Text;
            puntoAtCreado.piso = Convert.ToInt32(txtPiso.Text);
            puntoAtCreado.cant_min_pers = Convert.ToInt32(txtCantMin.Text);
            puntoAtCreado.perfilExperiencia = (ServicioJava.perfilExperiencia)cmbPerfil.SelectedItem;
            puntoAtCreado.cant_opt_pers = Convert.ToInt32(txtCantOpt.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
