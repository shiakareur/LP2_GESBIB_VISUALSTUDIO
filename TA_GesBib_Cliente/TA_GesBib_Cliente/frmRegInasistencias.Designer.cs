﻿namespace TA_GesBib_Cliente
{
    partial class frmRegInasistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegInasistencias));
            this.lblHMS_fin = new System.Windows.Forms.Label();
            this.lblHMS_ini = new System.Windows.Forms.Label();
            this.txtHFin_Inasis = new System.Windows.Forms.TextBox();
            this.txtHIni_Inasis = new System.Windows.Forms.TextBox();
            this.lblHIni = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.dtpRegInasis = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipo_Inasistencia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblElija = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescripcion_HE = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHMS_fin
            // 
            this.lblHMS_fin.AutoSize = true;
            this.lblHMS_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_fin.ForeColor = System.Drawing.Color.Black;
            this.lblHMS_fin.Location = new System.Drawing.Point(578, 371);
            this.lblHMS_fin.Name = "lblHMS_fin";
            this.lblHMS_fin.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_fin.TabIndex = 112;
            this.lblHMS_fin.Text = "(hh:mm) ";
            this.lblHMS_fin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHMS_ini
            // 
            this.lblHMS_ini.AutoSize = true;
            this.lblHMS_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_ini.ForeColor = System.Drawing.Color.Black;
            this.lblHMS_ini.Location = new System.Drawing.Point(578, 327);
            this.lblHMS_ini.Name = "lblHMS_ini";
            this.lblHMS_ini.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_ini.TabIndex = 111;
            this.lblHMS_ini.Text = "(hh:mm) ";
            this.lblHMS_ini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHFin_Inasis
            // 
            this.txtHFin_Inasis.Location = new System.Drawing.Point(444, 380);
            this.txtHFin_Inasis.Margin = new System.Windows.Forms.Padding(2);
            this.txtHFin_Inasis.Name = "txtHFin_Inasis";
            this.txtHFin_Inasis.Size = new System.Drawing.Size(100, 20);
            this.txtHFin_Inasis.TabIndex = 110;
            // 
            // txtHIni_Inasis
            // 
            this.txtHIni_Inasis.Location = new System.Drawing.Point(444, 333);
            this.txtHIni_Inasis.Margin = new System.Windows.Forms.Padding(2);
            this.txtHIni_Inasis.Name = "txtHIni_Inasis";
            this.txtHIni_Inasis.Size = new System.Drawing.Size(100, 20);
            this.txtHIni_Inasis.TabIndex = 109;
            // 
            // lblHIni
            // 
            this.lblHIni.AutoSize = true;
            this.lblHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHIni.Location = new System.Drawing.Point(119, 327);
            this.lblHIni.Name = "lblHIni";
            this.lblHIni.Size = new System.Drawing.Size(134, 26);
            this.lblHIni.TabIndex = 108;
            this.lblHIni.Text = "Hora Inicio  :";
            this.lblHIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHFin.Location = new System.Drawing.Point(119, 374);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(125, 26);
            this.lblHFin.TabIndex = 107;
            this.lblHFin.Text = "Hora Fin    :";
            this.lblHFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpRegInasis
            // 
            this.dtpRegInasis.Location = new System.Drawing.Point(444, 276);
            this.dtpRegInasis.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRegInasis.Name = "dtpRegInasis";
            this.dtpRegInasis.Size = new System.Drawing.Size(234, 20);
            this.dtpRegInasis.TabIndex = 106;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(119, 272);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 26);
            this.lblFecha.TabIndex = 105;
            this.lblFecha.Text = "Fecha    :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipo_Inasistencia
            // 
            this.cmbTipo_Inasistencia.FormattingEnabled = true;
            this.cmbTipo_Inasistencia.Location = new System.Drawing.Point(444, 224);
            this.cmbTipo_Inasistencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo_Inasistencia.Name = "cmbTipo_Inasistencia";
            this.cmbTipo_Inasistencia.Size = new System.Drawing.Size(179, 21);
            this.cmbTipo_Inasistencia.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(93, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(434, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "_____________________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label12.Location = new System.Drawing.Point(91, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(397, 33);
            this.label12.TabIndex = 101;
            this.label12.Text = "Registro de mis Inasistencias\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblElija
            // 
            this.lblElija.AutoSize = true;
            this.lblElija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblElija.Location = new System.Drawing.Point(119, 219);
            this.lblElija.Name = "lblElija";
            this.lblElija.Size = new System.Drawing.Size(252, 26);
            this.lblElija.TabIndex = 100;
            this.lblElija.Text = "Elija tipo de Inasistencia:";
            this.lblElija.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(762, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 42);
            this.btnCancelar.TabIndex = 115;
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
            this.btnGuardar.Location = new System.Drawing.Point(195, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 42);
            this.btnGuardar.TabIndex = 114;
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
            this.btnNuevo.Location = new System.Drawing.Point(70, 124);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 42);
            this.btnNuevo.TabIndex = 113;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(23, 41);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 32);
            this.btnCerrar.TabIndex = 118;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescripcion_HE
            // 
            this.txtDescripcion_HE.Location = new System.Drawing.Point(444, 419);
            this.txtDescripcion_HE.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion_HE.Multiline = true;
            this.txtDescripcion_HE.Name = "txtDescripcion_HE";
            this.txtDescripcion_HE.Size = new System.Drawing.Size(395, 123);
            this.txtDescripcion_HE.TabIndex = 120;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblDescripcion.Location = new System.Drawing.Point(119, 419);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(150, 26);
            this.lblDescripcion.TabIndex = 119;
            this.lblDescripcion.Text = "Descripción   :";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(618, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 42);
            this.btnEliminar.TabIndex = 125;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(333, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 42);
            this.btnBuscar.TabIndex = 124;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(474, 124);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 42);
            this.btnModificar.TabIndex = 123;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmRegInasistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(985, 597);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDescripcion_HE);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblHMS_fin);
            this.Controls.Add(this.lblHMS_ini);
            this.Controls.Add(this.txtHFin_Inasis);
            this.Controls.Add(this.txtHIni_Inasis);
            this.Controls.Add(this.lblHIni);
            this.Controls.Add(this.lblHFin);
            this.Controls.Add(this.dtpRegInasis);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbTipo_Inasistencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblElija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegInasistencias";
            this.Text = "frmRegInasistencias_Bibliotecario";
            this.Load += new System.EventHandler(this.frmRegInasistencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHMS_fin;
        private System.Windows.Forms.Label lblHMS_ini;
        private System.Windows.Forms.TextBox txtHFin_Inasis;
        private System.Windows.Forms.TextBox txtHIni_Inasis;
        private System.Windows.Forms.Label lblHIni;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.DateTimePicker dtpRegInasis;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipo_Inasistencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblElija;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDescripcion_HE;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}