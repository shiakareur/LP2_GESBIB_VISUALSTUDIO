﻿namespace TA_GesBib_Cliente
{
    partial class frmBuscarBiblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvBibliotecas = new System.Windows.Forms.DataGridView();
            this.btnBuscarBib = new System.Windows.Forms.Button();
            this.btnSeleccionarBib = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtNombre.Location = new System.Drawing.Point(108, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 27);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(21, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 23);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(1029, 9);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(126, 33);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // dgvBibliotecas
            // 
            this.dgvBibliotecas.AllowUserToAddRows = false;
            this.dgvBibliotecas.AllowUserToDeleteRows = false;
            this.dgvBibliotecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBibliotecas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBibliotecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBibliotecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Gestor});
            this.dgvBibliotecas.Location = new System.Drawing.Point(25, 60);
            this.dgvBibliotecas.Name = "dgvBibliotecas";
            this.dgvBibliotecas.ReadOnly = true;
            this.dgvBibliotecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBibliotecas.Size = new System.Drawing.Size(864, 239);
            this.dgvBibliotecas.TabIndex = 5;
            this.dgvBibliotecas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBibliotecas_CellFormatting_1);
            // 
            // btnBuscarBib
            // 
            this.btnBuscarBib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscarBib.FlatAppearance.BorderSize = 0;
            this.btnBuscarBib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBib.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBib.Location = new System.Drawing.Point(656, 13);
            this.btnBuscarBib.Name = "btnBuscarBib";
            this.btnBuscarBib.Size = new System.Drawing.Size(89, 33);
            this.btnBuscarBib.TabIndex = 22;
            this.btnBuscarBib.Text = "Buscar";
            this.btnBuscarBib.UseVisualStyleBackColor = false;
            this.btnBuscarBib.Click += new System.EventHandler(this.btnBuscarBib_Click);
            // 
            // btnSeleccionarBib
            // 
            this.btnSeleccionarBib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnSeleccionarBib.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarBib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarBib.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarBib.Location = new System.Drawing.Point(763, 12);
            this.btnSeleccionarBib.Name = "btnSeleccionarBib";
            this.btnSeleccionarBib.Size = new System.Drawing.Size(126, 33);
            this.btnSeleccionarBib.TabIndex = 21;
            this.btnSeleccionarBib.Text = "Seleccionar";
            this.btnSeleccionarBib.UseVisualStyleBackColor = false;
            this.btnSeleccionarBib.Click += new System.EventHandler(this.btnSeleccionarBib_Click);
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.DefaultCellStyle = dataGridViewCellStyle2;
            this.DNI.Frozen = true;
            this.DNI.HeaderText = "Nombre";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 104;
            // 
            // Gestor
            // 
            this.Gestor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.Gestor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gestor.HeaderText = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.ReadOnly = true;
            // 
            // frmBuscarBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(914, 311);
            this.Controls.Add(this.btnBuscarBib);
            this.Controls.Add(this.btnSeleccionarBib);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvBibliotecas);
            this.Name = "frmBuscarBiblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvBibliotecas;
        private System.Windows.Forms.Button btnBuscarBib;
        private System.Windows.Forms.Button btnSeleccionarBib;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
    }
}