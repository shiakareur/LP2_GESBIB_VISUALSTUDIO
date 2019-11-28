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
    public partial class frmModificarPuntoAtencion : Form
    {
        ServicioJava.puntosAtencion puntoAtMod;
        public frmModificarPuntoAtencion()
        {
            InitializeComponent();
            cmbPerfil.DataSource = new BindingList<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

            //Indicamos la Propiedad que debería visualizarse
            cmbPerfil.DisplayMember = "NombrePerfil";
            cmbPerfil.ValueMember = "Id";
        }
        public frmModificarPuntoAtencion(ServicioJava.puntosAtencion puntoAtencion)
        {
            InitializeComponent();
            PuntoAtMod = puntoAtencion;
            cmbPerfil.DataSource = new BindingList<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

            //Indicamos la Propiedad que debería visualizarse
            cmbPerfil.DisplayMember = "NombrePerfil";
            cmbPerfil.ValueMember = "Id";
            
            txtNombre.Text = puntoAtencion.nombre;
            txtPiso.Text = puntoAtencion.piso.ToString();
            txtCantMin.Text = puntoAtencion.cant_min_pers.ToString();
            txtCantOpt.Text = puntoAtencion.cant_opt_pers.ToString();
            cmbPerfil.SelectedValue = puntoAtencion.perfilExperiencia.id;
        }

        public puntosAtencion PuntoAtMod { get => puntoAtMod; set => puntoAtMod = value; }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PuntoAtMod.nombre = txtNombre.Text;
            PuntoAtMod.piso = Convert.ToInt32(txtPiso.Text);
            PuntoAtMod.cant_min_pers = Convert.ToInt32(txtCantMin.Text);
            PuntoAtMod.perfilExperiencia = (ServicioJava.perfilExperiencia)cmbPerfil.SelectedItem;
            PuntoAtMod.cant_opt_pers = Convert.ToInt32(txtCantOpt.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
