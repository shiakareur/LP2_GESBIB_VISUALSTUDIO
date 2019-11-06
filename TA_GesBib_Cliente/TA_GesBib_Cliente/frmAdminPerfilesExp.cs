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
        }


    }
}
