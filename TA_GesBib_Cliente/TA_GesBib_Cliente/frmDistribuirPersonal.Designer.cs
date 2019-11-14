namespace TA_GesBib_Cliente
{
    partial class frmDistribuirPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuirPersonal));
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLunes = new System.Windows.Forms.TabPage();
            this.dgvDitribucion = new System.Windows.Forms.DataGridView();
            this.PuntoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbSemestre = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbSemana = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDistribucion = new System.Windows.Forms.Button();
            this.tbpMartes = new System.Windows.Forms.TabPage();
            this.tbpMiercoles = new System.Windows.Forms.TabPage();
            this.tbpJueves = new System.Windows.Forms.TabPage();
            this.tbpViernes = new System.Windows.Forms.TabPage();
            this.tbpSabado = new System.Windows.Forms.TabPage();
            this.tbpDomingo = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpLunes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDitribucion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbpMartes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 13);
            this.label6.TabIndex = 134;
            this.label6.Text = "_________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 33);
            this.label9.TabIndex = 133;
            this.label9.Text = "Distribución del Personal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLunes);
            this.tabControl1.Controls.Add(this.tbpMartes);
            this.tabControl1.Controls.Add(this.tbpMiercoles);
            this.tabControl1.Controls.Add(this.tbpJueves);
            this.tabControl1.Controls.Add(this.tbpViernes);
            this.tabControl1.Controls.Add(this.tbpSabado);
            this.tabControl1.Controls.Add(this.tbpDomingo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 222);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 449);
            this.tabControl1.TabIndex = 136;
            // 
            // tbpLunes
            // 
            this.tbpLunes.Controls.Add(this.dgvDitribucion);
            this.tbpLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpLunes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbpLunes.Location = new System.Drawing.Point(4, 25);
            this.tbpLunes.Name = "tbpLunes";
            this.tbpLunes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLunes.Size = new System.Drawing.Size(999, 420);
            this.tbpLunes.TabIndex = 1;
            this.tbpLunes.Text = "LUNES";
            this.tbpLunes.UseVisualStyleBackColor = true;
            // 
            // dgvDitribucion
            // 
            this.dgvDitribucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvDitribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDitribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PuntoAtencion,
            this.hora8,
            this.hora9,
            this.hora10,
            this.hora11,
            this.hora12,
            this.hora13,
            this.hora14,
            this.hora15,
            this.hora16,
            this.hora17,
            this.hora18,
            this.hora19,
            this.hora20,
            this.hora21,
            this.hora22});
            this.dgvDitribucion.Location = new System.Drawing.Point(17, 19);
            this.dgvDitribucion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDitribucion.Name = "dgvDitribucion";
            this.dgvDitribucion.RowTemplate.Height = 24;
            this.dgvDitribucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDitribucion.Size = new System.Drawing.Size(968, 386);
            this.dgvDitribucion.TabIndex = 0;
            this.dgvDitribucion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDitribucion_CellMouseDoubleClick);
            // 
            // PuntoAtencion
            // 
            this.PuntoAtencion.HeaderText = "Punto de Atención";
            this.PuntoAtencion.Name = "PuntoAtencion";
            // 
            // hora8
            // 
            this.hora8.HeaderText = "8:00";
            this.hora8.Name = "hora8";
            this.hora8.Width = 55;
            // 
            // hora9
            // 
            this.hora9.HeaderText = "9:00";
            this.hora9.Name = "hora9";
            this.hora9.Width = 55;
            // 
            // hora10
            // 
            this.hora10.HeaderText = "10:00";
            this.hora10.Name = "hora10";
            this.hora10.Width = 55;
            // 
            // hora11
            // 
            this.hora11.HeaderText = "11:00";
            this.hora11.Name = "hora11";
            this.hora11.Width = 55;
            // 
            // hora12
            // 
            this.hora12.HeaderText = "12:00";
            this.hora12.Name = "hora12";
            this.hora12.Width = 55;
            // 
            // hora13
            // 
            this.hora13.HeaderText = "13:00";
            this.hora13.Name = "hora13";
            this.hora13.Width = 55;
            // 
            // hora14
            // 
            this.hora14.HeaderText = "14:00";
            this.hora14.Name = "hora14";
            this.hora14.Width = 55;
            // 
            // hora15
            // 
            this.hora15.HeaderText = "15:00";
            this.hora15.Name = "hora15";
            this.hora15.Width = 55;
            // 
            // hora16
            // 
            this.hora16.HeaderText = "16:00";
            this.hora16.Name = "hora16";
            this.hora16.Width = 55;
            // 
            // hora17
            // 
            this.hora17.HeaderText = "17:00";
            this.hora17.Name = "hora17";
            this.hora17.Width = 55;
            // 
            // hora18
            // 
            this.hora18.HeaderText = "18:00";
            this.hora18.Name = "hora18";
            this.hora18.Width = 55;
            // 
            // hora19
            // 
            this.hora19.HeaderText = "19:00";
            this.hora19.Name = "hora19";
            this.hora19.Width = 55;
            // 
            // hora20
            // 
            this.hora20.HeaderText = "20:00";
            this.hora20.Name = "hora20";
            this.hora20.Width = 55;
            // 
            // hora21
            // 
            this.hora21.HeaderText = "21:00";
            this.hora21.Name = "hora21";
            this.hora21.Width = 55;
            // 
            // hora22
            // 
            this.hora22.HeaderText = "22:00";
            this.hora22.Name = "hora22";
            this.hora22.Width = 55;
            // 
            // rbSemestre
            // 
            this.rbSemestre.AutoSize = true;
            this.rbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbSemestre.Location = new System.Drawing.Point(14, 25);
            this.rbSemestre.Name = "rbSemestre";
            this.rbSemestre.Size = new System.Drawing.Size(98, 22);
            this.rbSemestre.TabIndex = 137;
            this.rbSemestre.TabStop = true;
            this.rbSemestre.Text = "Semestre: ";
            this.rbSemestre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 138;
            // 
            // rbSemana
            // 
            this.rbSemana.AutoSize = true;
            this.rbSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbSemana.Location = new System.Drawing.Point(14, 56);
            this.rbSemana.Name = "rbSemana";
            this.rbSemana.Size = new System.Drawing.Size(85, 22);
            this.rbSemana.TabIndex = 139;
            this.rbSemana.TabStop = true;
            this.rbSemana.Text = "Semana:";
            this.rbSemana.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFechaIni);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnBuscarDistribucion);
            this.groupBox1.Controls.Add(this.rbSemestre);
            this.groupBox1.Controls.Add(this.rbSemana);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 111);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Distribución";
            // 
            // btnBuscarDistribucion
            // 
            this.btnBuscarDistribucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnBuscarDistribucion.FlatAppearance.BorderSize = 0;
            this.btnBuscarDistribucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDistribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarDistribucion.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_buscar;
            this.btnBuscarDistribucion.Location = new System.Drawing.Point(728, 56);
            this.btnBuscarDistribucion.Name = "btnBuscarDistribucion";
            this.btnBuscarDistribucion.Size = new System.Drawing.Size(261, 37);
            this.btnBuscarDistribucion.TabIndex = 142;
            this.btnBuscarDistribucion.Text = "BUSCAR DISTRIBUCION";
            this.btnBuscarDistribucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarDistribucion.UseVisualStyleBackColor = false;
            // 
            // tbpMartes
            // 
            this.tbpMartes.Controls.Add(this.label4);
            this.tbpMartes.Controls.Add(this.label3);
            this.tbpMartes.Controls.Add(this.label2);
            this.tbpMartes.Controls.Add(this.monthCalendar1);
            this.tbpMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpMartes.Location = new System.Drawing.Point(4, 25);
            this.tbpMartes.Name = "tbpMartes";
            this.tbpMartes.Size = new System.Drawing.Size(999, 420);
            this.tbpMartes.TabIndex = 2;
            this.tbpMartes.Text = "MARTES";
            this.tbpMartes.UseVisualStyleBackColor = true;
            // 
            // tbpMiercoles
            // 
            this.tbpMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpMiercoles.Location = new System.Drawing.Point(4, 25);
            this.tbpMiercoles.Name = "tbpMiercoles";
            this.tbpMiercoles.Size = new System.Drawing.Size(999, 420);
            this.tbpMiercoles.TabIndex = 3;
            this.tbpMiercoles.Text = "MIERCOLES";
            this.tbpMiercoles.UseVisualStyleBackColor = true;
            // 
            // tbpJueves
            // 
            this.tbpJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbpJueves.Location = new System.Drawing.Point(4, 25);
            this.tbpJueves.Name = "tbpJueves";
            this.tbpJueves.Size = new System.Drawing.Size(999, 461);
            this.tbpJueves.TabIndex = 4;
            this.tbpJueves.Text = "JUEVES";
            this.tbpJueves.UseVisualStyleBackColor = true;
            // 
            // tbpViernes
            // 
            this.tbpViernes.Location = new System.Drawing.Point(4, 25);
            this.tbpViernes.Name = "tbpViernes";
            this.tbpViernes.Size = new System.Drawing.Size(999, 461);
            this.tbpViernes.TabIndex = 5;
            this.tbpViernes.Text = "VIERNES";
            this.tbpViernes.UseVisualStyleBackColor = true;
            // 
            // tbpSabado
            // 
            this.tbpSabado.Location = new System.Drawing.Point(4, 25);
            this.tbpSabado.Name = "tbpSabado";
            this.tbpSabado.Size = new System.Drawing.Size(999, 461);
            this.tbpSabado.TabIndex = 6;
            this.tbpSabado.Text = "SABADO";
            this.tbpSabado.UseVisualStyleBackColor = true;
            // 
            // tbpDomingo
            // 
            this.tbpDomingo.Location = new System.Drawing.Point(4, 25);
            this.tbpDomingo.Name = "tbpDomingo";
            this.tbpDomingo.Size = new System.Drawing.Size(999, 461);
            this.tbpDomingo.TabIndex = 7;
            this.tbpDomingo.Text = "DOMINGO";
            this.tbpDomingo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 23);
            this.dateTimePicker1.TabIndex = 143;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 46);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 144;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 23);
            this.dateTimePicker2.TabIndex = 144;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(184, 82);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(93, 17);
            this.lblFechaIni.TabIndex = 145;
            this.lblFechaIni.Text = "(Fecha Inicio)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 146;
            this.label1.Text = "(Fecha Fin)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "FALTA: colocar el botón que lleve a este formulario, ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "FALTA: Todo respecto a Avisos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(811, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "FALTA: Ver eso de la búsqueda de un personal que cumpla el perfil, creo que podrí" +
    "a colocar un checkBox para que el gestotr decida que solo le muestre los que cum" +
    "plan";
            // 
            // frmDistribuirPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1031, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDistribuirPersonal";
            this.Text = "frmDistribuirPersonal";
            this.tabControl1.ResumeLayout(false);
            this.tbpLunes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDitribucion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpMartes.ResumeLayout(false);
            this.tbpMartes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLunes;
        private System.Windows.Forms.DataGridView dgvDitribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora8;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora9;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora10;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora11;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora12;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora13;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora14;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora15;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora16;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora17;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora18;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora19;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora20;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora21;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora22;
        private System.Windows.Forms.RadioButton rbSemestre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbSemana;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarDistribucion;
        private System.Windows.Forms.TabPage tbpMartes;
        private System.Windows.Forms.TabPage tbpMiercoles;
        private System.Windows.Forms.TabPage tbpJueves;
        private System.Windows.Forms.TabPage tbpViernes;
        private System.Windows.Forms.TabPage tbpSabado;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tbpDomingo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}