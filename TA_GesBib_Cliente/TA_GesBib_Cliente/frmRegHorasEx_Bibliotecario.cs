﻿using System;
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
    public partial class frmRegHorasEx_Bibliotecario : Form
    {

        private frmPerfilBibliotecario var_perfilBibliotecario;

        public frmRegHorasEx_Bibliotecario()
        {
            InitializeComponent();
        }

        //se agrego
        public frmRegHorasEx_Bibliotecario(frmPerfilBibliotecario formPerfBiblio)
        {
            var_perfilBibliotecario = formPerfBiblio;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            this.var_perfilBibliotecario.LblBienvenido.Visible = true;
            this.var_perfilBibliotecario.PanelAviso.Visible = true;
        }
    }
}