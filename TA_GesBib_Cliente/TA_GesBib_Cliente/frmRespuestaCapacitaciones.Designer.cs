namespace TA_GesBib_Cliente
{
    partial class frmRespuestaCapacitaciones
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
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizarPen = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardarAcep = new System.Windows.Forms.Button();
            this.dgvRespCapac = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpAceptadas = new System.Windows.Forms.TabPage();
            this.btnActAceptadas = new System.Windows.Forms.Button();
            this.dgvAceptadas = new System.Windows.Forms.DataGridView();
            this.nombree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpPendientes = new System.Windows.Forms.TabPage();
            this.btnGuardarPen = new System.Windows.Forms.Button();
            this.tabCtrlValidaciones = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespCapac)).BeginInit();
            this.tbpAceptadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceptadas)).BeginInit();
            this.tbpPendientes.SuspendLayout();
            this.tabCtrlValidaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(83, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(81, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 33);
            this.label9.TabIndex = 108;
            this.label9.Text = "Capacitaciones programadas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnActualizarPen
            // 
            this.btnActualizarPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnActualizarPen.FlatAppearance.BorderSize = 0;
            this.btnActualizarPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarPen.Location = new System.Drawing.Point(253, 283);
            this.btnActualizarPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarPen.Name = "btnActualizarPen";
            this.btnActualizarPen.Size = new System.Drawing.Size(179, 34);
            this.btnActualizarPen.TabIndex = 111;
            this.btnActualizarPen.Text = "Actualizar";
            this.btnActualizarPen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarPen.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(18, 33);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 36);
            this.btnCerrar.TabIndex = 120;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarAcep
            // 
            this.btnGuardarAcep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardarAcep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarAcep.FlatAppearance.BorderSize = 0;
            this.btnGuardarAcep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarAcep.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardarAcep.Location = new System.Drawing.Point(548, 286);
            this.btnGuardarAcep.Name = "btnGuardarAcep";
            this.btnGuardarAcep.Size = new System.Drawing.Size(144, 32);
            this.btnGuardarAcep.TabIndex = 121;
            this.btnGuardarAcep.Text = "GUARDAR";
            this.btnGuardarAcep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarAcep.UseVisualStyleBackColor = false;
            this.btnGuardarAcep.Click += new System.EventHandler(this.btnGuardarAcep_Click);
            // 
            // dgvRespCapac
            // 
            this.dgvRespCapac.AllowUserToAddRows = false;
            this.dgvRespCapac.AllowUserToDeleteRows = false;
            this.dgvRespCapac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRespCapac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespCapac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Descripcion,
            this.Validado});
            this.dgvRespCapac.Location = new System.Drawing.Point(10, 15);
            this.dgvRespCapac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRespCapac.Name = "dgvRespCapac";
            this.dgvRespCapac.RowTemplate.Height = 24;
            this.dgvRespCapac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespCapac.Size = new System.Drawing.Size(711, 249);
            this.dgvRespCapac.TabIndex = 110;
            this.dgvRespCapac.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRespCapac_CellFormatting);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 250;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Validado
            // 
            this.Validado.HeaderText = "¿Asistir?";
            this.Validado.Name = "Validado";
            this.Validado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Validado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbpAceptadas
            // 
            this.tbpAceptadas.Controls.Add(this.btnActAceptadas);
            this.tbpAceptadas.Controls.Add(this.dgvAceptadas);
            this.tbpAceptadas.Controls.Add(this.btnGuardarAcep);
            this.tbpAceptadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpAceptadas.Location = new System.Drawing.Point(4, 25);
            this.tbpAceptadas.Name = "tbpAceptadas";
            this.tbpAceptadas.Size = new System.Drawing.Size(716, 336);
            this.tbpAceptadas.TabIndex = 4;
            this.tbpAceptadas.Text = "Aceptadas";
            this.tbpAceptadas.UseVisualStyleBackColor = true;
            // 
            // btnActAceptadas
            // 
            this.btnActAceptadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnActAceptadas.FlatAppearance.BorderSize = 0;
            this.btnActAceptadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActAceptadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnActAceptadas.Location = new System.Drawing.Point(253, 284);
            this.btnActAceptadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActAceptadas.Name = "btnActAceptadas";
            this.btnActAceptadas.Size = new System.Drawing.Size(179, 34);
            this.btnActAceptadas.TabIndex = 122;
            this.btnActAceptadas.Text = "Actualizar";
            this.btnActAceptadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActAceptadas.UseVisualStyleBackColor = false;
            this.btnActAceptadas.Click += new System.EventHandler(this.btnActAceptadas_Click);
            // 
            // dgvAceptadas
            // 
            this.dgvAceptadas.AllowUserToAddRows = false;
            this.dgvAceptadas.AllowUserToDeleteRows = false;
            this.dgvAceptadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAceptadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAceptadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombree,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.dgvAceptadas.Location = new System.Drawing.Point(10, 14);
            this.dgvAceptadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAceptadas.Name = "dgvAceptadas";
            this.dgvAceptadas.RowTemplate.Height = 24;
            this.dgvAceptadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAceptadas.Size = new System.Drawing.Size(681, 252);
            this.dgvAceptadas.TabIndex = 111;
            this.dgvAceptadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAceptadas_CellFormatting);
            // 
            // nombree
            // 
            this.nombree.HeaderText = "Nombre";
            this.nombree.Name = "nombree";
            this.nombree.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "¿Cancelar?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbpPendientes
            // 
            this.tbpPendientes.Controls.Add(this.btnGuardarPen);
            this.tbpPendientes.Controls.Add(this.dgvRespCapac);
            this.tbpPendientes.Controls.Add(this.btnActualizarPen);
            this.tbpPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpPendientes.Location = new System.Drawing.Point(4, 25);
            this.tbpPendientes.Name = "tbpPendientes";
            this.tbpPendientes.Size = new System.Drawing.Size(773, 336);
            this.tbpPendientes.TabIndex = 3;
            this.tbpPendientes.Text = "Pendientes de Confirmación";
            this.tbpPendientes.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPen
            // 
            this.btnGuardarPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardarPen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarPen.FlatAppearance.BorderSize = 0;
            this.btnGuardarPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPen.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardarPen.Location = new System.Drawing.Point(548, 283);
            this.btnGuardarPen.Name = "btnGuardarPen";
            this.btnGuardarPen.Size = new System.Drawing.Size(144, 32);
            this.btnGuardarPen.TabIndex = 122;
            this.btnGuardarPen.Text = "GUARDAR";
            this.btnGuardarPen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPen.UseVisualStyleBackColor = false;
            this.btnGuardarPen.Click += new System.EventHandler(this.btnGuardarPen_Click);
            // 
            // tabCtrlValidaciones
            // 
            this.tabCtrlValidaciones.Controls.Add(this.tbpPendientes);
            this.tabCtrlValidaciones.Controls.Add(this.tbpAceptadas);
            this.tabCtrlValidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlValidaciones.Location = new System.Drawing.Point(32, 111);
            this.tabCtrlValidaciones.Name = "tabCtrlValidaciones";
            this.tabCtrlValidaciones.SelectedIndex = 0;
            this.tabCtrlValidaciones.Size = new System.Drawing.Size(781, 365);
            this.tabCtrlValidaciones.TabIndex = 138;
            // 
            // frmRespuestaCapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(851, 525);
            this.Controls.Add(this.tabCtrlValidaciones);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRespuestaCapacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRespuestaValidaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespCapac)).EndInit();
            this.tbpAceptadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceptadas)).EndInit();
            this.tbpPendientes.ResumeLayout(false);
            this.tabCtrlValidaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizarPen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardarAcep;
        private System.Windows.Forms.DataGridView dgvRespCapac;
        private System.Windows.Forms.TabPage tbpAceptadas;
        private System.Windows.Forms.TabPage tbpPendientes;
        private System.Windows.Forms.TabControl tabCtrlValidaciones;
        private System.Windows.Forms.Button btnGuardarPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Validado;
        private System.Windows.Forms.DataGridView dgvAceptadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnActAceptadas;
    }
}