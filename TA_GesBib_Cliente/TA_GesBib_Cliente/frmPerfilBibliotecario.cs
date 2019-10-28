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
    //creo como atributos los formularios de mi menu d cada booton



    //al aser click pregunto si es null(para ver si ya lo he creado y no hacer otro)
    //if(form == null){
    //    //aca pongo visible false a todos  los demas que EXISTEN (OTRO if X CADA UNO)
    //    form = new frmTipoFrm();
    //}else{
    //    form.Visible = true; //es xq en algun momento lo he puesto false
    //}
    
        




    public partial class frmPerfilBibliotecario : Form
    {
        public frmPerfilBibliotecario()
        {
            InitializeComponent();
        }

        private void frmPerfilBibliotecario_Load(object sender, EventArgs e)
        {

        }

        private void btnDistribucionPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
