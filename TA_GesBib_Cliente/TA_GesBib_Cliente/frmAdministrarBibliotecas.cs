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
        //para estados
        Estado estadoObjBiblioteca;
        //Servicio
        ServicioJava.ServicioClient servGesBib = new ServicioJava.ServicioClient();
        //Gestor
        ServicioJava.biblioteca biblioteca = new ServicioJava.biblioteca();
        private frmPerfilAdministrador var_formPerfilAdmin;
        public frmAdministrarBibliotecas()
        {
            InitializeComponent();

            //Al abrir el form, este es el estado de los componentes
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
            
        }

        public frmAdministrarBibliotecas(frmPerfilAdministrador formPerfilAdmin)
        {
            //var_formPerfilAdmin = formPerfilAdmin;
            InitializeComponent();
            
        }

        //Estados
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblNombre.Enabled = false;
                    lblGestorAsig.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtNombreBib.Enabled = false;

                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblNombre.Enabled = true;
                    lblGestorAsig.Enabled = true;

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNombreBib.Enabled = true;

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
                    lblNombre.Enabled = true;
                    lblGestorAsig.Enabled = true;


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


        }

        private void frmAdministrarPersonal_Load(object sender, EventArgs e)
        {   
           
            //this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //var_formPerfilAdmin.LblBienvenido.Visible = true;
            //var_formPerfilAdmin.PanelAviso.Visible = true;
        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

            if (estadoObjBiblioteca == Estado.Nuevo)
            {
                servGesBib.insertarBiblioteca(bib);
                //Mostramos un mensaje de exito
                MessageBox.Show("Biblioteca Registrada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObjBiblioteca == Estado.Modificar)
            {
                servGesBib.actualizarBiblioteca(bib);
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
            biblioteca = new ServicioJava.biblioteca();

            estadoObjBiblioteca = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //frmBuscarBiblioteca frmBuscarBib = new frmBuscarBiblioteca();
            //if (frmBuscarBib.ShowDialog() == DialogResult.OK)
            //{
            //    estadoComponentes(Estado.Buscar);
            //}

            frmBuscarBiblioteca frmBuscarBib = new frmBuscarBiblioteca();
            if (frmBuscarBib.ShowDialog() == DialogResult.OK)
            {
                biblioteca = frmBuscarBib.BibliotecaSeleccionada;
                txtNombreBib.Text = biblioteca.nombre;
                //txtNombreGestor.Text = biblioteca.gestor.nombre + " " + biblioteca.gestor.apellido;
                txtNombreGestor.Text = biblioteca.gestor.id.ToString();
                txtCodigo.Text = biblioteca.gestor.codigo;
                dgvPuntosAtencion.DataSource = servGesBib.listarPuntosAtencion(biblioteca.id);
                estadoComponentes(Estado.Buscar);
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
