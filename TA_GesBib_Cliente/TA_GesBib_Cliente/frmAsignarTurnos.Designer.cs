namespace TA_GesBib_Cliente
{
    partial class frmAsignarTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarTurnos));
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.dgvDistri_Personal = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punto_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMiRefFin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMiRef_fin = new System.Windows.Forms.Label();
            this.txtMiHFin = new System.Windows.Forms.TextBox();
            this.lblMiH_fin = new System.Windows.Forms.Label();
            this.txtMiRefIni = new System.Windows.Forms.TextBox();
            this.lblMiRef_ini = new System.Windows.Forms.Label();
            this.txtMiHini = new System.Windows.Forms.TextBox();
            this.lblMiH_ini = new System.Windows.Forms.Label();
            this.txtMiPA = new System.Windows.Forms.TextBox();
            this.lblMiPA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarTurno = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri_Personal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombres.Location = new System.Drawing.Point(336, 434);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(425, 26);
            this.txtNombres.TabIndex = 22;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombres.Location = new System.Drawing.Point(126, 388);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(199, 25);
            this.lblNombres.TabIndex = 21;
            this.lblNombres.Text = "Buscar Personal :";
            // 
            // dgvDistri_Personal
            // 
            this.dgvDistri_Personal.AllowUserToAddRows = false;
            this.dgvDistri_Personal.AllowUserToDeleteRows = false;
            this.dgvDistri_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistri_Personal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellidos,
            this.tipo_personal,
            this.punto_atencion,
            this.fecha_nac});
            this.dgvDistri_Personal.Location = new System.Drawing.Point(264, 491);
            this.dgvDistri_Personal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDistri_Personal.Name = "dgvDistri_Personal";
            this.dgvDistri_Personal.ReadOnly = true;
            this.dgvDistri_Personal.RowTemplate.Height = 24;
            this.dgvDistri_Personal.Size = new System.Drawing.Size(543, 171);
            this.dgvDistri_Personal.TabIndex = 45;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // tipo_personal
            // 
            this.tipo_personal.HeaderText = "Tipo Personal";
            this.tipo_personal.Name = "tipo_personal";
            this.tipo_personal.ReadOnly = true;
            // 
            // punto_atencion
            // 
            this.punto_atencion.HeaderText = "Punto de Atención";
            this.punto_atencion.Name = "punto_atencion";
            this.punto_atencion.ReadOnly = true;
            // 
            // fecha_nac
            // 
            this.fecha_nac.HeaderText = "Fecha Nacimiento";
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMiRefFin);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblMiRef_fin);
            this.groupBox2.Controls.Add(this.txtMiHFin);
            this.groupBox2.Controls.Add(this.lblMiH_fin);
            this.groupBox2.Controls.Add(this.txtMiRefIni);
            this.groupBox2.Controls.Add(this.lblMiRef_ini);
            this.groupBox2.Controls.Add(this.txtMiHini);
            this.groupBox2.Controls.Add(this.lblMiH_ini);
            this.groupBox2.Controls.Add(this.txtMiPA);
            this.groupBox2.Controls.Add(this.lblMiPA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(131, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(793, 212);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(373, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "(hh:mm) ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(372, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "(hh:mm) ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label13.Location = new System.Drawing.Point(325, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 108;
            this.label13.Text = "(hh:mm) ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiRefFin
            // 
            this.txtMiRefFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiRefFin.Location = new System.Drawing.Point(219, 149);
            this.txtMiRefFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiRefFin.Name = "txtMiRefFin";
            this.txtMiRefFin.Size = new System.Drawing.Size(140, 26);
            this.txtMiRefFin.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label14.Location = new System.Drawing.Point(326, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 107;
            this.label14.Text = "(hh:mm) ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiRef_fin
            // 
            this.lblMiRef_fin.AutoSize = true;
            this.lblMiRef_fin.BackColor = System.Drawing.Color.Transparent;
            this.lblMiRef_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiRef_fin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblMiRef_fin.Location = new System.Drawing.Point(41, 153);
            this.lblMiRef_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiRef_fin.Name = "lblMiRef_fin";
            this.lblMiRef_fin.Size = new System.Drawing.Size(155, 20);
            this.lblMiRef_fin.TabIndex = 40;
            this.lblMiRef_fin.Text = "Hora fin refrigerio:";
            // 
            // txtMiHFin
            // 
            this.txtMiHFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiHFin.Location = new System.Drawing.Point(219, 89);
            this.txtMiHFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiHFin.Name = "txtMiHFin";
            this.txtMiHFin.Size = new System.Drawing.Size(85, 26);
            this.txtMiHFin.TabIndex = 39;
            // 
            // lblMiH_fin
            // 
            this.lblMiH_fin.AutoSize = true;
            this.lblMiH_fin.BackColor = System.Drawing.Color.Transparent;
            this.lblMiH_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiH_fin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblMiH_fin.Location = new System.Drawing.Point(41, 90);
            this.lblMiH_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiH_fin.Name = "lblMiH_fin";
            this.lblMiH_fin.Size = new System.Drawing.Size(83, 20);
            this.lblMiH_fin.TabIndex = 38;
            this.lblMiH_fin.Text = "Hora Fin:";
            // 
            // txtMiRefIni
            // 
            this.txtMiRefIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiRefIni.Location = new System.Drawing.Point(219, 119);
            this.txtMiRefIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiRefIni.Name = "txtMiRefIni";
            this.txtMiRefIni.Size = new System.Drawing.Size(140, 26);
            this.txtMiRefIni.TabIndex = 37;
            // 
            // lblMiRef_ini
            // 
            this.lblMiRef_ini.AutoSize = true;
            this.lblMiRef_ini.BackColor = System.Drawing.Color.Transparent;
            this.lblMiRef_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiRef_ini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblMiRef_ini.Location = new System.Drawing.Point(41, 122);
            this.lblMiRef_ini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiRef_ini.Name = "lblMiRef_ini";
            this.lblMiRef_ini.Size = new System.Drawing.Size(176, 20);
            this.lblMiRef_ini.TabIndex = 36;
            this.lblMiRef_ini.Text = "Hora inicio refrigerio:";
            // 
            // txtMiHini
            // 
            this.txtMiHini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiHini.Location = new System.Drawing.Point(219, 59);
            this.txtMiHini.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiHini.Name = "txtMiHini";
            this.txtMiHini.Size = new System.Drawing.Size(85, 26);
            this.txtMiHini.TabIndex = 35;
            // 
            // lblMiH_ini
            // 
            this.lblMiH_ini.AutoSize = true;
            this.lblMiH_ini.BackColor = System.Drawing.Color.Transparent;
            this.lblMiH_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiH_ini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblMiH_ini.Location = new System.Drawing.Point(41, 59);
            this.lblMiH_ini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiH_ini.Name = "lblMiH_ini";
            this.lblMiH_ini.Size = new System.Drawing.Size(101, 20);
            this.lblMiH_ini.TabIndex = 34;
            this.lblMiH_ini.Text = "Hora Inicio:";
            // 
            // txtMiPA
            // 
            this.txtMiPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiPA.Location = new System.Drawing.Point(219, 30);
            this.txtMiPA.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiPA.Name = "txtMiPA";
            this.txtMiPA.Size = new System.Drawing.Size(194, 26);
            this.txtMiPA.TabIndex = 20;
            // 
            // lblMiPA
            // 
            this.lblMiPA.AutoSize = true;
            this.lblMiPA.BackColor = System.Drawing.Color.Transparent;
            this.lblMiPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblMiPA.Location = new System.Drawing.Point(41, 31);
            this.lblMiPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiPA.Name = "lblMiPA";
            this.lblMiPA.Size = new System.Drawing.Size(96, 20);
            this.lblMiPA.TabIndex = 19;
            this.lblMiPA.Text = "Semestre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(92, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "___________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(90, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 33);
            this.label9.TabIndex = 131;
            this.label9.Text = "Asignación de Turnos\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(239, 85);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 40);
            this.btnGuardar.TabIndex = 129;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(159, 427);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 40);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_crear_nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(131, 85);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(126, 40);
            this.btnNuevo.TabIndex = 128;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(637, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 40);
            this.btnEliminar.TabIndex = 139;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::TA_GesBib_Cliente.Properties.Resources.icons8_cancelar_2_30;
            this.btnCancelar.Location = new System.Drawing.Point(789, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 40);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscarTurno.FlatAppearance.BorderSize = 0;
            this.btnBuscarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurno.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarTurno.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscarTurno.Location = new System.Drawing.Point(506, 85);
            this.btnBuscarTurno.Name = "btnBuscarTurno";
            this.btnBuscarTurno.Size = new System.Drawing.Size(154, 40);
            this.btnBuscarTurno.TabIndex = 137;
            this.btnBuscarTurno.Text = "BUSCAR";
            this.btnBuscarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTurno.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_modificar;
            this.btnModificar.Location = new System.Drawing.Point(369, 85);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 40);
            this.btnModificar.TabIndex = 136;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // frmAsignarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1055, 745);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarTurno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDistri_Personal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignarTurnos";
            this.Text = "frmAsignarTurnos";
            this.Load += new System.EventHandler(this.frmAsignarTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistri_Personal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDistri_Personal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMiRefFin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMiRef_fin;
        private System.Windows.Forms.TextBox txtMiHFin;
        private System.Windows.Forms.Label lblMiH_fin;
        private System.Windows.Forms.TextBox txtMiRefIni;
        private System.Windows.Forms.Label lblMiRef_ini;
        private System.Windows.Forms.TextBox txtMiHini;
        private System.Windows.Forms.Label lblMiH_ini;
        private System.Windows.Forms.TextBox txtMiPA;
        private System.Windows.Forms.Label lblMiPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn punto_atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarTurno;
        private System.Windows.Forms.Button btnModificar;
    }
}