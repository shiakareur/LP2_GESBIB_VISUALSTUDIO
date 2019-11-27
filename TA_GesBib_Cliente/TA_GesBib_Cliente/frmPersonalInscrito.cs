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
    public partial class frmPersonalInscrito : Form
    {
        public frmPersonalInscrito()
        {
            InitializeComponent();           
        }
        public frmPersonalInscrito(BindingList<ServicioJava.personal> listaPersonal)
        {
            InitializeComponent();
            dgvPersonal.AutoGenerateColumns = false;
            dgvPersonal.DataSource = listaPersonal;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
