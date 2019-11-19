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
    public partial class frmAdministrarPersonal : Form
    {
        Estado estadoForm;

        private frmPerfilAdministrador var_formPerfilAdmin;
        public frmAdministrarPersonal()
        {
            InitializeComponent();

            //Al abrir el form, este es el estado de los componentes
			// Jin SSJ was here
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        public frmAdministrarPersonal(frmPerfilAdministrador formPerfilAdmin)
        {
            var_formPerfilAdmin = formPerfilAdmin;
            InitializeComponent();
            //Al abrir el form, este es el estado de los componentes
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        //Estados
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblcodigoPers.Enabled = false;
                    lblNomPer.Enabled = false;
                    lblNomApe.Enabled = false;
                    lblFechaIng.Enabled = false;
                    lblCorreo.Enabled = false;
                    lblClave.Enabled = false;
                    lblTipo.Enabled = false;
                    lblBibAsig.Enabled = false;
                    lblDiaAsig.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtCodigo.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpFechaIng.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtClave.Enabled = false;
                    rbBibliotecario.Enabled = false;
                    rbAuxiliar.Enabled = false;
                    rbPracticante.Enabled = false;
                    cmbBibAisg.Enabled = false;
                    cmbDiaAsig.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblcodigoPers.Enabled = true;
                    lblNomPer.Enabled = true;
                    lblNomApe.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblTipo.Enabled = true;
                    lblBibAsig.Enabled = true;
                    lblDiaAsig.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    rbBibliotecario.Enabled = true;
                    rbAuxiliar.Enabled = true;
                    rbPracticante.Enabled = true;
                    cmbBibAisg.Enabled = true;
                    cmbDiaAsig.Enabled = true;
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    lblcodigoPers.Enabled = true;
                    lblNomPer.Enabled = true;
                    lblNomApe.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblTipo.Enabled = true;
                    lblBibAsig.Enabled = true;
                    lblDiaAsig.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    rbBibliotecario.Enabled = true;
                    rbAuxiliar.Enabled = true;
                    rbPracticante.Enabled = true;
                    cmbBibAisg.Enabled = true;
                    cmbDiaAsig.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaIng.Value = DateTime.Today;
            txtCorreo.Text = "";
            txtClave.Text = "";
            rbBibliotecario.Checked = false;
            rbAuxiliar.Checked = false;
            rbPracticante.Checked = false;

            txtCorreo.Text = "";
            cmbBibAisg.SelectedIndex = -1;
            cmbDiaAsig.SelectedIndex = -1;

        }

        private void frmAdministrarPersonal_Load(object sender, EventArgs e)
        {   
           
            //this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //var_formPerfilAdmin.LblBienvenido.Visible = true;
            //var_formPerfilAdmin.PanelAviso.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Volver al estado inicial
            estadoComponentes(Estado.Inicial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Volver al estado inicial
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Volver al estado inicial
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalBiblioteca frmBuscarPersonalBib = new frmBuscarPersonalBiblioteca();
            if (frmBuscarPersonalBib.ShowDialog() == DialogResult.OK)
            {
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
