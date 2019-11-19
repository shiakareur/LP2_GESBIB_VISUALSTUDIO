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
    public partial class frmSolicitarHL : Form
    {

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();
        private ServicioJava.usuario var_usuario;
        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;


        public frmSolicitarHL()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }


        public frmSolicitarHL(Form formPerfilPersonal, TipoPerfil tipoPerfil, ServicioJava.usuario _user)
        {
            var_usuario = _user;
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
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
            ServicioJava.inasistencia inaHL = new ServicioJava.inasistencia();
            
            /*sacamos el id del personal y lo asignamos*/                        
            inaHL.personal = new ServicioJava.personal();
            inaHL.personal.id = var_usuario.id;
            
            //vamos a REGISTRAR una hora libre que es de tipo INASISTENCIA         
            ServicioJava.tipoInasistencia _tipoIna = new ServicioJava.tipoInasistencia();
            _tipoIna.id = 4;  //el ID de INASISTENCIA ES 4     
            inaHL.tipoInasistencia = _tipoIna;
            
            //fecha
            inaHL.fecha = dtpSoliHL.Value;
            inaHL.fechaSpecified = true;
            
            //hora inicio
            inaHL.horaInicio = txtHIni_HL.Text;
            inaHL.horaFin = txtHFin_HL.Text;
            
            //motivo
            inaHL.motivo = txtMotivo_HL.Text;

            //llamamos al SERVICIO RESPECTIVO
            servTA.insertarInasistencia(inaHL);

            //mostramos mensaje de registro exitoso                    
            this.muestraMensajeExitoso();

            estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblDescripcion.Enabled = false;
                    lblFecha.Enabled = false;
                    lblHIni.Enabled = false;
                    lblHFin.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;
                    //Botones
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //Campos de Texto
                    txtMotivo_HL.Enabled = false;
                    txtHIni_HL.Enabled = false;
                    txtHFin_HL.Enabled = false;
                    dtpSoliHL.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_HL.Enabled = true;
                    txtHFin_HL.Enabled = true;
                    dtpSoliHL.Enabled = true;
                    break;
                case Estado.Buscar:
                    //Etiquetas
                    lblDescripcion.Enabled = false;
                    lblFecha.Enabled = false;
                    lblHIni.Enabled = false;
                    lblHFin.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_HL.Enabled = true;
                    txtHFin_HL.Enabled = true;
                    dtpSoliHL.Enabled = true;
                    break;

                case Estado.Modificar:
                    //Etiquetas
                    lblDescripcion.Enabled = true;
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_HL.Enabled = true;
                    txtHFin_HL.Enabled = true;
                    dtpSoliHL.Enabled = true;
                    break;

            }

        }


        public void limpiarComponentes()
        {

            txtHIni_HL.Text = "";
            txtHFin_HL.Text = "";
            dtpSoliHL.Value = DateTime.Today;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarHL formBuscarHL = new frmBuscarHL(var_usuario);
            formBuscarHL.ShowDialog();


            if (formBuscarHL.ShowDialog() == DialogResult.OK)
            {
                //pasamos al form la solicitud de la inasistencia seleccionada

                dtpSoliHL.Value = formBuscarHL.Ina_HoraLibSelecc.fecha;
                txtHIni_HL.Text = formBuscarHL.Ina_HoraLibSelecc.horaInicio;
                txtHFin_HL.Text = formBuscarHL.Ina_HoraLibSelecc.horaFin;
                txtMotivo_HL.Text = formBuscarHL.Ina_HoraLibSelecc.motivo;




                estadoComponentes(Estado.Buscar);
            }




        }
    }
}
