namespace TA_GesBib_Cliente
{
    partial class frmSolicitarHL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitarHL));
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHMS_fin = new System.Windows.Forms.Label();
            this.lblHMS_ini = new System.Windows.Forms.Label();
            this.lblHIni = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.dtpSoliHL = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtMotivo_HL = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(81, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "______________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(80, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 33);
            this.label9.TabIndex = 94;
            this.label9.Text = "Solicitud de Horas libres\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHMS_fin
            // 
            this.lblHMS_fin.AutoSize = true;
            this.lblHMS_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_fin.ForeColor = System.Drawing.Color.Black;
            this.lblHMS_fin.Location = new System.Drawing.Point(412, 286);
            this.lblHMS_fin.Name = "lblHMS_fin";
            this.lblHMS_fin.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_fin.TabIndex = 120;
            this.lblHMS_fin.Text = "(hh:mm) ";
            this.lblHMS_fin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHMS_ini
            // 
            this.lblHMS_ini.AutoSize = true;
            this.lblHMS_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_ini.ForeColor = System.Drawing.Color.Black;
            this.lblHMS_ini.Location = new System.Drawing.Point(412, 243);
            this.lblHMS_ini.Name = "lblHMS_ini";
            this.lblHMS_ini.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_ini.TabIndex = 119;
            this.lblHMS_ini.Text = "(hh:mm) ";
            this.lblHMS_ini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHIni
            // 
            this.lblHIni.AutoSize = true;
            this.lblHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHIni.Location = new System.Drawing.Point(105, 243);
            this.lblHIni.Name = "lblHIni";
            this.lblHIni.Size = new System.Drawing.Size(134, 26);
            this.lblHIni.TabIndex = 116;
            this.lblHIni.Text = "Hora Inicio  :";
            this.lblHIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHFin.Location = new System.Drawing.Point(105, 290);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(125, 26);
            this.lblHFin.TabIndex = 115;
            this.lblHFin.Text = "Hora Fin    :";
            this.lblHFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSoliHL
            // 
            this.dtpSoliHL.Location = new System.Drawing.Point(279, 188);
            this.dtpSoliHL.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSoliHL.Name = "dtpSoliHL";
            this.dtpSoliHL.Size = new System.Drawing.Size(423, 20);
            this.dtpSoliHL.TabIndex = 114;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(105, 188);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 26);
            this.lblFecha.TabIndex = 113;
            this.lblFecha.Text = "Fecha    :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMotivo_HL
            // 
            this.txtMotivo_HL.Location = new System.Drawing.Point(279, 338);
            this.txtMotivo_HL.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivo_HL.Multiline = true;
            this.txtMotivo_HL.Name = "txtMotivo_HL";
            this.txtMotivo_HL.Size = new System.Drawing.Size(395, 123);
            this.txtMotivo_HL.TabIndex = 124;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblDescripcion.Location = new System.Drawing.Point(105, 338);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 26);
            this.lblDescripcion.TabIndex = 123;
            this.lblDescripcion.Text = "Motivo   :";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(568, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 42);
            this.btnEliminar.TabIndex = 127;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(424, 108);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 42);
            this.btnModificar.TabIndex = 126;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(291, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 42);
            this.btnBuscar.TabIndex = 125;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(21, 30);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 32);
            this.btnCerrar.TabIndex = 122;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(710, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 42);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(148, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 42);
            this.btnGuardar.TabIndex = 110;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(27, 108);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 42);
            this.btnNuevo.TabIndex = 109;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.CustomFormat = "HH:mm";
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIni.Location = new System.Drawing.Point(279, 247);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.ShowUpDown = true;
            this.dtpHoraIni.Size = new System.Drawing.Size(112, 20);
            this.dtpHoraIni.TabIndex = 128;
            this.dtpHoraIni.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(279, 289);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(112, 20);
            this.dtpHoraFin.TabIndex = 129;
            this.dtpHoraFin.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // frmSolicitarHL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(915, 509);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraIni);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMotivo_HL);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblHMS_fin);
            this.Controls.Add(this.lblHMS_ini);
            this.Controls.Add(this.lblHIni);
            this.Controls.Add(this.lblHFin);
            this.Controls.Add(this.dtpSoliHL);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitarHL";
            this.Text = "frmSolicitarHL_Bibliotecario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblHMS_fin;
        private System.Windows.Forms.Label lblHMS_ini;
        private System.Windows.Forms.Label lblHIni;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.DateTimePicker dtpSoliHL;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtMotivo_HL;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
    }
}