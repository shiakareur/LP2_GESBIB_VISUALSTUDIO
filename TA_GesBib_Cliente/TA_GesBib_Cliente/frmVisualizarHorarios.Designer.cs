namespace TA_GesBib_Cliente
{
    partial class frmVisualizarHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarHorarios));
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpHorarios = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(262, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1043, 38);
            this.label6.TabIndex = 95;
            this.label6.Text = "______________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(252, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(773, 98);
            this.label9.TabIndex = 94;
            this.label9.Text = "Visualizar Horarios\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpHorarios
            // 
            this.dtpHorarios.Location = new System.Drawing.Point(1942, 350);
            this.dtpHorarios.Margin = new System.Windows.Forms.Padding(7);
            this.dtpHorarios.Name = "dtpHorarios";
            this.dtpHorarios.Size = new System.Drawing.Size(588, 44);
            this.dtpHorarios.TabIndex = 123;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(1694, 325);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(248, 74);
            this.lblFecha.TabIndex = 113;
            this.lblFecha.Text = "Fecha: ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_cerrarventana;
            this.btnCerrar.Location = new System.Drawing.Point(1871, 101);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(356, 92);
            this.btnCerrar.TabIndex = 122;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(2197, 423);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(333, 91);
            this.btnBuscar.TabIndex = 126;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(744, 338);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(905, 62);
            this.txtNombre.TabIndex = 125;
            this.txtNombre.Tag = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(185, 332);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(547, 74);
            this.lblNombre.TabIndex = 124;
            this.lblNombre.Text = "Nombre personal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.TipoPersonal,
            this.PuntoAtencion,
            this.HoraInicio,
            this.HoraFin});
            this.dataGridView1.Location = new System.Drawing.Point(174, 562);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(2391, 897);
            this.dataGridView1.TabIndex = 127;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // TipoPersonal
            // 
            this.TipoPersonal.HeaderText = "Tipo de Personal";
            this.TipoPersonal.Name = "TipoPersonal";
            // 
            // PuntoAtencion
            // 
            this.PuntoAtencion.HeaderText = "Punto de Atención";
            this.PuntoAtencion.Name = "PuntoAtencion";
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora FIn";
            this.HoraFin.Name = "HoraFin";
            // 
            // frmVisualizarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(2746, 1616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtpHorarios);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmVisualizarHorarios";
            this.Text = "frmVisualizarHorarios_Bibliotecario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHorarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
    }
}