namespace TA_GesBib_Cliente
{
    partial class frmAdministrarBibliotecas
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomBib = new System.Windows.Forms.Label();
            this.txtNombreBib = new System.Windows.Forms.TextBox();
            this.gbPuntosAtencion = new System.Windows.Forms.GroupBox();
            this.btnEditarPA = new System.Windows.Forms.Button();
            this.btnAgregarPA = new System.Windows.Forms.Button();
            this.btnQuitarPA = new System.Windows.Forms.Button();
            this.dgvPuntosAtencion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantOpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomGes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreGestor = new System.Windows.Forms.TextBox();
            this.lblCodGestor = new System.Windows.Forms.Label();
            this.btnBuscarGestor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            this.gbPuntosAtencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntosAtencion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.label6);
            this.gbDatosGenerales.Controls.Add(this.lblNomBib);
            this.gbDatosGenerales.Controls.Add(this.txtNombreBib);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDatosGenerales.Location = new System.Drawing.Point(100, 144);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(746, 81);
            this.gbDatosGenerales.TabIndex = 4;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos de la Biblioteca";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(152, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = ":";
            // 
            // lblNomBib
            // 
            this.lblNomBib.AutoSize = true;
            this.lblNomBib.BackColor = System.Drawing.Color.Transparent;
            this.lblNomBib.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomBib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNomBib.Location = new System.Drawing.Point(53, 37);
            this.lblNomBib.Name = "lblNomBib";
            this.lblNomBib.Size = new System.Drawing.Size(91, 36);
            this.lblNomBib.TabIndex = 51;
            this.lblNomBib.Text = "Nombre";
            // 
            // txtNombreBib
            // 
            this.txtNombreBib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreBib.Location = new System.Drawing.Point(203, 42);
            this.txtNombreBib.Name = "txtNombreBib";
            this.txtNombreBib.Size = new System.Drawing.Size(514, 30);
            this.txtNombreBib.TabIndex = 18;
            // 
            // gbPuntosAtencion
            // 
            this.gbPuntosAtencion.Controls.Add(this.btnEditarPA);
            this.gbPuntosAtencion.Controls.Add(this.btnAgregarPA);
            this.gbPuntosAtencion.Controls.Add(this.btnQuitarPA);
            this.gbPuntosAtencion.Controls.Add(this.dgvPuntosAtencion);
            this.gbPuntosAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbPuntosAtencion.Location = new System.Drawing.Point(100, 353);
            this.gbPuntosAtencion.Name = "gbPuntosAtencion";
            this.gbPuntosAtencion.Size = new System.Drawing.Size(746, 281);
            this.gbPuntosAtencion.TabIndex = 21;
            this.gbPuntosAtencion.TabStop = false;
            this.gbPuntosAtencion.Text = "Puntos de Atención asignados";
            // 
            // btnEditarPA
            // 
            this.btnEditarPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEditarPA.FlatAppearance.BorderSize = 0;
            this.btnEditarPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPA.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_lápiz_30;
            this.btnEditarPA.Location = new System.Drawing.Point(682, 23);
            this.btnEditarPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPA.Name = "btnEditarPA";
            this.btnEditarPA.Size = new System.Drawing.Size(35, 34);
            this.btnEditarPA.TabIndex = 136;
            this.btnEditarPA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPA.UseVisualStyleBackColor = false;
            this.btnEditarPA.Click += new System.EventHandler(this.btnEditarPA_Click);
            // 
            // btnAgregarPA
            // 
            this.btnAgregarPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAgregarPA.FlatAppearance.BorderSize = 0;
            this.btnAgregarPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPA.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_más_30;
            this.btnAgregarPA.Location = new System.Drawing.Point(590, 23);
            this.btnAgregarPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPA.Name = "btnAgregarPA";
            this.btnAgregarPA.Size = new System.Drawing.Size(35, 34);
            this.btnAgregarPA.TabIndex = 135;
            this.btnAgregarPA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPA.UseVisualStyleBackColor = false;
            this.btnAgregarPA.Click += new System.EventHandler(this.btnAgregarPA_Click);
            // 
            // btnQuitarPA
            // 
            this.btnQuitarPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnQuitarPA.FlatAppearance.BorderSize = 0;
            this.btnQuitarPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPA.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_menos_30;
            this.btnQuitarPA.Location = new System.Drawing.Point(636, 23);
            this.btnQuitarPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPA.Name = "btnQuitarPA";
            this.btnQuitarPA.Size = new System.Drawing.Size(35, 34);
            this.btnQuitarPA.TabIndex = 134;
            this.btnQuitarPA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarPA.UseVisualStyleBackColor = false;
            this.btnQuitarPA.Click += new System.EventHandler(this.btnQuitarPA_Click);
            // 
            // dgvPuntosAtencion
            // 
            this.dgvPuntosAtencion.AllowUserToAddRows = false;
            this.dgvPuntosAtencion.AllowUserToDeleteRows = false;
            this.dgvPuntosAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntosAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Piso,
            this.CantMin,
            this.CantOpt,
            this.Perfil});
            this.dgvPuntosAtencion.Location = new System.Drawing.Point(58, 62);
            this.dgvPuntosAtencion.Name = "dgvPuntosAtencion";
            this.dgvPuntosAtencion.ReadOnly = true;
            this.dgvPuntosAtencion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPuntosAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntosAtencion.Size = new System.Drawing.Size(659, 189);
            this.dgvPuntosAtencion.TabIndex = 52;
            this.dgvPuntosAtencion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPuntosAtencion_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Puntos de Atención";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 158;
            // 
            // Piso
            // 
            this.Piso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Piso.Width = 60;
            // 
            // CantMin
            // 
            this.CantMin.HeaderText = "Cantidad Mínima";
            this.CantMin.Name = "CantMin";
            this.CantMin.ReadOnly = true;
            // 
            // CantOpt
            // 
            this.CantOpt.HeaderText = "Cantidad Óptima";
            this.CantOpt.Name = "CantOpt";
            this.CantOpt.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Perfil.HeaderText = "Perfil Requerido";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(203, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 30);
            this.txtCodigo.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomGes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreGestor);
            this.groupBox1.Controls.Add(this.lblCodGestor);
            this.groupBox1.Controls.Add(this.btnBuscarGestor);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(100, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Gestor";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(152, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 33);
            this.label4.TabIndex = 133;
            this.label4.Text = ":";
            // 
            // lblNomGes
            // 
            this.lblNomGes.AutoSize = true;
            this.lblNomGes.BackColor = System.Drawing.Color.Transparent;
            this.lblNomGes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomGes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNomGes.Location = new System.Drawing.Point(53, 70);
            this.lblNomGes.Name = "lblNomGes";
            this.lblNomGes.Size = new System.Drawing.Size(91, 36);
            this.lblNomGes.TabIndex = 132;
            this.lblNomGes.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(152, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 33);
            this.label2.TabIndex = 54;
            this.label2.Text = ":";
            // 
            // txtNombreGestor
            // 
            this.txtNombreGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreGestor.Location = new System.Drawing.Point(203, 72);
            this.txtNombreGestor.Name = "txtNombreGestor";
            this.txtNombreGestor.Size = new System.Drawing.Size(514, 30);
            this.txtNombreGestor.TabIndex = 131;
            // 
            // lblCodGestor
            // 
            this.lblCodGestor.AutoSize = true;
            this.lblCodGestor.BackColor = System.Drawing.Color.Transparent;
            this.lblCodGestor.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCodGestor.Location = new System.Drawing.Point(53, 33);
            this.lblCodGestor.Name = "lblCodGestor";
            this.lblCodGestor.Size = new System.Drawing.Size(80, 36);
            this.lblCodGestor.TabIndex = 53;
            this.lblCodGestor.Text = "Código";
            // 
            // btnBuscarGestor
            // 
            this.btnBuscarGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscarGestor.FlatAppearance.BorderSize = 0;
            this.btnBuscarGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarGestor.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscarGestor.Location = new System.Drawing.Point(305, 32);
            this.btnBuscarGestor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarGestor.Name = "btnBuscarGestor";
            this.btnBuscarGestor.Size = new System.Drawing.Size(35, 34);
            this.btnBuscarGestor.TabIndex = 129;
            this.btnBuscarGestor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarGestor.UseVisualStyleBackColor = false;
            this.btnBuscarGestor.Click += new System.EventHandler(this.btnBuscarGestor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(118, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(617, 52);
            this.label9.TabIndex = 134;
            this.label9.Text = "Administración de bibliotecas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(582, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 40);
            this.btnEliminar.TabIndex = 136;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnCerrar.Location = new System.Drawing.Point(47, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(65, 40);
            this.btnCerrar.TabIndex = 135;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(711, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 40);
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
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(464, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 40);
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
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(328, 83);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 40);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(202, 83);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 40);
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
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(100, 83);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 40);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmAdministrarBibliotecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(930, 657);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPuntosAtencion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbDatosGenerales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministrarBibliotecas";
            this.Text = "frmAdministrarPersonal";
            this.Load += new System.EventHandler(this.frmAdministrarBibliotecas_Load);
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbPuntosAtencion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntosAtencion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtNombreBib;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbPuntosAtencion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscarGestor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreGestor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomBib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomGes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodGestor;
        private System.Windows.Forms.Button btnAgregarPA;
        private System.Windows.Forms.Button btnQuitarPA;
        private System.Windows.Forms.Button btnEditarPA;
        private System.Windows.Forms.DataGridView dgvPuntosAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantOpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
    }
}