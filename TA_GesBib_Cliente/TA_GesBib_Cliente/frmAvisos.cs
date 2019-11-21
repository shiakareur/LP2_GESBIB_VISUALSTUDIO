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
    public partial class frmAvisos : Form
    {
        ServicioJava.usuario _user;
        Estado estadoForm;
        ServicioJava.aviso aviso;
        private Form var_formGestor;

        public frmAvisos()
        {
            InitializeComponent();
        }
        public void limpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtTitulo.Text = "";

        }

        public frmAvisos(Form formPerfil, ServicioJava.usuario usuario)
        {
            var_formGestor = formPerfil;
            InitializeComponent();
            _user = usuario;
            limpiarComponentes();
            estadoForm = Estado.Inicial;
            estadoComponentes(estadoForm);
        }


        public void estadoComponentes(Estado estado)
        {

            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblNomBib.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    //DGV
                    //Campos de Texto
                    txtTitulo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblNomBib.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    //Campos de Texto
                    txtTitulo.Enabled = true;
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
                    lblNomBib.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtTitulo.Enabled = true;
                    break;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoForm = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creamos el gestor
            ServicioJava.aviso aviso = new ServicioJava.aviso();

            aviso.descripcion = txtDescripcion.Text;
            string est = cmbEstado.SelectedItem.ToString();
            if (est == "ACTIVO")
            {
                aviso.activo = 1;
            }
            else {
                aviso.activo = 0; 
            }
            
            aviso.titulo = txtTitulo.Text;

            ServicioJava.gestor g = new ServicioJava.gestor();
            g.id = _user.id;
            aviso.gestor = g;



            if (estadoForm == Estado.Nuevo)
            {
                Program.DBController.insertarAviso(aviso);
                //Mostramos un mensaje de exito
                MessageBox.Show("Gestor Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoForm == Estado.Modificar)
            {
                //ges.id = gestor.id;

                Program.DBController.actualizarAviso(aviso);

                MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //poner el panel BIPO en visible
            ((frmPerfilGestor)var_formGestor).PanelBIPO.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();

            //Instanciamos uno nuevo
            aviso = new ServicioJava.aviso();

            estadoForm = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }
    }
}
