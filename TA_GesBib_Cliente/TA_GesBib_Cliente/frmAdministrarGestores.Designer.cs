namespace TA_GesBib_Cliente
{
    partial class frmAdministrarGestores
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
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaIng = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBibAisg = new System.Windows.Forms.ComboBox();
            this.lblBibAsig = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtApellidos);
            this.gbDatosGenerales.Controls.Add(this.lblApellidos);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaNac);
            this.gbDatosGenerales.Controls.Add(this.lblFechaNac);
            this.gbDatosGenerales.Controls.Add(this.txtNombres);
            this.gbDatosGenerales.Controls.Add(this.lblNombres);
            this.gbDatosGenerales.Controls.Add(this.txtCodigo);
            this.gbDatosGenerales.Controls.Add(this.lblCodigo);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(146, 77);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(666, 215);
            this.gbDatosGenerales.TabIndex = 4;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtApellidos.Location = new System.Drawing.Point(203, 118);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(425, 27);
            this.txtApellidos.TabIndex = 35;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblApellidos.Location = new System.Drawing.Point(52, 118);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(93, 23);
            this.lblApellidos.TabIndex = 34;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.dtpFechaNac.Location = new System.Drawing.Point(203, 160);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(425, 27);
            this.dtpFechaNac.TabIndex = 22;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNac.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFechaNac.Location = new System.Drawing.Point(52, 163);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(100, 23);
            this.lblFechaNac.TabIndex = 21;
            this.lblFechaNac.Text = "Fecha Nac:";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtNombres.Location = new System.Drawing.Point(203, 72);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(425, 27);
            this.txtNombres.TabIndex = 20;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombres.Location = new System.Drawing.Point(52, 72);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(91, 23);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(203, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(251, 27);
            this.txtCodigo.TabIndex = 18;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCodigo.Location = new System.Drawing.Point(52, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 23);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(203, 75);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(425, 27);
            this.txtCorreo.TabIndex = 33;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCorreo.Location = new System.Drawing.Point(52, 73);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 23);
            this.lblCorreo.TabIndex = 32;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtClave.Location = new System.Drawing.Point(203, 118);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(425, 27);
            this.txtClave.TabIndex = 37;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblClave.Location = new System.Drawing.Point(52, 116);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(62, 23);
            this.lblClave.TabIndex = 36;
            this.lblClave.Text = "Clave:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaIng);
            this.groupBox1.Controls.Add(this.lblFechaIng);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(146, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 168);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Cuenta";
            // 
            // dtpFechaIng
            // 
            this.dtpFechaIng.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.dtpFechaIng.Location = new System.Drawing.Point(203, 32);
            this.dtpFechaIng.Name = "dtpFechaIng";
            this.dtpFechaIng.Size = new System.Drawing.Size(425, 27);
            this.dtpFechaIng.TabIndex = 41;
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIng.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFechaIng.Location = new System.Drawing.Point(52, 33);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(94, 23);
            this.lblFechaIng.TabIndex = 40;
            this.lblFechaIng.Text = "Fecha Ing:";
            this.lblFechaIng.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBibAisg);
            this.groupBox2.Controls.Add(this.lblBibAsig);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.groupBox2.Location = new System.Drawing.Point(146, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 99);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Trabajo";
            // 
            // cmbBibAisg
            // 
            this.cmbBibAisg.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.cmbBibAisg.FormattingEnabled = true;
            this.cmbBibAisg.Location = new System.Drawing.Point(203, 44);
            this.cmbBibAisg.Name = "cmbBibAisg";
            this.cmbBibAisg.Size = new System.Drawing.Size(425, 27);
            this.cmbBibAisg.TabIndex = 44;
            // 
            // lblBibAsig
            // 
            this.lblBibAsig.AutoSize = true;
            this.lblBibAsig.BackColor = System.Drawing.Color.Transparent;
            this.lblBibAsig.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibAsig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblBibAsig.Location = new System.Drawing.Point(53, 44);
            this.lblBibAsig.Name = "lblBibAsig";
            this.lblBibAsig.Size = new System.Drawing.Size(124, 23);
            this.lblBibAsig.TabIndex = 42;
            this.lblBibAsig.Text = "Bib. asignada:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_cerrarventana;
            this.btnCerrar.Location = new System.Drawing.Point(693, 605);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(119, 40);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(673, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 40);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(533, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 40);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(394, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 40);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(268, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 41;
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
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(146, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 40);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmAdministrarGestores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(930, 657);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosGenerales);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministrarGestores";
            this.Text = "frmAdministrarPersonal";
            this.Load += new System.EventHandler(this.frmAdministrarPersonal_Load);
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaIng;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBibAisg;
        private System.Windows.Forms.Label lblBibAsig;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
    }
}