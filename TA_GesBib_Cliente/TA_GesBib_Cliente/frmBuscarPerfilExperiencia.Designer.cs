namespace TA_GesBib_Cliente
{
    partial class frmBuscarPerfilExperiencia
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
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarBib = new System.Windows.Forms.Button();
            this.nombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePerfil});
            this.dgvPerfiles.Location = new System.Drawing.Point(74, 167);
            this.dgvPerfiles.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.ReadOnly = true;
            this.dgvPerfiles.RowHeadersWidth = 123;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(2736, 680);
            this.dgvPerfiles.TabIndex = 6;
            // 
            // btnSeleccionarBib
            // 
            this.btnSeleccionarBib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnSeleccionarBib.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarBib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarBib.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarBib.Location = new System.Drawing.Point(2411, 27);
            this.btnSeleccionarBib.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSeleccionarBib.Name = "btnSeleccionarBib";
            this.btnSeleccionarBib.Size = new System.Drawing.Size(399, 94);
            this.btnSeleccionarBib.TabIndex = 22;
            this.btnSeleccionarBib.Text = "Seleccionar";
            this.btnSeleccionarBib.UseVisualStyleBackColor = false;
            this.btnSeleccionarBib.Click += new System.EventHandler(this.btnSeleccionarBib_Click);
            // 
            // nombrePerfil
            // 
            this.nombrePerfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePerfil.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombrePerfil.HeaderText = "Nombre";
            this.nombrePerfil.MinimumWidth = 15;
            this.nombrePerfil.Name = "nombrePerfil";
            this.nombrePerfil.ReadOnly = true;
            // 
            // frmBuscarPerfilExperiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(2894, 885);
            this.Controls.Add(this.btnSeleccionarBib);
            this.Controls.Add(this.dgvPerfiles);
            this.Name = "frmBuscarPerfilExperiencia";
            this.Text = "Buscar Perfil Experiencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Button btnSeleccionarBib;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePerfil;
    }
}