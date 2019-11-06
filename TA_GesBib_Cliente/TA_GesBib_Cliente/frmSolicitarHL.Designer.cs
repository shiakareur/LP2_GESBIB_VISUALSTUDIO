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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblHMS_fin = new System.Windows.Forms.Label();
            this.lblHMS_ini = new System.Windows.Forms.Label();
            this.txtHFin_HL = new System.Windows.Forms.TextBox();
            this.txtHIni_HL = new System.Windows.Forms.TextBox();
            this.lblHIni = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.dtpSoliHL = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(481, 93);
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
            this.btnGuardar.Location = new System.Drawing.Point(342, 93);
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
            this.btnNuevo.Location = new System.Drawing.Point(221, 93);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 42);
            this.btnNuevo.TabIndex = 109;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblHMS_fin
            // 
            this.lblHMS_fin.AutoSize = true;
            this.lblHMS_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS_fin.ForeColor = System.Drawing.Color.Black;
            this.lblHMS_fin.Location = new System.Drawing.Point(443, 318);
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
            this.lblHMS_ini.Location = new System.Drawing.Point(443, 275);
            this.lblHMS_ini.Name = "lblHMS_ini";
            this.lblHMS_ini.Size = new System.Drawing.Size(100, 26);
            this.lblHMS_ini.TabIndex = 119;
            this.lblHMS_ini.Text = "(hh:mm) ";
            this.lblHMS_ini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHFin_HL
            // 
            this.txtHFin_HL.Location = new System.Drawing.Point(310, 327);
            this.txtHFin_HL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHFin_HL.Name = "txtHFin_HL";
            this.txtHFin_HL.Size = new System.Drawing.Size(100, 20);
            this.txtHFin_HL.TabIndex = 118;
            // 
            // txtHIni_HL
            // 
            this.txtHIni_HL.Location = new System.Drawing.Point(310, 280);
            this.txtHIni_HL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHIni_HL.Name = "txtHIni_HL";
            this.txtHIni_HL.Size = new System.Drawing.Size(100, 20);
            this.txtHIni_HL.TabIndex = 117;
            // 
            // lblHIni
            // 
            this.lblHIni.AutoSize = true;
            this.lblHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHIni.Location = new System.Drawing.Point(136, 275);
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
            this.lblHFin.Location = new System.Drawing.Point(136, 322);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(125, 26);
            this.lblHFin.TabIndex = 115;
            this.lblHFin.Text = "Hora Fin    :";
            this.lblHFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSoliHL
            // 
            this.dtpSoliHL.Location = new System.Drawing.Point(310, 219);
            this.dtpSoliHL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpSoliHL.Name = "dtpSoliHL";
            this.dtpSoliHL.Size = new System.Drawing.Size(423, 20);
            this.dtpSoliHL.TabIndex = 114;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(136, 219);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 26);
            this.lblFecha.TabIndex = 113;
            this.lblFecha.Text = "Fecha    :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_cerrarventana;
            this.btnCerrar.Location = new System.Drawing.Point(354, 435);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 32);
            this.btnCerrar.TabIndex = 122;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmSolicitarHL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(936, 597);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblHMS_fin);
            this.Controls.Add(this.lblHMS_ini);
            this.Controls.Add(this.txtHFin_HL);
            this.Controls.Add(this.txtHIni_HL);
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
        private System.Windows.Forms.TextBox txtHFin_HL;
        private System.Windows.Forms.TextBox txtHIni_HL;
        private System.Windows.Forms.Label lblHIni;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.DateTimePicker dtpSoliHL;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCerrar;
    }
}