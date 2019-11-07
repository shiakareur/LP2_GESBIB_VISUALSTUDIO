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
    public partial class frmRegHE : Form
    {


        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        public frmRegHE()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        //se agrego
 

        public frmRegHE(Form formPerfilPersonal, TipoPerfil tipoPerfil)
        {
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
            //Saco mi data

            //user.getnombre();
            //...



            //saco la data del form

            ServicioJava.horaExtra hora_extra = new ServicioJava.horaExtra();

            hora_extra.fecha = dtpFechaHE.Value;
            hora_extra.fechaSpecified = true;

            //la hora en time
            hora_extra.horaInicio = txtHIni_HE.Text;
            hora_extra.horaFin = txtHFin_HE.Text;

            hora_extra.cantidadHoras = Int32.Parse(txtCantHoras_HE.Text);
            hora_extra.descripcion = txtDescripcion_HE.Text;

            //llamamos al SERVICIO RESPECTIVO
            //Servicio<HoraExtra> hora_extra = new ServicioTA<HoraExtra>;
            //DBController.regHE(hora_extra);
            //mostramos mensaje de registro exitoso
            //....

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
                    lblCantHoras.Enabled = false;
                    lblDescripcion.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;
                   
                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //Campos de Texto
                    txtHIni_HE.Enabled = false;
                    txtHFin_HE.Enabled = false;
                    txtCantHoras_HE.Enabled = false;
                    dtpFechaHE.Enabled = false;
                    txtDescripcion_HE.Enabled = false;                  
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblCantHoras.Enabled = true;
                    lblDescripcion.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;                  
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_HE.Enabled = true;
                    txtHFin_HE.Enabled = true;
                    txtCantHoras_HE.Enabled = true;
                    dtpFechaHE.Enabled = true;
                    txtDescripcion_HE.Enabled = true;
                    break;
            
            }
            
        }


        public void limpiarComponentes()
        {
            
            txtHIni_HE.Text = "";
            txtHFin_HE.Text = "";
            txtCantHoras_HE.Text = "";
            txtDescripcion_HE.Text = "";
            dtpFechaHE.Value = DateTime.Today;           
            
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
