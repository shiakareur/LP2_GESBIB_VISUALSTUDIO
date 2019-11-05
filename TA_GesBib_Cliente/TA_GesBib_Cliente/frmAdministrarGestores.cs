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
    public partial class frmAdministrarGestores : Form
    {
        //Estado estadoForm;
        ServicioJava.ServicioClient servGesBib = new ServicioJava.ServicioClient();

        

        

               
        private frmPerfilAdministrador var_formPerfilAdmin;
        public frmAdministrarGestores()
        {
            InitializeComponent();

            //Al abrir el form, este es el estado de los componentes
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        public frmAdministrarGestores(frmPerfilAdministrador formPerfilAdmin)
        {
            var_formPerfilAdmin = formPerfilAdmin;
            InitializeComponent();
            //Al abrir el form, este es el estado de los componentes
            limpiarComponentes();

            //cargamos el combobox de biblioteca asignada
            cmbBibAisg.DataSource = servGesBib.listarBibliotecas();
            cmbBibAisg.ValueMember = "Nombre";
            estadoComponentes(Estado.Inicial);
        }

        //Estados
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblCodigo.Enabled = false;
                    lblNombres.Enabled = false;
                    lblApellidos.Enabled = false;
                    lblFechaNac.Enabled = false;
                    lblFechaIng.Enabled = false;
                    lblCorreo.Enabled = false;
                    lblClave.Enabled = false;
                    lblBibAsig.Enabled = false;
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
                    dtpFechaNac.Enabled = false;
                    dtpFechaIng.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtClave.Enabled = false;
                    cmbBibAisg.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblCodigo.Enabled = true;
                    lblNombres.Enabled = true;
                    lblApellidos.Enabled = true;
                    lblFechaNac.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblBibAsig.Enabled = true;
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
                    dtpFechaNac.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    cmbBibAisg.Enabled = true;
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
                    lblCodigo.Enabled = true;
                    lblNombres.Enabled = true;
                    lblApellidos.Enabled = true;
                    lblFechaNac.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblBibAsig.Enabled = true;

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
                    dtpFechaNac.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    cmbBibAisg.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaNac.Value = DateTime.Today;
            dtpFechaIng.Value = DateTime.Today;
            txtCorreo.Text = "";
            txtClave.Text = "";

            txtCorreo.Text = "";

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

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creamos el gestor
            ServicioJava.gestor ges = new ServicioJava.gestor();

            ges.codigo = txtCodigo.Text;
            ges.nombre = txtNombres.Text;
            ges.apellido = txtApellidos.Text;
            ges.fecha_ingreso = dtpFechaIng.Value;
            ges.fecha_ingresoSpecified = true;
            ges.email = txtCorreo.Text;
            ges.contrasenia = txtClave.Text;
            ges.biblioteca = (ServicioJava.biblioteca)cmbBibAisg.SelectedItem;


            //llamamos al servicio
            try
            {
                servGesBib.insertarGestor(ges);
            }
            catch(Exception ex)
            {

            }
            




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
            this.Hide();
        }
    }
}
