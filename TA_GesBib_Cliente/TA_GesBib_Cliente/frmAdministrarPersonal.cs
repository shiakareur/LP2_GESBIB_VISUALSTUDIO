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
    public partial class frmAdministrarPersonal : Form
    {
        Estado estadoPersonal;
        private ServicioJava.personalBiblioteca personal;
        private ServicioJava.bibliotecario bibliotecario;
        private ServicioJava.auxiliar auxiliar;
        private ServicioJava.practicante practicante;

        public frmAdministrarPersonal()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            //Obtenemos las bibliotecas desde BD
            BindingList<ServicioJava.biblioteca> bibliotecas =
                new BindingList<ServicioJava.biblioteca>(
            Program.DBController.listarBibliotecas());

            //Enlazamos el ComboBox con las bibliotecas obtenidas
            cmbBibAisg.DataSource = Program.DBController.listarBibliotecas();

            //Indicamos la Propiedad que debería visualizarse
            cmbBibAisg.DisplayMember = "Nombre";
            cmbBibAisg.ValueMember = "Id";
        }

        public frmAdministrarPersonal(frmPerfilAdministrador formPerfilAdmin)
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            //Obtenemos las bibliotecas desde BD
            BindingList<ServicioJava.biblioteca> bibliotecas =
                new BindingList<ServicioJava.biblioteca>(
            Program.DBController.listarBibliotecas());

            //Enlazamos el ComboBox con las bibliotecas obtenidas
            cmbBibAisg.DataSource = Program.DBController.listarBibliotecas();

            //Indicamos la Propiedad que debería visualizarse
            cmbBibAisg.DisplayMember = "Nombre";
            cmbBibAisg.ValueMember = "Id";
        }

        //Estados
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    //Etiquetas
                    lblcodigoPers.Enabled = false;
                    lblNomPer.Enabled = false;
                    lblNomApe.Enabled = false;
                    lblFechaIng.Enabled = false;
                    lblCorreo.Enabled = false;
                    lblClave.Enabled = false;
                    lblTipo.Enabled = false;
                    lblBibAsig.Enabled = false;
                    lblDiaAsig.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtCodigo.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpFechaIng.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtClave.Enabled = false;
                    rbBibliotecario.Enabled = false;
                    rbAuxiliar.Enabled = false;
                    rbPracticante.Enabled = false;
                    cmbBibAisg.Enabled = false;
                    cmbDiaAsig.Enabled = false;
                    break;

                case Estado.Nuevo:
                    //Etiquetas
                    lblcodigoPers.Enabled = true;
                    lblNomPer.Enabled = true;
                    lblNomApe.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblTipo.Enabled = true;
                    lblBibAsig.Enabled = true;
                    lblDiaAsig.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    rbBibliotecario.Enabled = true;
                    rbAuxiliar.Enabled = true;
                    rbPracticante.Enabled = true;
                    cmbBibAisg.Enabled = true;
                    cmbDiaAsig.Enabled = false;
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
                    lblcodigoPers.Enabled = true;
                    lblNomPer.Enabled = true;
                    lblNomApe.Enabled = true;
                    lblFechaIng.Enabled = true;
                    lblCorreo.Enabled = true;
                    lblClave.Enabled = true;
                    lblTipo.Enabled = true;
                    lblBibAsig.Enabled = true;
                    lblDiaAsig.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpFechaIng.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtClave.Enabled = true;
                    rbBibliotecario.Enabled = true;
                    rbAuxiliar.Enabled = true;
                    rbPracticante.Enabled = true;
                    cmbBibAisg.Enabled = true;
                    cmbDiaAsig.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaIng.Value = DateTime.Today;
            txtCorreo.Text = "";
            txtClave.Text = "";
            rbBibliotecario.Checked = false;
            rbAuxiliar.Checked = false;
            rbPracticante.Checked = false;

            txtCorreo.Text = "";
            cmbBibAisg.SelectedIndex = 0;
            cmbDiaAsig.SelectedIndex = -1;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();

            //Instanciamos uno nuevo
            bibliotecario = new ServicioJava.bibliotecario();
            auxiliar = new ServicioJava.auxiliar();
            practicante = new ServicioJava.practicante();

            estadoPersonal = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbBibliotecario.Checked==true)
            {
                ServicioJava.bibliotecario bib = new ServicioJava.bibliotecario();
                bib.codigo = txtCodigo.Text;
                bib.nombre = txtNombres.Text;
                bib.apellido = txtApellidos.Text;
                bib.fecha_ingreso = dtpFechaIng.Value;
                bib.fecha_ingresoSpecified = true;
                bib.email = txtCorreo.Text;
                bib.contrasenia = txtClave.Text;
                bib.biblioteca = (ServicioJava.biblioteca)cmbBibAisg.SelectedItem;
                if (cmbDiaAsig.SelectedIndex != -1)
                {
                    bib.diaSemana = cmbDiaAsig.SelectedItem.ToString();
                }
                else {
                    bib.diaSemana = "0";
                }
                


                if (estadoPersonal == Estado.Nuevo)
                {
                    Program.DBController.insertarBibliotecario(bib);
                    MessageBox.Show("Bibliotecario Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (estadoPersonal == Estado.Modificar)
                {
                    bib.id = bibliotecario.id;
                    Program.DBController.actualizarBibliotecario(bib);
                    MessageBox.Show("Se han actualizado los datos del bibliotecario", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if (rbAuxiliar.Checked == true)
            {
                ServicioJava.auxiliar aux = new ServicioJava.auxiliar();
                aux.codigo = txtCodigo.Text;
                aux.nombre = txtNombres.Text;
                aux.apellido = txtApellidos.Text;
                aux.fecha_ingreso = dtpFechaIng.Value;
                aux.fecha_ingresoSpecified = true;
                aux.email = txtCorreo.Text;
                aux.contrasenia = txtClave.Text;
                aux.biblioteca = (ServicioJava.biblioteca)cmbBibAisg.SelectedItem;
                if (estadoPersonal == Estado.Nuevo)
                {
                    Program.DBController.insertarAuxiliarBiblioteca(aux);
                    MessageBox.Show("Auxiliar registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (estadoPersonal == Estado.Modificar)
                {
                    aux.id = auxiliar.id;
                    Program.DBController.actualizarAuxiliarBiblioteca(aux);
                    MessageBox.Show("Se han actualizado los datos del auxiliar", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if(rbPracticante.Checked==true){
                ServicioJava.practicante prac = new ServicioJava.practicante();
                prac.codigo = txtCodigo.Text;
                prac.nombre = txtNombres.Text;
                prac.apellido = txtApellidos.Text;
                prac.fecha_ingreso = dtpFechaIng.Value;
                prac.fecha_ingresoSpecified = true;
                prac.email = txtCorreo.Text;
                prac.contrasenia = txtClave.Text;
                prac.biblioteca = (ServicioJava.biblioteca)cmbBibAisg.SelectedItem;
                if (estadoPersonal == Estado.Nuevo)
                {
                    Program.DBController.insertarPracticante(prac);
                    MessageBox.Show("Practicante registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (estadoPersonal == Estado.Modificar)
                {
                    prac.id = auxiliar.id;
                    Program.DBController.actualizarPracticante(prac);
                    MessageBox.Show("Se han actualizado los datos del practicante", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalBiblioteca frmBuscarPersonal = new frmBuscarPersonalBiblioteca();
            if (frmBuscarPersonal.ShowDialog() == DialogResult.OK)
            {
                personal=(ServicioJava.personalBiblioteca)frmBuscarPersonal.Personal;
                if (frmBuscarPersonal.Personal is ServicioJava.bibliotecario)
                {
                    bibliotecario = (ServicioJava.bibliotecario)frmBuscarPersonal.Personal;
                    txtCodigo.Text = bibliotecario.codigo;
                    txtNombres.Text = bibliotecario.nombre;
                    txtApellidos.Text = bibliotecario.apellido;
                    txtCorreo.Text = bibliotecario.email;
                    txtClave.Text = bibliotecario.contrasenia;
                    dtpFechaIng.Value = bibliotecario.fecha_ingreso;
                    cmbBibAisg.SelectedValue = bibliotecario.biblioteca.id;
                    if (bibliotecario.diaSemana == "0") {
                        cmbDiaAsig.SelectedIndex = -1;
                    }
                    else {
                        cmbDiaAsig.SelectedItem = bibliotecario.diaSemana;
                    }
                    
                    rbBibliotecario.Checked = true;                }
                else if (frmBuscarPersonal.Personal is ServicioJava.auxiliar)
                {
                    auxiliar = (ServicioJava.auxiliar)frmBuscarPersonal.Personal;
                    txtCodigo.Text = auxiliar.codigo;
                    txtNombres.Text = auxiliar.nombre;
                    txtApellidos.Text = auxiliar.apellido;
                    txtCorreo.Text = auxiliar.email;
                    txtClave.Text = auxiliar.contrasenia;
                    dtpFechaIng.Value = auxiliar.fecha_ingreso;
                    cmbBibAisg.SelectedValue = auxiliar.biblioteca.id;
                    cmbDiaAsig.Enabled = false;
                    rbAuxiliar.Checked = true;
                }
                else if (frmBuscarPersonal.Personal is ServicioJava.practicante)
                {
                    practicante = (ServicioJava.practicante)frmBuscarPersonal.Personal;
                    txtCodigo.Text = practicante.codigo;
                    txtNombres.Text = practicante.nombre;
                    txtApellidos.Text = practicante.apellido;
                    txtCorreo.Text = practicante.email;
                    txtClave.Text = practicante.contrasenia;
                    dtpFechaIng.Value = practicante.fecha_ingreso;
                    cmbBibAisg.SelectedValue = practicante.biblioteca.id;
                    cmbDiaAsig.Enabled = false;
                    rbPracticante.Checked = true;
                }
                estadoComponentes(Estado.Buscar);


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Volver al estado inicial
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void rbBibliotecario_Click(object sender, EventArgs e)
        {
            cmbDiaAsig.Enabled = true;
        }

        private void rbAuxiliar_Click(object sender, EventArgs e)
        {
            cmbDiaAsig.SelectedIndex = -1;
            cmbDiaAsig.Enabled = false;
        }

        private void rbPracticante_Click(object sender, EventArgs e)
        {
            cmbDiaAsig.SelectedIndex = -1;
            cmbDiaAsig.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoPersonal = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
            if (rbBibliotecario.Checked == true)
                cmbDiaAsig.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este trabajador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Program.DBController.eliminarPersonalBiblioteca(personal.id);
                MessageBox.Show("El trabajador ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
        }
    }
}
