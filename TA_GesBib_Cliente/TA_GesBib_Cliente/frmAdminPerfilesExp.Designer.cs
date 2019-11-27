namespace TA_GesBib_Cliente
{
    partial class frmAdminPerfilesExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPerfilesExp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.btnQuitarPersonal = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAdministrarPerfiles = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnAgregarPersonal);
            this.groupBox1.Controls.Add(this.btnQuitarPersonal);
            this.groupBox1.Controls.Add(this.dgvPersonal);
            this.groupBox1.Controls.Add(this.cmbPerfil);
            this.groupBox1.Controls.Add(this.lblPerfil);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(920, 464);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar personal:";
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.btnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_más_30;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(624, 113);
            this.btnAgregarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(40, 40);
            this.btnAgregarPersonal.TabIndex = 137;
            this.btnAgregarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // btnQuitarPersonal
            // 
            this.btnQuitarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnQuitarPersonal.FlatAppearance.BorderSize = 0;
            this.btnQuitarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_menos_30;
            this.btnQuitarPersonal.Location = new System.Drawing.Point(680, 113);
            this.btnQuitarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPersonal.Name = "btnQuitarPersonal";
            this.btnQuitarPersonal.Size = new System.Drawing.Size(40, 40);
            this.btnQuitarPersonal.TabIndex = 136;
            this.btnQuitarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarPersonal.UseVisualStyleBackColor = false;
            this.btnQuitarPersonal.Click += new System.EventHandler(this.btnQuitarPersonal_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombres,
            this.apellidos});
            this.dgvPersonal.Location = new System.Drawing.Point(49, 168);
            this.dgvPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.RowHeadersWidth = 123;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(816, 263);
            this.dgvPersonal.TabIndex = 133;
            this.dgvPersonal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersonal_CellFormatting);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(262, 38);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(458, 28);
            this.cmbPerfil.TabIndex = 26;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblPerfil.Location = new System.Drawing.Point(45, 38);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(211, 24);
            this.lblPerfil.TabIndex = 27;
            this.lblPerfil.Text = "Perfil de Experiencia:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(739, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 40);
            this.btnBuscar.TabIndex = 131;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(82, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 13);
            this.label6.TabIndex = 136;
            this.label6.Text = "_____________________________________________________________";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(80, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 33);
            this.lblTitulo.TabIndex = 135;
            this.lblTitulo.Text = "Perfil de Experiencia\r\n";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(21, 35);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 32);
            this.btnCerrar.TabIndex = 137;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAdministrarPerfiles
            // 
            this.btnAdministrarPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAdministrarPerfiles.FlatAppearance.BorderSize = 0;
            this.btnAdministrarPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarPerfiles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarPerfiles.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnAdministrarPerfiles.Location = new System.Drawing.Point(356, 110);
            this.btnAdministrarPerfiles.Name = "btnAdministrarPerfiles";
            this.btnAdministrarPerfiles.Size = new System.Drawing.Size(304, 40);
            this.btnAdministrarPerfiles.TabIndex = 45;
            this.btnAdministrarPerfiles.Text = "Administrar Perfiles de Experiencia";
            this.btnAdministrarPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrarPerfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrarPerfiles.UseVisualStyleBackColor = false;
            this.btnAdministrarPerfiles.Click += new System.EventHandler(this.btnAdministrarPerfiles_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(739, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 40);
            this.btnGuardar.TabIndex = 138;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.FillWeight = 50F;
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 15;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.HeaderText = "Nombres";
            this.nombres.MinimumWidth = 15;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.MinimumWidth = 15;
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // frmAdminPerfilesExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1032, 681);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdministrarPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminPerfilesExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminPerfilesExp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdministrarPerfiles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.Button btnQuitarPersonal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
    }
}