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

        private Estado estadoForm;

        private ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        private ServicioJava.usuario var_usuario;

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        private ServicioJava.horaExtra var_hora_extra_seleccionada;

        public frmRegHE()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);
        }

        //se agrego


        public frmRegHE(Form formPerfilPersonal, TipoPerfil tipoPerfil, ServicioJava.usuario _user)
        {
            var_usuario = _user;
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();
            limpiarComponentes();
            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);
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

            //saco la data del form

            ServicioJava.horaExtra hora_extra = new ServicioJava.horaExtra();

            hora_extra.personal = new ServicioJava.personal();
            hora_extra.personal.id = var_usuario.id;

            hora_extra.fecha = dtpFechaHE.Value;
            hora_extra.fechaSpecified = true;

            //la hora en time
            hora_extra.horaInicio = txtHIni_HE.Text;
            hora_extra.horaFin = txtHFin_HE.Text;

            hora_extra.cantidadHoras = Int32.Parse(txtCantHoras_HE.Text);
            hora_extra.descripcion = txtDescripcion_HE.Text;

            //llamamos al SERVICIO RESPECTIVO
            try
            {
                if (estadoForm == Estado.Nuevo)
                    servTA.insertarHoraExtra(hora_extra);
                else if (estadoForm == Estado.Modificar)
                {
                    hora_extra.justificado = -1;
                    servTA.actualizarHoraExtra(hora_extra);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);

            //mostramos mensaje de registro exitoso
            this.muestraMensajeExitoso();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarHE var_frmBuscarHe = new frmBuscarHE(var_usuario.id);
            if (var_frmBuscarHe.ShowDialog() == DialogResult.OK)
            {
                var_hora_extra_seleccionada = var_frmBuscarHe.HESeleccionada;

                dtpFechaHE.Value = var_hora_extra_seleccionada.fecha;

                //la hora en time
                txtHIni_HE.Text = var_hora_extra_seleccionada.horaInicio;
                txtHFin_HE.Text = var_hora_extra_seleccionada.horaFin;

                txtCantHoras_HE.Text = var_hora_extra_seleccionada.cantidadHoras.ToString();
                txtDescripcion_HE.Text = var_hora_extra_seleccionada.descripcion;
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

                servTA.eliminarHoraExtra(var_hora_extra_seleccionada.id);
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

            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);
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
                    lblCantHoras.Enabled = false;
                    lblDescripcion.Enabled = false;
                    lblHMS_ini.Enabled = false;
                    lblHMS_fin.Enabled = false;

                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
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
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtHIni_HE.Enabled = true;
                    txtHFin_HE.Enabled = true;
                    txtCantHoras_HE.Enabled = true;
                    dtpFechaHE.Enabled = true;
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
                    lblCantHoras.Enabled = true;
                    lblDescripcion.Enabled = true;
                    lblHMS_ini.Enabled = true;
                    lblHMS_fin.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
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
            MessageBox.Show("Se guardaron los cambios exitosamente!",
                "Mensaje");
        }


    }
}