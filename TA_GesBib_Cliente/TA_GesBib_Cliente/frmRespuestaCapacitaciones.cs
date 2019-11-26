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
    public partial class frmRespuestaCapacitaciones : Form
    {

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;
        private ServicioJava.usuario var_usuario;

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        public frmRespuestaCapacitaciones()
        {
            InitializeComponent();
        }


        public frmRespuestaCapacitaciones(Form formPerfilPersonal, TipoPerfil tipoPerfil,
            ServicioJava.usuario _user)
        {
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            var_usuario = _user;

            InitializeComponent();

            //autogenrates columns = false...            
            dgvRespCapac.AutoGenerateColumns = false;
            dgvAceptadas.AutoGenerateColumns = false;

            //Cargar data
            //dgvRespCapac.DataSource = Program.DBController.listarCapacitaciones();//lsita todas

            //aca lista todas de este usuario q aun estan por confirmar
            dgvRespCapac.DataSource =
              Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, -1);

            //luego debe lsitar al listar capas aceptadas por este personal
            dgvAceptadas.DataSource = 
                Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id,1);
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
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    //((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    //((frmPerfilPracticante)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void dgvRespCapac_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            ServicioJava.capacitacion _capa = dgvRespCapac.Rows[e.RowIndex].DataBoundItem
                         as ServicioJava.capacitacion;

            dgvRespCapac.Rows[e.RowIndex].Cells[0].Value = _capa.nombre;
            dgvRespCapac.Rows[e.RowIndex].Cells[1].Value = _capa.descripcion;

        }

       

        private void btnGuardarPen_Click(object sender, EventArgs e)
        {
            //aca llamamos al servicio de ACTUALIZAR las capas q acabo de aceptar

            //c debe recorrer todos los checkbox q este en true
            //.. e ir actualizando uno x uno
            //dgvRespCapac.datas


            /*
             foreach (DataGridViewRow r in tuDataGridView.Rows)
    {
        CheckBox ck = (CheckBox) r.Cells[0].Value;
        if (ck.Checked)
        {
            
        }
        else
        {
            
        }


    }
             */


        }

        private void btnGuardarAcep_Click(object sender, EventArgs e)
        {
            //ACA DEBE ACTUALIZAR OSEA LLAMAR AL STORE PROCEDURE CON 1
        }

        private void dgvAceptadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.capacitacion _capa = dgvAceptadas.Rows[e.RowIndex].DataBoundItem
                       as ServicioJava.capacitacion;

            dgvAceptadas.Rows[e.RowIndex].Cells[0].Value = _capa.nombre;
            dgvAceptadas.Rows[e.RowIndex].Cells[1].Value = _capa.descripcion;
        }

        private void btnActAceptadas_Click(object sender, EventArgs e)
        {
            //llamamos al servicio de actualizar capas aceptadas

            dgvAceptadas.DataSource =
           Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, 1);

        }
    }
}
