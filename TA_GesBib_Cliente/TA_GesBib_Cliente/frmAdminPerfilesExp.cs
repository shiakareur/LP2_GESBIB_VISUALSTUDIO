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
    public partial class frmAdminPerfilesExp : Form
    {
        private frmPerfilGestor var_formPerfilGestor;

        private List<ServicioJava.personalBiblioteca> listaPAsignados = new List<ServicioJava.personalBiblioteca>();

        public frmAdminPerfilesExp()
        {
            InitializeComponent();
        }

        public frmAdminPerfilesExp(frmPerfilGestor formPerfilGestor)
        {
            var_formPerfilGestor = formPerfilGestor;
            InitializeComponent();
            cmbPerfil.DataSource = new List<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

            //Indicamos la Propiedad que debería visualizarse
            cmbPerfil.DisplayMember = "NombrePerfil";
            cmbPerfil.ValueMember = "Id";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var_formPerfilGestor.PanelBIPO.Visible = true;
        }

        private void btnAdministrarPerfiles_Click(object sender, EventArgs e)
        {
            frmMantenimientoPerfilExperiencia var_mantenimientoPE = new frmMantenimientoPerfilExperiencia();
            var_mantenimientoPE.Location = new Point(0, 0);
            var_mantenimientoPE.Show();
            var_mantenimientoPE.Visible = false;
            if (var_mantenimientoPE.ShowDialog() == DialogResult.OK)
            {
                cmbPerfil.DataSource = new List<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

                //Indicamos la Propiedad que debería visualizarse
                cmbPerfil.DisplayMember = "NombrePerfil";
                cmbPerfil.ValueMember = "Id";
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //listaPAsignados = new List<ServicioJava.personalBiblioteca>();
            if(Program.DBController.listarPersonalAsignadoAPerfilExperiencia((int)cmbPerfil.SelectedValue) != null)
            {
                listaPAsignados = new List<ServicioJava.personalBiblioteca>(Program.DBController.listarPersonalAsignadoAPerfilExperiencia((int)cmbPerfil.SelectedValue));
            }
            else
            {
                listaPAsignados = new List<ServicioJava.personalBiblioteca>();
            }
            
            dgvPersonal.AutoGenerateColumns = false;
            dgvPersonal.DataSource = listaPAsignados;

        }

        private void dgvPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                ServicioJava.personalBiblioteca objPA = dgvPersonal.Rows[e.RowIndex].DataBoundItem as ServicioJava.personalBiblioteca;
                dgvPersonal.Rows[e.RowIndex].Cells["codigo"].Value = objPA.codigo;
                dgvPersonal.Rows[e.RowIndex].Cells["nombres"].Value = objPA.nombre;
                dgvPersonal.Rows[e.RowIndex].Cells["apellidos"].Value = objPA.apellido;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            

        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            frmBuscarPersonalBiblioteca formBuscarPersonal = new frmBuscarPersonalBiblioteca();
            formBuscarPersonal.Location = new Point(0, 0);
            if (formBuscarPersonal.ShowDialog() == DialogResult.OK)
            {
                ServicioJava.personalBiblioteca personalSeleccionado = (ServicioJava.personalBiblioteca)formBuscarPersonal.Personal;
                listaPAsignados.Add(personalSeleccionado);
                dgvPersonal.DataSource = null;
                dgvPersonal.DataSource = listaPAsignados;
            }
        }

        private void btnQuitarPersonal_Click(object sender, EventArgs e)
        {
            try
            {

                listaPAsignados.Remove((ServicioJava.personalBiblioteca)dgvPersonal.CurrentRow.DataBoundItem);
                dgvPersonal.DataSource = null;
                dgvPersonal.DataSource = listaPAsignados;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
