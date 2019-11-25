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

        Estado estadoInasistencia;
        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();
        private ServicioJava.inasistencia inaSelec;
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
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

             

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            //this.var_perfilPersonal.pan

            //se pone los LABELS ENABLES
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
            estadoInasistencia = Estado.Nuevo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //poner limpiar los labels
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                        

            //VERIFIFCAR Q TODOS LOS CAMPOS SEAN OBLIGATORIOS
                     
            if (dtpHoraFin.Value == dtpHoraIni.Value)
            {
                //hora fin menor o igual que la hora inicio
                //mostramos mensaje de error
                MessageBox.Show("ERROR , ¡Las horas deben ser diferentes!",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpHoraFin.Value < dtpHoraIni.Value)
            {
                //hora fin menor que la hora inicio
                //mostramos mensaje de error
                MessageBox.Show("ERROR , ¡La hora fin debe ser mayor que la hora inicio!",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(txtMotivo_HL.Text=="" | txtMotivo_HL.Text=="   "){
                MessageBox.Show("ERROR , ¡Debe ingresar un motivo!",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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
                inaHL.horaInicio = dtpHoraIni.Value.ToString();
                inaHL.horaFin = dtpHoraFin.Value.ToString();
                //inaHL.horaInicio = txtHIni_HL.Text;
                //inaHL.horaFin = txtHFin_HL.Text;

                //motivo
                inaHL.motivo = txtMotivo_HL.Text;

                //llamamos al SERVICIO RESPECTIVO
                if (estadoInasistencia == Estado.Nuevo)
                {
                    servTA.insertarInasistencia(inaHL);
                }
                else if (estadoInasistencia == Estado.Modificar)
                {
                    //sacar el id de la inaistencia seleccionada
                    inaHL.id = inaSelec.id;
                    inaHL.justificado = -1;
                    //inaHL.activo = 1 //??????????????????????????????
                    servTA.actualizarInasistencia(inaHL);
                }


                //mostramos mensaje de registro exitoso                    
                this.muestraMensajeExitoso();

                estadoComponentes(Estado.Inicial);
            }



            
        }

        


        public void limpiarComponentes()
        {

            //txtHIni_HL.Text = "";
            //txtHFin_HL.Text = "";        

            txtMotivo_HL.Text = "";
            dtpSoliHL.Value = DateTime.Today;

            dtpHoraIni.Value = Convert.ToDateTime("01/01/1753 08:00");
            dtpHoraFin.Value = Convert.ToDateTime("01/01/1753 23:00");
            

        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarHL formBuscarHL = new frmBuscarHL(var_usuario);


            if (formBuscarHL.ShowDialog() == DialogResult.OK)
            {
                //pasamos al form la solicitud de la inasistencia seleccionada
                inaSelec = new ServicioJava.inasistencia();
                inaSelec = formBuscarHL.Ina_HoraLibSelecc;


                dtpSoliHL.Value = inaSelec.fecha;
                //txtHIni_HL.Text = inaSelec.horaInicio;
                //txtHFin_HL.Text = inaSelec.horaFin;
                dtpHoraIni.Value = Convert.ToDateTime(inaSelec.horaInicio);
                dtpHoraFin.Value = Convert.ToDateTime(inaSelec.horaFin);
                txtMotivo_HL.Text = inaSelec.motivo;

                estadoComponentes(Estado.Buscar);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Modificar);
            estadoInasistencia = Estado.Modificar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //esta seguro que desea eliminar            

            DialogResult result = MessageBox.Show("Seguro que desea eliminar esta solicitud?", "Eliminar", 
                MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                servTA.eliminarInasistencia(inaSelec.id);
                //mostramos mensaje de eliminacion exitosa
                MessageBox.Show("Se elimino correctamente la solicitud de Hora Libre !",
                    "Mensajillo");
                limpiarComponentes();
            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
            }          




        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblMotivo.Enabled = false;
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
                    dtpSoliHL.Enabled = false;
                    dtpHoraIni.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblMotivo.Enabled = true;
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
                    txtMotivo_HL.Enabled = true;
                    dtpSoliHL.Enabled = true;
                    dtpHoraIni.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    break;
                case Estado.Buscar:
                    //Etiquetas
                    lblMotivo.Enabled = false;
                    lblFecha.Enabled = false;
                    lblHIni.Enabled = false;
                    lblHFin.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;
                    //Botones
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    dtpHoraFin.Enabled = false;
                    dtpHoraIni.Enabled = false;
                    dtpSoliHL.Enabled = false;
                    break;

                case Estado.Modificar:
                    //Etiquetas
                    lblMotivo.Enabled = true;
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnEliminar.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtMotivo_HL.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    dtpHoraIni.Enabled = true;
                    dtpSoliHL.Enabled = true;
                    break;

            }

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
                    //((frmPerfilBibliotecario)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelAviso.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelBIPO.Visible = true;

                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    //((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    break;
                default:
                    break;
            }
        }

    }
}
