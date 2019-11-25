namespace TA_GesBib_Cliente
{
    partial class frmCrearPuntoAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearPuntoAtencion));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCrearPuntoAtencion = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtCantOpt = new System.Windows.Forms.TextBox();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.gbCrearPuntoAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(780, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Perfil de Experiencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad Óptima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad Mínima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "N° de Piso:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(215, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 26);
            this.txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(27, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(246, 23);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "CREAR PUNTO DE ATENCIÓN";
            // 
            // gbCrearPuntoAtencion
            // 
            this.gbCrearPuntoAtencion.Controls.Add(this.txtCantOpt);
            this.gbCrearPuntoAtencion.Controls.Add(this.txtCantMin);
            this.gbCrearPuntoAtencion.Controls.Add(this.cmbPerfil);
            this.gbCrearPuntoAtencion.Controls.Add(this.txtPiso);
            this.gbCrearPuntoAtencion.Controls.Add(this.txtNombre);
            this.gbCrearPuntoAtencion.Controls.Add(this.label2);
            this.gbCrearPuntoAtencion.Controls.Add(this.label4);
            this.gbCrearPuntoAtencion.Controls.Add(this.label3);
            this.gbCrearPuntoAtencion.Controls.Add(this.label1);
            this.gbCrearPuntoAtencion.Controls.Add(this.label5);
            this.gbCrearPuntoAtencion.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbCrearPuntoAtencion.ForeColor = System.Drawing.Color.DarkRed;
            this.gbCrearPuntoAtencion.Location = new System.Drawing.Point(31, 48);
            this.gbCrearPuntoAtencion.Name = "gbCrearPuntoAtencion";
            this.gbCrearPuntoAtencion.Size = new System.Drawing.Size(852, 219);
            this.gbCrearPuntoAtencion.TabIndex = 47;
            this.gbCrearPuntoAtencion.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(671, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 33);
            this.btnCrear.TabIndex = 49;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtPiso
            // 
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPiso.Location = new System.Drawing.Point(215, 56);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(97, 26);
            this.txtPiso.TabIndex = 55;
            // 
            // txtCantOpt
            // 
            this.txtCantOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantOpt.Location = new System.Drawing.Point(215, 163);
            this.txtCantOpt.Name = "txtCantOpt";
            this.txtCantOpt.Size = new System.Drawing.Size(97, 26);
            this.txtCantOpt.TabIndex = 60;
            // 
            // txtCantMin
            // 
            this.txtCantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantMin.Location = new System.Drawing.Point(215, 126);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(97, 26);
            this.txtCantMin.TabIndex = 59;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(215, 91);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(331, 27);
            this.cmbPerfil.TabIndex = 58;
            // 
            // frmCrearPuntoAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(914, 311);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbCrearPuntoAtencion);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrearPuntoAtencion";
            this.gbCrearPuntoAtencion.ResumeLayout(false);
            this.gbCrearPuntoAtencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbCrearPuntoAtencion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtCantOpt;
        private System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.ComboBox cmbPerfil;
    }
}