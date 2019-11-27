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

        public frmAdminPerfilesExp()
        {
            InitializeComponent();
        }

        public frmAdminPerfilesExp(frmPerfilGestor formPerfilGestor)
        {
            var_formPerfilGestor = formPerfilGestor;
            InitializeComponent();
            cmbPerfil.DataSource = new BindingList<ServicioJava.perfilExperiencia>(Program.DBController.listarPerfilExperiencia());

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
        }
    }
}
