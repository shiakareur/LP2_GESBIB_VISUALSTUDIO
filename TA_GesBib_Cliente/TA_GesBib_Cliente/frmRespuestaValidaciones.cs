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
    public partial class frmRespuestaValidaciones : Form
    {

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;


        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        public frmRespuestaValidaciones()
        {
            InitializeComponent();
        }
  



        public frmRespuestaValidaciones(Form formPerfilPersonal, TipoPerfil tipoPerfil,
            ServicioJava.usuario _user)
        {
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();

            //autogenrates columns = false...            
            dgvRespValida_HE.AutoGenerateColumns = false;
            dgvVal_HoLibre.AutoGenerateColumns = false;
            dgvVal_Inasis.AutoGenerateColumns = false;
            dgvVal_CamTur.AutoGenerateColumns = false;


            //se carga con las validaciones
            dgvVal_HoLibre.DataSource = servTA.listarTodasHorasLibre(_user.id);
            dgvVal_Inasis.DataSource = servTA.listarInasistencias(_user.id);
            dgvRespValida_HE.DataSource = servTA.listarHorasExtra(_user.id);
            //......


        }


        private void frmRespuestaValidaciones_Load(object sender, EventArgs e)
        {

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

        private void dgvRespValida_HE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String validacion = "";
            ServicioJava.horaExtra _inasis = dgvRespValida_HE.Rows[e.RowIndex].DataBoundItem
                         as ServicioJava.horaExtra;
            dgvRespValida_HE.Rows[e.RowIndex].Cells[0].Value = _inasis.descripcion;
            if (_inasis.justificado == -1)
                validacion = "PENDIENTE";
            else if (_inasis.justificado == 0)
                validacion = "NO VALIDADO";
            else if (_inasis.justificado == 1)
                validacion = "VALIDADO";

            dgvRespValida_HE.Rows[e.RowIndex].Cells[1].Value = validacion;
        }

        private void dgvVal_Inasis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String validacion = "";
            ServicioJava.inasistencia _inasis = dgvVal_Inasis.Rows[e.RowIndex].DataBoundItem
                         as ServicioJava.inasistencia;
            dgvVal_Inasis.Rows[e.RowIndex].Cells[0].Value = _inasis.motivo;
            if (_inasis.justificado == -1)
                validacion = "PENDIENTE";
            else if (_inasis.justificado == 0)
                validacion = "NO VALIDADO";
            else if (_inasis.justificado == 1)
                validacion = "VALIDADO";

            dgvVal_Inasis.Rows[e.RowIndex].Cells[1].Value = validacion;
        }

        private void dgvVal_HoLibre_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String validacion = "";
            ServicioJava.inasistencia _inasis = dgvVal_HoLibre.Rows[e.RowIndex].DataBoundItem
                         as ServicioJava.inasistencia;
            dgvVal_HoLibre.Rows[e.RowIndex].Cells[0].Value = _inasis.motivo;
            if (_inasis.justificado == -1)
                validacion = "PENDIENTE";
            else if (_inasis.justificado == 0)
                validacion = "NO VALIDADO";
            else if (_inasis.justificado == 1)
                validacion = "VALIDADO";

            dgvVal_HoLibre.Rows[e.RowIndex].Cells[1].Value = validacion;
        }

        private void dgvVal_CamTur_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvVal_HoLibre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        /*private void dgvRespValida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }*/


    }
}
