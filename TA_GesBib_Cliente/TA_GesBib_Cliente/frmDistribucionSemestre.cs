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
    public partial class frmDistribucionSemestre : Form
    {
        public frmDistribucionSemestre()
        {
            InitializeComponent();
        }
        public frmDistribucionSemestre(ServicioJava.usuario user)
        {
            InitializeComponent();
        }
    }
}
