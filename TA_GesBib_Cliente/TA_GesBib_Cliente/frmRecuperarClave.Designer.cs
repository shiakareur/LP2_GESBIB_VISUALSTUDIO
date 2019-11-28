namespace TA_GesBib_Cliente
{
    partial class frmRecuperarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarClave));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorreoREC = new System.Windows.Forms.TextBox();
            this.logogrande = new System.Windows.Forms.PictureBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logogrande)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnregresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcorreoREC);
            this.panel1.Controls.Add(this.logogrande);
            this.panel1.Controls.Add(this.btnAcceder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(253, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 400);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.White;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnregresar.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_regresar;
            this.btnregresar.Location = new System.Drawing.Point(27, 23);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(63, 27);
            this.btnregresar.TabIndex = 124;
            this.btnregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(37, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Le llegará un código de verificación a su correo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcorreoREC
            // 
            this.txtcorreoREC.Location = new System.Drawing.Point(128, 206);
            this.txtcorreoREC.Name = "txtcorreoREC";
            this.txtcorreoREC.Size = new System.Drawing.Size(140, 20);
            this.txtcorreoREC.TabIndex = 5;
            // 
            // logogrande
            // 
            this.logogrande.Image = global::TA_GesBib_Cliente.Properties.Resources.logoMediano;
            this.logogrande.Location = new System.Drawing.Point(130, 23);
            this.logogrande.Name = "logogrande";
            this.logogrande.Size = new System.Drawing.Size(140, 98);
            this.logogrande.TabIndex = 4;
            this.logogrande.TabStop = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcceder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(131, 299);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(139, 35);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ENVIAR";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(124, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su correo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.BackgroundImage = global::TA_GesBib_Cliente.Properties.Resources.biblioCentral_v1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 551);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecuperarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Clave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logogrande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logogrande;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorreoREC;
        private System.Windows.Forms.Button btnregresar;
    }
}