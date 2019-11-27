namespace TA_GesBib_Cliente
{
    partial class frmCambiarClaveConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarClaveConfig));
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCrearPuntoAtencion = new System.Windows.Forms.GroupBox();
            this.txtClaveNueva2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbCrearPuntoAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(27, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(211, 23);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "CAMBIAR CONTRASEÑA";
            // 
            // gbCrearPuntoAtencion
            // 
            this.gbCrearPuntoAtencion.Controls.Add(this.txtClaveNueva2);
            this.gbCrearPuntoAtencion.Controls.Add(this.label3);
            this.gbCrearPuntoAtencion.Controls.Add(this.txtClaveNueva);
            this.gbCrearPuntoAtencion.Controls.Add(this.label1);
            this.gbCrearPuntoAtencion.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbCrearPuntoAtencion.ForeColor = System.Drawing.Color.DarkRed;
            this.gbCrearPuntoAtencion.Location = new System.Drawing.Point(31, 42);
            this.gbCrearPuntoAtencion.Name = "gbCrearPuntoAtencion";
            this.gbCrearPuntoAtencion.Size = new System.Drawing.Size(852, 162);
            this.gbCrearPuntoAtencion.TabIndex = 47;
            this.gbCrearPuntoAtencion.TabStop = false;
            // 
            // txtClaveNueva2
            // 
            this.txtClaveNueva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClaveNueva2.Location = new System.Drawing.Point(273, 95);
            this.txtClaveNueva2.Name = "txtClaveNueva2";
            this.txtClaveNueva2.Size = new System.Drawing.Size(285, 26);
            this.txtClaveNueva2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Repite contraseña nueva:";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClaveNueva.Location = new System.Drawing.Point(227, 49);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.Size = new System.Drawing.Size(331, 26);
            this.txtClaveNueva.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contraseña nueva:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_guardar;
            this.btnGuardar.Location = new System.Drawing.Point(276, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 44);
            this.btnGuardar.TabIndex = 141;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCambiarClaveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(663, 311);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbCrearPuntoAtencion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarClaveConfig";
            this.gbCrearPuntoAtencion.ResumeLayout(false);
            this.gbCrearPuntoAtencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbCrearPuntoAtencion;
        private System.Windows.Forms.TextBox txtClaveNueva2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}