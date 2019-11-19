namespace TA_GesBib_Cliente
{
    partial class frmRegHE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegHE));
            this.lblHMS_fin = new System.Windows.Forms.Label();
            this.lblHMS_ini = new System.Windows.Forms.Label();
            this.txtDescripcion_HE = new System.Windows.Forms.TextBox();
            this.txtCantHoras_HE = new System.Windows.Forms.TextBox();
            this.txtHFin_HE = new System.Windows.Forms.TextBox();
            this.txtHIni_HE = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantHoras = new System.Windows.Forms.Label();
            this.lblHIni = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.dtpFechaHE = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHMS_fin
            // 
            this.lblHMS_fin.AutoSize = true;
            this.lblHMS_fin.BackColor = System.Drawing.Color.Transparent;
            this.lblHMS_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_fin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHMS_fin.Location = new System.Drawing.Point(480, 277);
            this.lblHMS_fin.Name = "lblHMS_fin";
            this.lblHMS_fin.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_fin.TabIndex = 105;
            this.lblHMS_fin.Text = "(hh:mm) ";
            this.lblHMS_fin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHMS_ini
            // 
            this.lblHMS_ini.AutoSize = true;
            this.lblHMS_ini.BackColor = System.Drawing.Color.Transparent;
            this.lblHMS_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_ini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHMS_ini.Location = new System.Drawing.Point(480, 229);
            this.lblHMS_ini.Name = "lblHMS_ini";
            this.lblHMS_ini.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_ini.TabIndex = 104;
            this.lblHMS_ini.Text = "(hh:mm) ";
            this.lblHMS_ini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion_HE
            // 
            this.txtDescripcion_HE.Location = new System.Drawing.Point(348, 384);
            this.txtDescripcion_HE.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion_HE.Multiline = true;
            this.txtDescripcion_HE.Name = "txtDescripcion_HE";
            this.txtDescripcion_HE.Size = new System.Drawing.Size(395, 123);
            this.txtDescripcion_HE.TabIndex = 103;
            // 
            // txtCantHoras_HE
            // 
            this.txtCantHoras_HE.Location = new System.Drawing.Point(348, 335);
            this.txtCantHoras_HE.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantHoras_HE.Name = "txtCantHoras_HE";
            this.txtCantHoras_HE.Size = new System.Drawing.Size(60, 20);
            this.txtCantHoras_HE.TabIndex = 102;
            // 
            // txtHFin_HE
            // 
            this.txtHFin_HE.Location = new System.Drawing.Point(348, 283);
            this.txtHFin_HE.Margin = new System.Windows.Forms.Padding(2);
            this.txtHFin_HE.Name = "txtHFin_HE";
            this.txtHFin_HE.Size = new System.Drawing.Size(98, 20);
            this.txtHFin_HE.TabIndex = 101;
            // 
            // txtHIni_HE
            // 
            this.txtHIni_HE.Location = new System.Drawing.Point(348, 235);
            this.txtHIni_HE.Margin = new System.Windows.Forms.Padding(2);
            this.txtHIni_HE.Name = "txtHIni_HE";
            this.txtHIni_HE.Size = new System.Drawing.Size(98, 20);
            this.txtHIni_HE.TabIndex = 100;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblDescripcion.Location = new System.Drawing.Point(110, 384);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(150, 26);
            this.lblDescripcion.TabIndex = 99;
            this.lblDescripcion.Text = "Descripción   :";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantHoras
            // 
            this.lblCantHoras.AutoSize = true;
            this.lblCantHoras.BackColor = System.Drawing.Color.Transparent;
            this.lblCantHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCantHoras.Location = new System.Drawing.Point(110, 334);
            this.lblCantHoras.Name = "lblCantHoras";
            this.lblCantHoras.Size = new System.Drawing.Size(217, 26);
            this.lblCantHoras.TabIndex = 98;
            this.lblCantHoras.Text = "Cantidad de Horas   :";
            this.lblCantHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHIni
            // 
            this.lblHIni.AutoSize = true;
            this.lblHIni.BackColor = System.Drawing.Color.Transparent;
            this.lblHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHIni.Location = new System.Drawing.Point(110, 237);
            this.lblHIni.Name = "lblHIni";
            this.lblHIni.Size = new System.Drawing.Size(134, 26);
            this.lblHIni.TabIndex = 97;
            this.lblHIni.Text = "Hora Inicio  :";
            this.lblHIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHFin.Location = new System.Drawing.Point(110, 284);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(125, 26);
            this.lblHFin.TabIndex = 96;
            this.lblHFin.Text = "Hora Fin    :";
            this.lblHFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaHE
            // 
            this.dtpFechaHE.Location = new System.Drawing.Point(348, 184);
            this.dtpFechaHE.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHE.Name = "dtpFechaHE";
            this.dtpFechaHE.Size = new System.Drawing.Size(423, 20);
            this.dtpFechaHE.TabIndex = 95;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(110, 184);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 26);
            this.lblFecha.TabIndex = 94;
            this.lblFecha.Text = "Fecha    :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(91, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "_____________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(89, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 33);
            this.label9.TabIndex = 106;
            this.label9.Text = "Registro de mis Horas Extras \r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(757, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 42);
            this.btnCancelar.TabIndex = 52;
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
            this.btnGuardar.Location = new System.Drawing.Point(187, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 42);
            this.btnGuardar.TabIndex = 49;
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
            this.btnNuevo.Location = new System.Drawing.Point(54, 105);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 42);
            this.btnNuevo.TabIndex = 48;
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
            this.btnCerrar.Location = new System.Drawing.Point(20, 37);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 43);
            this.btnCerrar.TabIndex = 119;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(469, 105);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 42);
            this.btnModificar.TabIndex = 120;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(328, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 42);
            this.btnBuscar.TabIndex = 121;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(613, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 42);
            this.btnEliminar.TabIndex = 122;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmRegHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(988, 642);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHMS_fin);
            this.Controls.Add(this.lblHMS_ini);
            this.Controls.Add(this.txtDescripcion_HE);
            this.Controls.Add(this.txtCantHoras_HE);
            this.Controls.Add(this.txtHFin_HE);
            this.Controls.Add(this.txtHIni_HE);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantHoras);
            this.Controls.Add(this.lblHIni);
            this.Controls.Add(this.lblHFin);
            this.Controls.Add(this.dtpFechaHE);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegHE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegHorasEx_Bibliotecario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblHMS_fin;
        private System.Windows.Forms.Label lblHMS_ini;
        private System.Windows.Forms.TextBox txtDescripcion_HE;
        private System.Windows.Forms.TextBox txtCantHoras_HE;
        private System.Windows.Forms.TextBox txtHFin_HE;
        private System.Windows.Forms.TextBox txtHIni_HE;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantHoras;
        private System.Windows.Forms.Label lblHIni;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.DateTimePicker dtpFechaHE;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}