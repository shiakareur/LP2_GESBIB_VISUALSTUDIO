namespace TA_GesBib_Cliente
{
    partial class frmSolicitarCambioTurno
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
            this.dtpSolCambioTurno = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.btnBuscarDistribucionPersonal = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFinRef = new System.Windows.Forms.TextBox();
            this.lblFinRef = new System.Windows.Forms.Label();
            this.txtHFin = new System.Windows.Forms.TextBox();
            this.lblHFin = new System.Windows.Forms.Label();
            this.txtIniRef = new System.Windows.Forms.TextBox();
            this.lblIniRef = new System.Windows.Forms.Label();
            this.txtHIni = new System.Windows.Forms.TextBox();
            this.lblHIni = new System.Windows.Forms.Label();
            this.txtPtoAten = new System.Windows.Forms.TextBox();
            this.lblPuntoAten = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSolCambioTurno
            // 
            this.dtpSolCambioTurno.Location = new System.Drawing.Point(406, 165);
            this.dtpSolCambioTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSolCambioTurno.Name = "dtpSolCambioTurno";
            this.dtpSolCambioTurno.Size = new System.Drawing.Size(501, 22);
            this.dtpSolCambioTurno.TabIndex = 106;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(175, 156);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(130, 32);
            this.lblFecha.TabIndex = 105;
            this.lblFecha.Text = "Fecha    :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(127, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 19);
            this.label11.TabIndex = 102;
            this.label11.Text = "______________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(137, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 42);
            this.label12.TabIndex = 101;
            this.label12.Text = "Intercambiar mi turno\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.btnBuscarDistribucionPersonal);
            this.gbDatosGenerales.Controls.Add(this.txtCargo);
            this.gbDatosGenerales.Controls.Add(this.lblCargo);
            this.gbDatosGenerales.Controls.Add(this.txtApe);
            this.gbDatosGenerales.Controls.Add(this.lblApe);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(181, 218);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(779, 157);
            this.gbDatosGenerales.TabIndex = 120;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos personal a intercambiar turno :";
            // 
            // btnBuscarDistribucionPersonal
            // 
            this.btnBuscarDistribucionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDistribucionPersonal.Location = new System.Drawing.Point(349, 0);
            this.btnBuscarDistribucionPersonal.Name = "btnBuscarDistribucionPersonal";
            this.btnBuscarDistribucionPersonal.Size = new System.Drawing.Size(30, 26);
            this.btnBuscarDistribucionPersonal.TabIndex = 38;
            this.btnBuscarDistribucionPersonal.Text = "...";
            this.btnBuscarDistribucionPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarDistribucionPersonal.Click += new System.EventHandler(this.btnBuscarDistribucionPersonal_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCargo.Location = new System.Drawing.Point(226, 108);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(186, 30);
            this.txtCargo.TabIndex = 37;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCargo.Location = new System.Drawing.Point(55, 109);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(91, 29);
            this.lblCargo.TabIndex = 36;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApe.Location = new System.Drawing.Point(226, 73);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(425, 30);
            this.txtApe.TabIndex = 35;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblApe.Location = new System.Drawing.Point(55, 73);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(130, 29);
            this.lblApe.TabIndex = 34;
            this.lblApe.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(226, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(425, 30);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(55, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 29);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFinRef);
            this.groupBox1.Controls.Add(this.lblFinRef);
            this.groupBox1.Controls.Add(this.txtHFin);
            this.groupBox1.Controls.Add(this.lblHFin);
            this.groupBox1.Controls.Add(this.txtIniRef);
            this.groupBox1.Controls.Add(this.lblIniRef);
            this.groupBox1.Controls.Add(this.txtHIni);
            this.groupBox1.Controls.Add(this.lblHIni);
            this.groupBox1.Controls.Add(this.txtPtoAten);
            this.groupBox1.Controls.Add(this.lblPuntoAten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(181, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 195);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos turno :";
            // 
            // txtFinRef
            // 
            this.txtFinRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFinRef.Location = new System.Drawing.Point(351, 148);
            this.txtFinRef.Name = "txtFinRef";
            this.txtFinRef.Size = new System.Drawing.Size(186, 30);
            this.txtFinRef.TabIndex = 41;
            // 
            // lblFinRef
            // 
            this.lblFinRef.AutoSize = true;
            this.lblFinRef.BackColor = System.Drawing.Color.Transparent;
            this.lblFinRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFinRef.Location = new System.Drawing.Point(55, 148);
            this.lblFinRef.Name = "lblFinRef";
            this.lblFinRef.Size = new System.Drawing.Size(226, 29);
            this.lblFinRef.TabIndex = 40;
            this.lblFinRef.Text = "Hora fin refrigerio:";
            // 
            // txtHFin
            // 
            this.txtHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHFin.Location = new System.Drawing.Point(602, 73);
            this.txtHFin.Name = "txtHFin";
            this.txtHFin.Size = new System.Drawing.Size(112, 30);
            this.txtHFin.TabIndex = 39;
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHFin.Location = new System.Drawing.Point(431, 73);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(120, 29);
            this.lblHFin.TabIndex = 38;
            this.lblHFin.Text = "Hora Fin:";
            // 
            // txtIniRef
            // 
            this.txtIniRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIniRef.Location = new System.Drawing.Point(351, 109);
            this.txtIniRef.Name = "txtIniRef";
            this.txtIniRef.Size = new System.Drawing.Size(186, 30);
            this.txtIniRef.TabIndex = 37;
            // 
            // lblIniRef
            // 
            this.lblIniRef.AutoSize = true;
            this.lblIniRef.BackColor = System.Drawing.Color.Transparent;
            this.lblIniRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblIniRef.Location = new System.Drawing.Point(55, 109);
            this.lblIniRef.Name = "lblIniRef";
            this.lblIniRef.Size = new System.Drawing.Size(261, 29);
            this.lblIniRef.TabIndex = 36;
            this.lblIniRef.Text = "Hora inicio refrigerio:";
            // 
            // txtHIni
            // 
            this.txtHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHIni.Location = new System.Drawing.Point(226, 73);
            this.txtHIni.Name = "txtHIni";
            this.txtHIni.Size = new System.Drawing.Size(112, 30);
            this.txtHIni.TabIndex = 35;
            // 
            // lblHIni
            // 
            this.lblHIni.AutoSize = true;
            this.lblHIni.BackColor = System.Drawing.Color.Transparent;
            this.lblHIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHIni.Location = new System.Drawing.Point(55, 73);
            this.lblHIni.Name = "lblHIni";
            this.lblHIni.Size = new System.Drawing.Size(146, 29);
            this.lblHIni.TabIndex = 34;
            this.lblHIni.Text = "Hora Inicio:";
            // 
            // txtPtoAten
            // 
            this.txtPtoAten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPtoAten.Location = new System.Drawing.Point(394, 37);
            this.txtPtoAten.Name = "txtPtoAten";
            this.txtPtoAten.Size = new System.Drawing.Size(257, 30);
            this.txtPtoAten.TabIndex = 20;
            // 
            // lblPuntoAten
            // 
            this.lblPuntoAten.AutoSize = true;
            this.lblPuntoAten.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoAten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoAten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblPuntoAten.Location = new System.Drawing.Point(55, 38);
            this.lblPuntoAten.Name = "lblPuntoAten";
            this.lblPuntoAten.Size = new System.Drawing.Size(232, 29);
            this.lblPuntoAten.TabIndex = 19;
            this.lblPuntoAten.Text = "Punto de Atención:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(761, 91);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 52);
            this.btnCancelar.TabIndex = 116;
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
            this.btnGuardar.Location = new System.Drawing.Point(411, 91);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 52);
            this.btnGuardar.TabIndex = 115;
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
            this.btnNuevo.Location = new System.Drawing.Point(249, 91);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(169, 52);
            this.btnNuevo.TabIndex = 114;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(587, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(174, 52);
            this.btnModificar.TabIndex = 122;
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
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_cerrarventana;
            this.btnCerrar.Location = new System.Drawing.Point(717, 630);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 123;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmSolicitarCambioTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1105, 682);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpSolCambioTurno);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSolicitarCambioTurno";
            this.Text = "frmSolicitarCambioTurno_Bibliotecario";
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpSolCambioTurno;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Button btnBuscarDistribucionPersonal;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFinRef;
        private System.Windows.Forms.Label lblFinRef;
        private System.Windows.Forms.TextBox txtHFin;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.TextBox txtIniRef;
        private System.Windows.Forms.Label lblIniRef;
        private System.Windows.Forms.TextBox txtHIni;
        private System.Windows.Forms.Label lblHIni;
        private System.Windows.Forms.TextBox txtPtoAten;
        private System.Windows.Forms.Label lblPuntoAten;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
    }
}