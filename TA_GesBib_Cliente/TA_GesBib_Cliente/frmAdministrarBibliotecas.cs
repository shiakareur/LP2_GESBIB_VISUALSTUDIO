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
    public partial class frmAdministrarBibliotecas : Form
    {
        private ServicioJava.biblioteca biblioteca;
        private ServicioJava.gestor gestor;
        private Estado estadoBiblioteca;
        private BindingList<ServicioJava.puntosAtencion> listaPAasignados;

        //Si lo abro sin LOGIN
        public frmAdministrarBibliotecas()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }
        //Si lo abro con LOGIN
        public frmAdministrarBibliotecas(frmPerfilAdministrador formPerfilAdmin)
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }

        //Estados
        public void estadoComponentes(Estado estado){

            switch (estado){
                case Estado.Inicial:
                    //Etiquetas
                    lblCodGestor.Enabled = false;
                    lblNomBib.Enabled = false;
                    lblNomGes.Enabled = false;                   
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnAgregarPA.Enabled = false;
                    btnQuitarPA.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscarGestor.Enabled = false;
                    //DGV
                    dgvPuntosAtencion.Enabled = false;
                    //Campos de Texto
                    txtNombreBib.Enabled = false;
                    txtCodigo.Enabled = false;
                    txtNombreGestor.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblCodGestor.Enabled = true;
                    lblNomBib.Enabled = true;
                    lblNomGes.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnAgregarPA.Enabled = true;
                    btnQuitarPA.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnBuscarGestor.Enabled = true;
                    //Campos de Texto
                    txtNombreBib.Enabled = true;
                    txtCodigo.Enabled = true;
                    txtNombreGestor.Enabled = true;
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
                    lblCodGestor.Enabled = true;
                    lblNomBib.Enabled = true;
                    lblNomGes.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNombreBib.Enabled = true;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            txtNombreBib.Text = "";
            txtCodigo.Text = "";
            txtNombreGestor.Text = "";
            dgvPuntosAtencion.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creamos la biblioteca
            ServicioJava.biblioteca bib = new ServicioJava.biblioteca();

            bib.nombre = txtNombreBib.Text;
            try
            {
                bib.gestor.nombre = txtNombreGestor.Text;
            }catch(Exception ex)
            {
                System.Console.WriteLine("Error en gestor");
            }
            
            bib.gestor.codigo = txtCodigo.Text;

            if (estadoBiblioteca == Estado.Nuevo)
            {
                Program.DBController.insertarBiblioteca(bib);
                //Mostramos un mensaje de exito
                MessageBox.Show("Biblioteca Registrada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoBiblioteca == Estado.Modificar)
            {
                Program.DBController.actualizarBiblioteca(bib);
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
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            biblioteca = new ServicioJava.biblioteca();
            listaPAasignados = new BindingList<ServicioJava.puntosAtencion>();
            dgvPuntosAtencion.AutoGenerateColumns = false;
            dgvPuntosAtencion.DataSource = listaPAasignados;
            estadoBiblioteca = Estado.Nuevo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarBiblioteca frmBuscarBib = new frmBuscarBiblioteca();
            if (frmBuscarBib.ShowDialog() == DialogResult.OK)
            {
                try{
                    biblioteca = frmBuscarBib.BibliotecaSeleccionada;
                    txtNombreBib.Text = biblioteca.nombre;
                    txtNombreGestor.Text = biblioteca.gestor.nombre + " " + biblioteca.gestor.apellido;
                    txtCodigo.Text = biblioteca.gestor.id.ToString();

                    listaPAasignados = new BindingList<ServicioJava.puntosAtencion>(biblioteca.listaPuntosAtencion);
                    dgvPuntosAtencion.AutoGenerateColumns = false;
                    dgvPuntosAtencion.DataSource = listaPAasignados;
                    estadoComponentes(Estado.Buscar);
                }
                catch (Exception ex){
                    System.Console.WriteLine("Error");
                }   
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnCrearPuntoAtencion_Click(object sender, EventArgs e)
        {
            frmCrearPuntoAtencion frmCrearPA = new frmCrearPuntoAtencion();
            frmCrearPA.Show();
            frmCrearPA.Location = new Point(0, 0);
        }
        private void btnBuscarGestor_Click(object sender, EventArgs e)
        {
            frmBuscarGestores formBuscarGestores = new frmBuscarGestores();
            formBuscarGestores.Show();
            formBuscarGestores.Location = new Point(0, 0);
        }
        private void btnAgregarPA_Click(object sender, EventArgs e)
        {
            frmCrearPuntoAtencion formCrearPA = new frmCrearPuntoAtencion();
            formCrearPA.Show();
            formCrearPA.Location = new Point(0, 0);
        }
        private void btnEditarPA_Click(object sender, EventArgs e)
        {
            frmModificarPuntoAtencion formmodificarPA = new frmModificarPuntoAtencion();
            formmodificarPA.Show();
            formmodificarPA.Location = new Point(0, 0);
        }

        private void dgvPuntosAtencion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try { 
                ServicioJava.puntosAtencion objPA = dgvPuntosAtencion.Rows[e.RowIndex].DataBoundItem as ServicioJava.puntosAtencion;
                dgvPuntosAtencion.Rows[e.RowIndex].Cells[0].Value = objPA.nombre;
                dgvPuntosAtencion.Rows[e.RowIndex].Cells[1].Value = objPA.piso;
                dgvPuntosAtencion.Rows[e.RowIndex].Cells[2].Value = objPA.cant_min_pers;
                dgvPuntosAtencion.Rows[e.RowIndex].Cells[3].Value = objPA.cant_opt_pers;
                dgvPuntosAtencion.Rows[e.RowIndex].Cells[4].Value = objPA.perfilExperiencia.nombrePerfil;
            }catch(Exception ex)
                {

                }
}
    }
}
