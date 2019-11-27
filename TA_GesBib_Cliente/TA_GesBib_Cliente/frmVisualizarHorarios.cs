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
    public partial class frmVisualizarHorarios : Form
    {

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;


        private ServicioJava.personal var_perABuscar;

        public frmVisualizarHorarios()
        {
            InitializeComponent();
        }


        public frmVisualizarHorarios(Form formPerfilPersonal, TipoPerfil tipoPerfil)
        {
           
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();

            this.dgvDistPersonal.AutoGenerateColumns = false;

            this.txtCodigo.Enabled = false;
            this.txtNombre.Enabled = false;
            this.lblNombre.Enabled = false;
            this.label1.Enabled = false;

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

        private void btnLupa_Click(object sender, EventArgs e)
        {

            frmBuscarPersonalBiblioteca formBuscarPersonal = 
                new frmBuscarPersonalBiblioteca();

            var_perABuscar = new ServicioJava.personal();
            var_perABuscar = formBuscarPersonal.Personal;

            if(formBuscarPersonal.ShowDialog() == DialogResult.OK)
            {
                this.txtCodigo.Text = formBuscarPersonal.Personal.codigo;
                this.txtNombre.Text = formBuscarPersonal.Personal.nombre;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //aca buscamos la DISTRIBUCION DE ESTE PERSONAL EN 
            //... LA FECHA INDICADA

            try
            {
                dgvDistPersonal.DataSource =
                Program.DBController.listarDistribPersonalenFecha(32, dtpFechaHorarios.Value);
            }
            catch(Exception ex)
            {

            }
            


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            ServicioJava.distribucionPersonal distPersonal = new ServicioJava.distribucionPersonal();

            distPersonal = dgvDistPersonal.Rows[e.RowIndex].DataBoundItem
                            as ServicioJava.distribucionPersonal;

            try
            {
                dgvDistPersonal.Rows[e.RowIndex].Cells[0].Value = distPersonal.personal.nombre;
                dgvDistPersonal.Rows[e.RowIndex].Cells[1].Value = distPersonal.personal.apellido;
                dgvDistPersonal.Rows[e.RowIndex].Cells[2].Value = distPersonal.puntoAtencion.nombre;
                dgvDistPersonal.Rows[e.RowIndex].Cells[3].Value = distPersonal.horaInicio;
                dgvDistPersonal.Rows[e.RowIndex].Cells[4].Value = distPersonal.horaFin;
            }
            catch(Exception ex)
            {

            }
            

        }
    }
}
