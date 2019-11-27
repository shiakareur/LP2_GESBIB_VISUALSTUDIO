namespace TA_GesBib_Cliente
{
    partial class frmModificarDiaCapacitacion
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
            this.gbCrearPuntoAtencion = new System.Windows.Forms.GroupBox();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHMS_ini = new System.Windows.Forms.Label();
            this.dtpFechaIng = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCrearPuntoAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearPuntoAtencion
            // 
            this.gbCrearPuntoAtencion.Controls.Add(this.dtpHoraIni);
            this.gbCrearPuntoAtencion.Controls.Add(this.dtpHoraFin);
            this.gbCrearPuntoAtencion.Controls.Add(this.label10);
            this.gbCrearPuntoAtencion.Controls.Add(this.lblHMS_ini);
            this.gbCrearPuntoAtencion.Controls.Add(this.dtpFechaIng);
            this.gbCrearPuntoAtencion.Controls.Add(this.lblFechaIng);
            this.gbCrearPuntoAtencion.Controls.Add(this.label4);
            this.gbCrearPuntoAtencion.Controls.Add(this.label3);
            this.gbCrearPuntoAtencion.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbCrearPuntoAtencion.ForeColor = System.Drawing.Color.DarkRed;
            this.gbCrearPuntoAtencion.Location = new System.Drawing.Point(31, 49);
            this.gbCrearPuntoAtencion.Name = "gbCrearPuntoAtencion";
            this.gbCrearPuntoAtencion.Size = new System.Drawing.Size(852, 213);
            this.gbCrearPuntoAtencion.TabIndex = 51;
            this.gbCrearPuntoAtencion.TabStop = false;
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.CustomFormat = "HH:mm";
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIni.Location = new System.Drawing.Point(200, 90);
            this.dtpHoraIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHoraIni.MinDate = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.ShowUpDown = true;
            this.dtpHoraIni.Size = new System.Drawing.Size(112, 27);
            this.dtpHoraIni.TabIndex = 132;
            this.dtpHoraIni.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(200, 136);
            this.dtpHoraFin.MinDate = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(112, 27);
            this.dtpHoraFin.TabIndex = 131;
            this.dtpHoraFin.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label10.Location = new System.Drawing.Point(334, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "(hh:mm) ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHMS_ini
            // 
            this.lblHMS_ini.AutoSize = true;
            this.lblHMS_ini.BackColor = System.Drawing.Color.Transparent;
            this.lblHMS_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_ini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHMS_ini.Location = new System.Drawing.Point(334, 97);
            this.lblHMS_ini.Name = "lblHMS_ini";
            this.lblHMS_ini.Size = new System.Drawing.Size(71, 20);
            this.lblHMS_ini.TabIndex = 107;
            this.lblHMS_ini.Text = "(hh:mm) ";
            this.lblHMS_ini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaIng
            // 
            this.dtpFechaIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFechaIng.Location = new System.Drawing.Point(200, 42);
            this.dtpFechaIng.Name = "dtpFechaIng";
            this.dtpFechaIng.Size = new System.Drawing.Size(425, 26);
            this.dtpFechaIng.TabIndex = 51;
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFechaIng.Location = new System.Drawing.Point(15, 42);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(75, 24);
            this.lblFechaIng.TabIndex = 50;
            this.lblFechaIng.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hora Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hora Inicio:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(682, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 33);
            this.btnModificar.TabIndex = 52;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(794, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 33);
            this.btnCerrar.TabIndex = 133;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(27, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(294, 23);
            this.lblNombre.TabIndex = 134;
            this.lblNombre.Text = "MODIFICAR DÍA DE CAPACITACIÓN";
            // 
            // frmModificarDiaCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(914, 311);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbCrearPuntoAtencion);
            this.Name = "frmModificarDiaCapacitacion";
            this.Text = "frmModificarDiaCapacitacion";
            this.gbCrearPuntoAtencion.ResumeLayout(false);
            this.gbCrearPuntoAtencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearPuntoAtencion;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHMS_ini;
        private System.Windows.Forms.DateTimePicker dtpFechaIng;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNombre;
    }
}