namespace TA_GesBib_Cliente
{
    partial class frmAsignarPersonalPuntoAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarPersonalPuntoAtencion));
            this.label6 = new System.Windows.Forms.Label();
            this.lblAsignarPersonal = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblPuntoAtencion = new System.Windows.Forms.Label();
            this.lblPerfilRequerido = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.cmbHoraIni = new System.Windows.Forms.ComboBox();
            this.cmbHoraFin = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCantOpt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPtoAtencion = new System.Windows.Forms.TextBox();
            this.txtBib = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(33, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 17);
            this.label6.TabIndex = 136;
            this.label6.Text = "______________________________";
            // 
            // lblAsignarPersonal
            // 
            this.lblAsignarPersonal.AutoSize = true;
            this.lblAsignarPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lblAsignarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblAsignarPersonal.Location = new System.Drawing.Point(45, 17);
            this.lblAsignarPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignarPersonal.Name = "lblAsignarPersonal";
            this.lblAsignarPersonal.Size = new System.Drawing.Size(244, 36);
            this.lblAsignarPersonal.TabIndex = 135;
            this.lblAsignarPersonal.Text = "Asignar Personal";
            this.lblAsignarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.BackColor = System.Drawing.Color.Transparent;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblBiblioteca.Location = new System.Drawing.Point(24, 26);
            this.lblBiblioteca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(113, 26);
            this.lblBiblioteca.TabIndex = 137;
            this.lblBiblioteca.Text = "Biblioteca:";
            this.lblBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPuntoAtencion
            // 
            this.lblPuntoAtencion.AutoSize = true;
            this.lblPuntoAtencion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPuntoAtencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblPuntoAtencion.Location = new System.Drawing.Point(24, 62);
            this.lblPuntoAtencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntoAtencion.Name = "lblPuntoAtencion";
            this.lblPuntoAtencion.Size = new System.Drawing.Size(196, 26);
            this.lblPuntoAtencion.TabIndex = 139;
            this.lblPuntoAtencion.Text = "Punto de Atención:";
            this.lblPuntoAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPuntoAtencion.Click += new System.EventHandler(this.lblPuntoAtencion_Click);
            // 
            // lblPerfilRequerido
            // 
            this.lblPerfilRequerido.AutoSize = true;
            this.lblPerfilRequerido.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfilRequerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPerfilRequerido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblPerfilRequerido.Location = new System.Drawing.Point(24, 97);
            this.lblPerfilRequerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfilRequerido.Name = "lblPerfilRequerido";
            this.lblPerfilRequerido.Size = new System.Drawing.Size(174, 26);
            this.lblPerfilRequerido.TabIndex = 141;
            this.lblPerfilRequerido.Text = "Perfil Requerido:";
            this.lblPerfilRequerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(247, 98);
            this.txtPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(452, 26);
            this.txtPerfil.TabIndex = 142;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblHoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHoraInicio.Location = new System.Drawing.Point(24, 241);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(122, 26);
            this.lblHoraInicio.TabIndex = 145;
            this.lblHoraInicio.Text = "Hora Inicio:";
            this.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHoraInicio.Click += new System.EventHandler(this.lblHoraInicio_Click);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblHoraFin.Location = new System.Drawing.Point(24, 278);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(101, 26);
            this.lblHoraFin.TabIndex = 146;
            this.lblHoraFin.Text = "Hora Fin:";
            this.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHoraFin.Click += new System.EventHandler(this.lblHoraFin_Click);
            // 
            // cmbHoraIni
            // 
            this.cmbHoraIni.FormattingEnabled = true;
            this.cmbHoraIni.Location = new System.Drawing.Point(247, 242);
            this.cmbHoraIni.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraIni.Name = "cmbHoraIni";
            this.cmbHoraIni.Size = new System.Drawing.Size(191, 28);
            this.cmbHoraIni.TabIndex = 147;
            this.cmbHoraIni.SelectedIndexChanged += new System.EventHandler(this.cmbHoraIni_SelectedIndexChanged);
            // 
            // cmbHoraFin
            // 
            this.cmbHoraFin.FormattingEnabled = true;
            this.cmbHoraFin.Location = new System.Drawing.Point(247, 279);
            this.cmbHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoraFin.Name = "cmbHoraFin";
            this.cmbHoraFin.Size = new System.Drawing.Size(191, 28);
            this.cmbHoraFin.TabIndex = 148;
            this.cmbHoraFin.SelectedIndexChanged += new System.EventHandler(this.cmbHoraFin_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtCantOpt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPtoAtencion);
            this.groupBox1.Controls.Add(this.txtBib);
            this.groupBox1.Controls.Add(this.txtPerfil);
            this.groupBox1.Controls.Add(this.cmbHoraFin);
            this.groupBox1.Controls.Add(this.lblBiblioteca);
            this.groupBox1.Controls.Add(this.cmbHoraIni);
            this.groupBox1.Controls.Add(this.lblHoraFin);
            this.groupBox1.Controls.Add(this.lblPuntoAtencion);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.lblPerfilRequerido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(36, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(721, 324);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(247, 204);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(191, 26);
            this.dtpFecha.TabIndex = 162;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(24, 204);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 26);
            this.lblFecha.TabIndex = 156;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantOpt
            // 
            this.txtCantOpt.Location = new System.Drawing.Point(247, 170);
            this.txtCantOpt.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantOpt.Name = "txtCantOpt";
            this.txtCantOpt.Size = new System.Drawing.Size(191, 26);
            this.txtCantOpt.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 154;
            this.label3.Text = "Cantidad Óptima:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantMin
            // 
            this.txtCantMin.Location = new System.Drawing.Point(247, 134);
            this.txtCantMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(191, 26);
            this.txtCantMin.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 152;
            this.label2.Text = "Cantidad Mínima:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPtoAtencion
            // 
            this.txtPtoAtencion.Location = new System.Drawing.Point(247, 63);
            this.txtPtoAtencion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPtoAtencion.Name = "txtPtoAtencion";
            this.txtPtoAtencion.Size = new System.Drawing.Size(452, 26);
            this.txtPtoAtencion.TabIndex = 151;
            this.txtPtoAtencion.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtBib
            // 
            this.txtBib.Location = new System.Drawing.Point(247, 27);
            this.txtBib.Margin = new System.Windows.Forms.Padding(4);
            this.txtBib.Name = "txtBib";
            this.txtBib.Size = new System.Drawing.Size(452, 26);
            this.txtBib.TabIndex = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPersonal);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.dgvPersonal);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.lblNombreCompleto);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(36, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(721, 299);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Asignado";
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscarPersonal.FlatAppearance.BorderSize = 0;
            this.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(392, 14);
            this.btnBuscarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(47, 42);
            this.btnBuscarPersonal.TabIndex = 151;
            this.btnBuscarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPersonal.UseVisualStyleBackColor = false;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(655, 97);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 32);
            this.btnRemove.TabIndex = 150;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(605, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 32);
            this.btnAdd.TabIndex = 149;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.dgvPersonal.Location = new System.Drawing.Point(29, 137);
            this.dgvPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(671, 142);
            this.dgvPersonal.TabIndex = 149;
            this.dgvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(247, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(452, 26);
            this.txtNombre.TabIndex = 148;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(247, 27);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(136, 26);
            this.txtCod.TabIndex = 142;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(24, 63);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(196, 26);
            this.lblNombreCompleto.TabIndex = 145;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            this.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblCodigo.Location = new System.Drawing.Point(24, 26);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 26);
            this.lblCodigo.TabIndex = 141;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(564, 706);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 49);
            this.btnGuardar.TabIndex = 151;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // frmAsignarPersonalPuntoAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(779, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAsignarPersonal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAsignarPersonalPuntoAtencion";
            this.Text = "Asignar Personal";
            this.Load += new System.EventHandler(this.frmAsignarPersonalPuntoAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAsignarPersonal;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblPuntoAtencion;
        private System.Windows.Forms.Label lblPerfilRequerido;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.ComboBox cmbHoraIni;
        private System.Windows.Forms.ComboBox cmbHoraFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantOpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPtoAtencion;
        private System.Windows.Forms.TextBox txtBib;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}