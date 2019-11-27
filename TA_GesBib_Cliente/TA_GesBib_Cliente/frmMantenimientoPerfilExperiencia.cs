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
    public partial class frmMantenimientoPerfilExperiencia : Form
    {

        private Estado estadoForm;

        private ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        private ServicioJava.perfilExperiencia var_perfil_experiencia_seleccionada;

        public frmMantenimientoPerfilExperiencia()
        {
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

            ServicioJava.perfilExperiencia perfil_experiencia = new ServicioJava.perfilExperiencia();

            perfil_experiencia.nombrePerfil = txtNombre.Text;

            //llamamos al SERVICIO RESPECTIVO
            try
            {
                if (estadoForm == Estado.Nuevo)
                    servTA.insertarPerfilExperiencia(perfil_experiencia);
                else if (estadoForm == Estado.Modificar)
                {
                    //servTA.actualizarPerfilExperiencia(perfil_experiencia);
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
            frmBuscarPerfilExperiencia var_buscarPerfilExp = new frmBuscarPerfilExperiencia();
            if (var_buscarPerfilExp.ShowDialog() == DialogResult.OK)
            {
                var_perfil_experiencia_seleccionada = var_buscarPerfilExp.PESeleccionada;

                txtNombre.Text = var_perfil_experiencia_seleccionada.nombrePerfil;

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

                //servTA.eliminarPerfilExperiencia(var_perfil_experiencia_seleccionada.id);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void estadoComponentes(Estado estado)
        {

            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblNombre.Enabled = false;

                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //Campos de Texto
                    txtNombre.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblNombre.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtNombre.Enabled = true;
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
                    lblNombre.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    //Campos de Texto
                    txtNombre.Enabled = true;
                    break;


            }

        }

        public void limpiarComponentes()
        {

            txtNombre.Text = "";

        }

        private void muestraMensajeExitoso()
        {
            //mostramos mensaje de error
            MessageBox.Show("Se guardaron los cambios exitosamente!",
                "Mensaje");
        }
    }
}
