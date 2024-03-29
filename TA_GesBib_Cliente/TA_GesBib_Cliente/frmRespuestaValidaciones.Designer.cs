﻿namespace TA_GesBib_Cliente
{
    partial class frmRespuestaValidaciones
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
            this.dgvRespValida_HE = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabCtrlValidaciones = new System.Windows.Forms.TabControl();
            this.tbpHoEx = new System.Windows.Forms.TabPage();
            this.tbpInasis = new System.Windows.Forms.TabPage();
            this.dgvVal_Inasis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpHoLibre = new System.Windows.Forms.TabPage();
            this.dgvVal_HoLibre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCambioTur = new System.Windows.Forms.TabPage();
            this.dgvVal_CamTur = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespValida_HE)).BeginInit();
            this.tabCtrlValidaciones.SuspendLayout();
            this.tbpHoEx.SuspendLayout();
            this.tbpInasis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_Inasis)).BeginInit();
            this.tbpHoLibre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_HoLibre)).BeginInit();
            this.tbpCambioTur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_CamTur)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(111, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 17);
            this.label6.TabIndex = 109;
            this.label6.Text = "________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(108, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(474, 42);
            this.label9.TabIndex = 108;
            this.label9.Text = "Validaciones de Solicitudes\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvRespValida_HE
            // 
            this.dgvRespValida_HE.AllowUserToAddRows = false;
            this.dgvRespValida_HE.AllowUserToDeleteRows = false;
            this.dgvRespValida_HE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRespValida_HE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespValida_HE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Validado});
            this.dgvRespValida_HE.Location = new System.Drawing.Point(29, 38);
            this.dgvRespValida_HE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRespValida_HE.Name = "dgvRespValida_HE";
            this.dgvRespValida_HE.ReadOnly = true;
            this.dgvRespValida_HE.RowTemplate.Height = 24;
            this.dgvRespValida_HE.Size = new System.Drawing.Size(1125, 404);
            this.dgvRespValida_HE.TabIndex = 110;
            this.dgvRespValida_HE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRespValida_HE_CellFormatting);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 600;
            // 
            // Validado
            // 
            this.Validado.HeaderText = "¿ Validado?";
            this.Validado.Name = "Validado";
            this.Validado.ReadOnly = true;
            this.Validado.Width = 200;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(455, 107);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(388, 39);
            this.btnActualizar.TabIndex = 111;
            this.btnActualizar.Text = "Actualizar respuestas";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(24, 41);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(67, 44);
            this.btnCerrar.TabIndex = 120;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabCtrlValidaciones
            // 
            this.tabCtrlValidaciones.Controls.Add(this.tbpHoEx);
            this.tabCtrlValidaciones.Controls.Add(this.tbpInasis);
            this.tabCtrlValidaciones.Controls.Add(this.tbpHoLibre);
            this.tabCtrlValidaciones.Controls.Add(this.tbpCambioTur);
            this.tabCtrlValidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlValidaciones.Location = new System.Drawing.Point(53, 170);
            this.tabCtrlValidaciones.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlValidaciones.Name = "tabCtrlValidaciones";
            this.tabCtrlValidaciones.SelectedIndex = 0;
            this.tabCtrlValidaciones.Size = new System.Drawing.Size(1192, 519);
            this.tabCtrlValidaciones.TabIndex = 137;
            // 
            // tbpHoEx
            // 
            this.tbpHoEx.Controls.Add(this.dgvRespValida_HE);
            this.tbpHoEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpHoEx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbpHoEx.Location = new System.Drawing.Point(4, 29);
            this.tbpHoEx.Margin = new System.Windows.Forms.Padding(4);
            this.tbpHoEx.Name = "tbpHoEx";
            this.tbpHoEx.Padding = new System.Windows.Forms.Padding(4);
            this.tbpHoEx.Size = new System.Drawing.Size(1184, 486);
            this.tbpHoEx.TabIndex = 1;
            this.tbpHoEx.Text = "HORAS EXTRAS";
            this.tbpHoEx.UseVisualStyleBackColor = true;
            // 
            // tbpInasis
            // 
            this.tbpInasis.Controls.Add(this.dgvVal_Inasis);
            this.tbpInasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpInasis.Location = new System.Drawing.Point(4, 29);
            this.tbpInasis.Margin = new System.Windows.Forms.Padding(4);
            this.tbpInasis.Name = "tbpInasis";
            this.tbpInasis.Size = new System.Drawing.Size(1184, 486);
            this.tbpInasis.TabIndex = 2;
            this.tbpInasis.Text = "INASISTENCIAS";
            this.tbpInasis.UseVisualStyleBackColor = true;
            // 
            // dgvVal_Inasis
            // 
            this.dgvVal_Inasis.AllowUserToAddRows = false;
            this.dgvVal_Inasis.AllowUserToDeleteRows = false;
            this.dgvVal_Inasis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVal_Inasis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVal_Inasis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvVal_Inasis.Location = new System.Drawing.Point(28, 39);
            this.dgvVal_Inasis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVal_Inasis.Name = "dgvVal_Inasis";
            this.dgvVal_Inasis.ReadOnly = true;
            this.dgvVal_Inasis.RowTemplate.Height = 24;
            this.dgvVal_Inasis.Size = new System.Drawing.Size(1125, 404);
            this.dgvVal_Inasis.TabIndex = 111;
            this.dgvVal_Inasis.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVal_Inasis_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 600;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "¿ Validado?";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // tbpHoLibre
            // 
            this.tbpHoLibre.Controls.Add(this.dgvVal_HoLibre);
            this.tbpHoLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpHoLibre.Location = new System.Drawing.Point(4, 29);
            this.tbpHoLibre.Margin = new System.Windows.Forms.Padding(4);
            this.tbpHoLibre.Name = "tbpHoLibre";
            this.tbpHoLibre.Size = new System.Drawing.Size(1184, 486);
            this.tbpHoLibre.TabIndex = 3;
            this.tbpHoLibre.Text = "HORAS LIBRES";
            this.tbpHoLibre.UseVisualStyleBackColor = true;
            // 
            // dgvVal_HoLibre
            // 
            this.dgvVal_HoLibre.AllowUserToAddRows = false;
            this.dgvVal_HoLibre.AllowUserToDeleteRows = false;
            this.dgvVal_HoLibre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVal_HoLibre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVal_HoLibre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvVal_HoLibre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvVal_HoLibre.Location = new System.Drawing.Point(28, 46);
            this.dgvVal_HoLibre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVal_HoLibre.Name = "dgvVal_HoLibre";
            this.dgvVal_HoLibre.ReadOnly = true;
            this.dgvVal_HoLibre.RowTemplate.Height = 24;
            this.dgvVal_HoLibre.Size = new System.Drawing.Size(1125, 404);
            this.dgvVal_HoLibre.TabIndex = 111;
            this.dgvVal_HoLibre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVal_HoLibre_CellContentClick);
            this.dgvVal_HoLibre.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVal_HoLibre_CellFormatting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPCIÓN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 600;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // tbpCambioTur
            // 
            this.tbpCambioTur.Controls.Add(this.dgvVal_CamTur);
            this.tbpCambioTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpCambioTur.Location = new System.Drawing.Point(4, 29);
            this.tbpCambioTur.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCambioTur.Name = "tbpCambioTur";
            this.tbpCambioTur.Size = new System.Drawing.Size(1184, 486);
            this.tbpCambioTur.TabIndex = 4;
            this.tbpCambioTur.Text = "CAMBIO TURNO";
            this.tbpCambioTur.UseVisualStyleBackColor = true;
            // 
            // dgvVal_CamTur
            // 
            this.dgvVal_CamTur.AllowUserToAddRows = false;
            this.dgvVal_CamTur.AllowUserToDeleteRows = false;
            this.dgvVal_CamTur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvVal_CamTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVal_CamTur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvVal_CamTur.Location = new System.Drawing.Point(28, 39);
            this.dgvVal_CamTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVal_CamTur.Name = "dgvVal_CamTur";
            this.dgvVal_CamTur.ReadOnly = true;
            this.dgvVal_CamTur.RowTemplate.Height = 24;
            this.dgvVal_CamTur.Size = new System.Drawing.Size(1125, 404);
            this.dgvVal_CamTur.TabIndex = 111;
            this.dgvVal_CamTur.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVal_CamTur_CellFormatting);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 600;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "¿ Validado?";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // frmRespuestaValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1357, 743);
            this.Controls.Add(this.tabCtrlValidaciones);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRespuestaValidaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRespuestaValidaciones";
            this.Load += new System.EventHandler(this.frmRespuestaValidaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespValida_HE)).EndInit();
            this.tabCtrlValidaciones.ResumeLayout(false);
            this.tbpHoEx.ResumeLayout(false);
            this.tbpInasis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_Inasis)).EndInit();
            this.tbpHoLibre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_HoLibre)).EndInit();
            this.tbpCambioTur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVal_CamTur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRespValida_HE;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validado;
        private System.Windows.Forms.TabControl tabCtrlValidaciones;
        private System.Windows.Forms.TabPage tbpHoEx;
        private System.Windows.Forms.TabPage tbpInasis;
        private System.Windows.Forms.TabPage tbpHoLibre;
        private System.Windows.Forms.TabPage tbpCambioTur;
        private System.Windows.Forms.DataGridView dgvVal_Inasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvVal_HoLibre;
        private System.Windows.Forms.DataGridView dgvVal_CamTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}