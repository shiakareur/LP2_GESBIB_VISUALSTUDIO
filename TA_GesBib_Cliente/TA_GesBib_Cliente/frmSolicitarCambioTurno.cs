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
    public partial class frmSolicitarCambioTurno : Form
    {
        
        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;

        public frmSolicitarCambioTurno()
        {
            InitializeComponent();
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }



        public frmSolicitarCambioTurno(Form formPerfilPersonal, TipoPerfil tipoPerfil)
        {
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            InitializeComponent();

            limpiarComponentes();
            estadoComponentes(Estado.Inicial);

            lblFlechita.Visible = false;
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
                    lblNombre.Enabled = false;
                    lblApe.Enabled = false;
                    lblCargo.Enabled = false;
                    lblPuntoAten.Enabled = false;
                    lblIniRef.Enabled = false;
                    lblFinRef.Enabled = false;


                    lblMiH_ini.Enabled = false;
                    lblMiH_fin.Enabled = false;
                    lblMinombre.Enabled = false;
                    lblMiApe.Enabled = false;
                    lblMiCargo.Enabled = false;
                    lblMiPA.Enabled = false;
                    lblMiRef_ini.Enabled = false;
                    lblMiRef_fin.Enabled = false;

                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //btnBuscarDistribucionPersonal.Enabled = false;
                    //Campos de Texto

                    //del cumpañero
                    txtNombre.Enabled = false;
                    txtApe.Enabled = false;
                    txtCargo.Enabled = false;
                    txtPtoAten.Enabled = false;
                    txtHIni.Enabled = false;
                    txtHFin.Enabled = false;
                    txtIniRef.Enabled = false;
                    txtFinRef.Enabled = false;

                    //ahora data del user

                    txtMiNombre.Enabled = false;
                    txtMiApe.Enabled = false;
                    txtMiCargo.Enabled = false;
                    txtMiPA.Enabled = false;
                    txtMiHini.Enabled = false;
                    txtMiHFin.Enabled = false;
                    txtMiRefIni.Enabled = false;
                    txtMiRefFin.Enabled = false;



                    dtpSolCambioTurno.Enabled = false;
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //btnBuscarDistribucionPersonal.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = false;
                    lblHFin.Enabled = false;
                    lblNombre.Enabled = false;
                    lblApe.Enabled = false;
                    lblCargo.Enabled = false;
                    lblPuntoAten.Enabled = false;
                    lblIniRef.Enabled = false;
                    lblFinRef.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    //btnBuscarDistribucionPersonal.Enabled = true;
                    //Campos de Texto
                    txtNombre.Enabled = false;
                    txtApe.Enabled = false;
                    txtCargo.Enabled = false;
                    txtPtoAten.Enabled = false;
                    txtHIni.Enabled = false;
                    txtHFin.Enabled = false;
                    txtIniRef.Enabled = false;
                    txtFinRef.Enabled = false;

                    dtpSolCambioTurno.Enabled = true;
                    break;

                case Estado.Modificar:
                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblHIni.Enabled = true;
                    lblHFin.Enabled = true;
                    lblIniRef.Enabled = true;
                    lblFinRef.Enabled = true;
                    lblNombre.Enabled = false;
                    lblApe.Enabled = false;
                    lblCargo.Enabled = false;
                    lblPuntoAten.Enabled = false;
                   
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //btnBuscarDistribucionPersonal.Enabled = false;
                    //Campos de Texto
                    txtNombre.Enabled = false;
                    txtApe.Enabled = false;
                    txtCargo.Enabled = false;
                    txtPtoAten.Enabled = false;
                    txtHIni.Enabled = true;
                    txtHFin.Enabled = true;
                    txtIniRef.Enabled = true;
                    txtFinRef.Enabled = true;

                    dtpSolCambioTurno.Enabled = true;
                    break;
            }

        }


        public void limpiarComponentes()
        {

            txtNombre.Text = "";
            txtApe.Text = "";
            txtCargo.Text = "";
            txtPtoAten.Text = "";
            txtHIni.Text = "";
            txtHFin.Text = "";
            txtIniRef.Text = "";
            txtFinRef.Text = "";
            dtpSolCambioTurno.Value = DateTime.Today;

        }

        private void muestraMensajeExitoso()
        {
            //mostramos mensaje de error
            MessageBox.Show("Se guardaron los cambios exitosamente !",
                "Mensajillo");
        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se pone los LABELS ENABLES
            lblFlechita.Visible = true;
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //poner limpiar los labels
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //llamamos al SERVICIO RESPECTIVO
            //Servicio<HoraExtra> hora_extra = new ServicioTA<HoraExtra>;
            //DBController...
            //....

            estadoComponentes(Estado.Inicial);
            this.muestraMensajeExitoso();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            estadoComponentes(Estado.Modificar);
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
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    ((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    //((frmPerfilPracticante)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //se busca o lista la distribucion de personal

            frmBuscarDistribucionxPersonal formBuscarDistrixPers =
                new frmBuscarDistribucionxPersonal();

            estadoComponentes(Estado.Buscar);
            if (formBuscarDistrixPers.ShowDialog() == DialogResult.OK)
            {
                estadoComponentes(Estado.Buscar);
            }
        }
    }
}
