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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDistri_Personal = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punto_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.btnQuitarPersonal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri_Personal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(356, 110);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(304, 40);
            this.btnNuevo.TabIndex = 45;
            this.btnNuevo.Text = "Administrar Perfiles de Experiencia";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.button1.Location = new System.Drawing.Point(725, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 131;
            this.button1.Text = "BUSCAR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarPersonal);
            this.groupBox1.Controls.Add(this.btnQuitarPersonal);
            this.groupBox1.Controls.Add(this.dgvDistri_Personal);
            this.groupBox1.Controls.Add(this.cmbPerfil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
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
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(301, 38);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(363, 28);
            this.cmbPerfil.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(45, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Perfil de Experiencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(82, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 15);
            this.label6.TabIndex = 136;
            this.label6.Text = "_____________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(80, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 33);
            this.label9.TabIndex = 135;
            this.label9.Text = "Administrar Perfil de Experiencia\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dgvDistri_Personal
            // 
            this.dgvDistri_Personal.AllowUserToAddRows = false;
            this.dgvDistri_Personal.AllowUserToDeleteRows = false;
            this.dgvDistri_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistri_Personal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellidos,
            this.tipo_personal,
            this.punto_atencion,
            this.fecha_nac});
            this.dgvDistri_Personal.Location = new System.Drawing.Point(49, 168);
            this.dgvDistri_Personal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDistri_Personal.Name = "dgvDistri_Personal";
            this.dgvDistri_Personal.ReadOnly = true;
            this.dgvDistri_Personal.RowTemplate.Height = 24;
            this.dgvDistri_Personal.Size = new System.Drawing.Size(816, 231);
            this.dgvDistri_Personal.TabIndex = 133;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // tipo_personal
            // 
            this.tipo_personal.HeaderText = "Tipo Personal";
            this.tipo_personal.Name = "tipo_personal";
            this.tipo_personal.ReadOnly = true;
            // 
            // punto_atencion
            // 
            this.punto_atencion.HeaderText = "Punto de Atención";
            this.punto_atencion.Name = "punto_atencion";
            this.punto_atencion.ReadOnly = true;
            // 
            // fecha_nac
            // 
            this.fecha_nac.HeaderText = "Fecha Nacimiento";
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.ReadOnly = true;
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.btnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_más_30;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(778, 105);
            this.btnAgregarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(35, 34);
            this.btnAgregarPersonal.TabIndex = 137;
            this.btnAgregarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            // 
            // btnQuitarPersonal
            // 
            this.btnQuitarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnQuitarPersonal.FlatAppearance.BorderSize = 0;
            this.btnQuitarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_menos_30;
            this.btnQuitarPersonal.Location = new System.Drawing.Point(830, 105);
            this.btnQuitarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPersonal.Name = "btnQuitarPersonal";
            this.btnQuitarPersonal.Size = new System.Drawing.Size(35, 34);
            this.btnQuitarPersonal.TabIndex = 136;
            this.btnQuitarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarPersonal.UseVisualStyleBackColor = false;
            // 
            // frmAdminPerfilesExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1031, 683);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminPerfilesExp";
            this.Text = "frmAdminPerfilesExp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri_Personal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDistri_Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn punto_atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.Button btnQuitarPersonal;
    }
}