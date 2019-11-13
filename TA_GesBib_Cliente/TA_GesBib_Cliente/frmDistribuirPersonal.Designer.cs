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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDitribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(53, 59);
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
            this.label9.Location = new System.Drawing.Point(57, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 33);
            this.label9.TabIndex = 133;
            this.label9.Text = "Distribución del Personal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 490);
            this.tabControl1.TabIndex = 136;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(999, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LUNES";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDitribucion);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MARTES";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dgvDitribucion.Location = new System.Drawing.Point(17, 22);
            this.dgvDitribucion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDitribucion.Name = "dgvDitribucion";
            this.dgvDitribucion.RowTemplate.Height = 24;
            this.dgvDitribucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDitribucion.Size = new System.Drawing.Size(968, 422);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(999, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MIERCOLES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // frmDistribuirPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1031, 683);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDistribuirPersonal";
            this.Text = "frmDistribuirPersonal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDitribucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDitribucion;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}