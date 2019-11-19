namespace TA_GesBib_Cliente
{
    partial class frmBuscarHL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarHL));
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvListaHL = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(45, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(221, 24);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Mi lista de solicitudes :";
            // 
            // dgvListaHL
            // 
            this.dgvListaHL.AllowUserToAddRows = false;
            this.dgvListaHL.AllowUserToDeleteRows = false;
            this.dgvListaHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.hora_ini,
            this.hora_fin,
            this.Motivo});
            this.dgvListaHL.Location = new System.Drawing.Point(29, 178);
            this.dgvListaHL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaHL.Name = "dgvListaHL";
            this.dgvListaHL.ReadOnly = true;
            this.dgvListaHL.RowTemplate.Height = 24;
            this.dgvListaHL.Size = new System.Drawing.Size(700, 302);
            this.dgvListaHL.TabIndex = 46;
            this.dgvListaHL.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaHL_CellFormatting);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 250;
            // 
            // hora_ini
            // 
            this.hora_ini.HeaderText = "Hora Inicio";
            this.hora_ini.Name = "hora_ini";
            this.hora_ini.ReadOnly = true;
            this.hora_ini.Width = 250;
            // 
            // hora_fin
            // 
            this.hora_fin.HeaderText = "Hora Fin";
            this.hora_fin.Name = "hora_fin";
            this.hora_fin.ReadOnly = true;
            this.hora_fin.Width = 250;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 300;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnSeleccionar.Location = new System.Drawing.Point(541, 109);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(188, 32);
            this.btnSeleccionar.TabIndex = 50;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarHL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(827, 553);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvListaHL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarHL";
            this.Text = "Lista de Solicitudes de Horas Libres";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvListaHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
    }
}