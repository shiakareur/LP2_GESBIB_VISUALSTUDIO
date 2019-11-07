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
        //para estados
        Estado estadoObjGestor;
        //Servicio
        ServicioJava.ServicioClient servGesBib = new ServicioJava.ServicioClient();
        //Gestor
        ServicioJava.gestor gestor = new ServicioJava.gestor();
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

            //Obtenemos las especialidades desde BD
            BindingList<ServicioJava.biblioteca> bibliotecas =
                new BindingList<ServicioJava.biblioteca>(
            servGesBib.listarBibliotecas());

            //Enlazamos el ComboBox con las especialidades obtenidas
            cmbBibAisg.DataSource = servGesBib.listarBibliotecas();

            //Indicamos la Propiedad que debería visualizarse
            cmbBibAisg.DisplayMember = "Nombre";
            cmbBibAisg.ValueMember = "Id";
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
            dtpFechaIng.Value = DateTime.Today;
            txtCorreo.Text = "";
            txtClave.Text = "";

            txtCorreo.Text = "";

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

            //try
            //{
            //    servGesBib.insertarGestor(ges);
            //    //mensajito
            //    this.muestraMensajeExitoso();
            //}
            //catch (Exception ex)
            //{

            //}

            ////Volver al estado inicial
            //estadoComponentes(Estado.Inicial);

            if (estadoObjGestor == Estado.Nuevo)
            {
                servGesBib.insertarGestor(ges);
                //Mostramos un mensaje de exito
                MessageBox.Show("Gestor Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObjGestor == Estado.Modificar)
            {
                //servGesBib.actualizarGestor(ges);
                MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        limpiarComponentes();

        //Instanciamos uno nuevo
        gestor = new ServicioJava.gestor();

        estadoObjGestor = Estado.Nuevo;
        estadoComponentes(Estado.Nuevo);
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        frmBuscarGestores frmBuscarGestor = new frmBuscarGestores();
        if (frmBuscarGestor.ShowDialog() == DialogResult.OK)
        {
            gestor = frmBuscarGestor.GestorSeleccionado;
            txtCodigo.Text = gestor.codigo;
            txtNombres.Text = gestor.nombre;
            txtApellidos.Text = gestor.apellido;
            txtCorreo.Text = gestor.email;
            txtClave.Text = gestor.contrasenia;
            dtpFechaIng.Value = gestor.fecha_ingreso;
            cmbBibAisg.SelectedValue = gestor.biblioteca.id;
            estadoComponentes(Estado.Buscar);
        }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        estadoObjGestor = Estado.Modificar;
        estadoComponentes(Estado.Modificar);
    }

    }
}
