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

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        private ServicioJava.usuario var_usuario;


        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        public frmRegInasistencias()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
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
            estadoComponentes(Estado.Inicial);

            //cargamos los tipos de inasistencia en el combo box
            cmbTipo_Inasistencia.DataSource = servTA.listarTipoInasistencia();
            cmbTipo_Inasistencia.ValueMember = "nombre";


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se pone los LABELS ENABLES
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //poner limpiar los labels
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioJava.inasistencia inasis = new ServicioJava.inasistencia();

            try
            {
                inasis.tipoInasistencia =
                    ((ServicioJava.inasistencia)cmbTipo_Inasistencia.SelectedItem).tipoInasistencia;
            }
            catch (Exception ex)
            {
                System.Console.Write("ASD");
            }
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
                servTA.insertarInasistencia(inasis);
            }
            catch (Exception ex)
            {
                System.Console.Write("ASD");
            }
            

            //mostramos mensaje de registro exitoso           
            estadoComponentes(Estado.Inicial);
            this.muestraMensajeExitoso();
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

                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //Campos de Texto
                    cmbTipo_Inasistencia.Enabled = false;
                    dtpRegInasis.Enabled = false;
                    txtHIni_Inasis.Enabled = false;
                    txtHFin_Inasis.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblElija.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_Inasis.Enabled = true;
                    txtHFin_Inasis.Enabled = true;
                    cmbTipo_Inasistencia.Enabled = true;
                    dtpRegInasis.Enabled = true;
                    break;

            }

        }


        public void limpiarComponentes()
        {

            txtHIni_Inasis.Text = "";
            txtHFin_Inasis.Text = "";
            cmbTipo_Inasistencia.ResetText();
            dtpRegInasis.Value = DateTime.Today;

        }

        private void muestraMensajeExitoso()
        {
            //mostramos mensaje de error
            MessageBox.Show("Se guardaron los cambios exitosamente !",
                "Mensajillo");
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
    }
}
