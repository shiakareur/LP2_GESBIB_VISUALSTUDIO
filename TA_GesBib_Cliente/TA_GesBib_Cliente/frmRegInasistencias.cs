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
    public partial class frmRegInasistencias : Form
    {
        //private frmPerfilBibliotecario var_perfilBibliotecario;
        private Estado estadoForm;

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        private ServicioJava.usuario var_usuario;


        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        private ServicioJava.inasistencia var_inasistencia_seleccionada;

        public frmRegInasistencias()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);
        }

        /*public frmRegInasistencias(frmPerfilBibliotecario formPerfBiblio)
        {
            var_perfilBibliotecario = formPerfBiblio;
            InitializeComponent();

            //cargamos el combo box de tipo inasistencia
            //servicio
            //DBController.listarInasistencia(); //<--- en el combobox showparam ...

        }*/

        public frmRegInasistencias(Form formPerfilPersonal, TipoPerfil tipoPerfil, ServicioJava.usuario _USER)
        {

            var_usuario = _USER;
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();

            limpiarComponentes();
            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);

            //cargamos los tipos de inasistencia en el combo box
            cmbTipo_Inasistencia.DataSource = servTA.listarTipoInasistencia();
            cmbTipo_Inasistencia.DisplayMember = "Nombre";
            cmbTipo_Inasistencia.ValueMember = "Id";

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se pone los LABELS ENABLES
            limpiarComponentes();

            estadoForm = Estado.Nuevo;
            estadoComponentes(estadoForm);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioJava.inasistencia inasis = new ServicioJava.inasistencia();

            inasis.personal = new ServicioJava.personal();
            inasis.personal.id = var_usuario.id;
            inasis.tipoInasistencia = new ServicioJava.tipoInasistencia();
            inasis.tipoInasistencia = (ServicioJava.tipoInasistencia)cmbTipo_Inasistencia.SelectedItem;
            inasis.fecha = dtpRegInasis.Value;
            inasis.horaInicio = txtHIni_Inasis.Text;
            inasis.horaFin = txtHFin_Inasis.Text;
            inasis.motivo = txtDescripcion_HE.Text;

            //llamamos al SERVICIO RESPECTIVO
            try
            {
                
                if (estadoForm == Estado.Nuevo)
                    servTA.insertarInasistencia(inasis);
                else if (estadoForm == Estado.Modificar)
                    servTA.actualizarInasistencia(inasis);
            }
            catch (Exception ex)
            {
                System.Console.Write(ex);
            }

            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);

            //mostramos mensaje de registro exitoso
            this.muestraMensajeExitoso();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarInasistencia var_frmBuscarInasistencia = new frmBuscarInasistencia(var_usuario.id);
            if (var_frmBuscarInasistencia.ShowDialog() == DialogResult.OK)
            {
                var_inasistencia_seleccionada = var_frmBuscarInasistencia.InasistenciaSeleccionada;

                cmbTipo_Inasistencia.SelectedValue = var_inasistencia_seleccionada.tipoInasistencia.id;
                dtpRegInasis.Value = var_inasistencia_seleccionada.fecha;
                txtHIni_Inasis.Text = var_inasistencia_seleccionada.horaInicio;
                txtHFin_Inasis.Text = var_inasistencia_seleccionada.horaFin;
                txtDescripcion_HE.Text = var_inasistencia_seleccionada.motivo;
            }

            estadoForm = Estado.Buscar;
            estadoComponentes(estadoForm);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoForm = Estado.Modificar;
            estadoComponentes(estadoForm);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                servTA.eliminarInasistencia(var_inasistencia_seleccionada.id);
                limpiarComponentes();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);

            this.muestraMensajeExitoso();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //poner limpiar los labels
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            switch (var_tipoPerfil)
            {
                /*case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    this.var_perfilBibliotecario.LblBienvenido.Visible = true;
                    this.var_perfilBibliotecario.PanelAviso.Visible = true;
                    break;*/
                case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    ((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public void estadoComponentes(Estado estado)
        {

            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblFecha.Enabled = false;
                    lblHIni.Enabled = false;
                    lblHFin.Enabled = false;
                    lblElija.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;
                    lblDescripcion.Enabled = false;

                    ///Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //Campos de Texto
                    cmbTipo_Inasistencia.Enabled = false;
                    dtpRegInasis.Enabled = false;
                    txtHIni_Inasis.Enabled = false;
                    txtHFin_Inasis.Enabled = false;
                    txtDescripcion_HE.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblElija.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    lblDescripcion.Enabled = true;

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    cmbTipo_Inasistencia.Enabled = true;
                    dtpRegInasis.Enabled = true;
                    txtHIni_Inasis.Enabled = true;
                    txtHFin_Inasis.Enabled = true;
                    txtDescripcion_HE.Enabled = true;
                    break;

                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;

                case Estado.Modificar:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblElija.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    lblDescripcion.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    cmbTipo_Inasistencia.Enabled = true;
                    dtpRegInasis.Enabled = true;
                    txtHIni_Inasis.Enabled = true;
                    txtHFin_Inasis.Enabled = true;
                    txtDescripcion_HE.Enabled = true;
                    break;
            }

        }


        public void limpiarComponentes()
        {
            cmbTipo_Inasistencia.ResetText();
            dtpRegInasis.Value = DateTime.Today;
            txtHIni_Inasis.Text = "";
            txtHFin_Inasis.Text = "";
            txtDescripcion_HE.Text = "";
        }

        private void muestraMensajeExitoso()
        {
            //mostramos mensaje de error
            MessageBox.Show("Se guardaron los cambios exitosamente !",
                "Mensaje");
        }
        
    }
}
