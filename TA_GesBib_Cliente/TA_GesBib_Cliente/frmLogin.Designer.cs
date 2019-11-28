namespace TA_GesBib_Cliente
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOlvideCredenciales = new System.Windows.Forms.Label();
            this.logogrande = new System.Windows.Forms.PictureBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeHolderUsuario = new TA_GesBib_Cliente.PlaceHolderTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logogrande)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.placeHolderUsuario);
            this.panel1.Controls.Add(this.lblOlvideCredenciales);
            this.panel1.Controls.Add(this.logogrande);
            this.panel1.Controls.Add(this.btnAcceder);
            this.panel1.Controls.Add(this.txtcontraseña);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(253, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 400);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // lblOlvideCredenciales
            // 
            this.lblOlvideCredenciales.AutoSize = true;
            this.lblOlvideCredenciales.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideCredenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(252)))));
            this.lblOlvideCredenciales.Location = new System.Drawing.Point(134, 344);
            this.lblOlvideCredenciales.Name = "lblOlvideCredenciales";
            this.lblOlvideCredenciales.Size = new System.Drawing.Size(136, 17);
            this.lblOlvideCredenciales.TabIndex = 5;
            this.lblOlvideCredenciales.Text = "Olvidé mi contraseña";
            this.lblOlvideCredenciales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOlvideCredenciales.Click += new System.EventHandler(this.lblOlvideCredenciales_Click);
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
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(129, 292);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(139, 35);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(130, 250);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(139, 23);
            this.txtcontraseña.TabIndex = 3;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(126, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(125, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // placeHolderUsuario
            // 
            this.placeHolderUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.placeHolderUsuario.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderUsuario.Location = new System.Drawing.Point(130, 174);
            this.placeHolderUsuario.Name = "placeHolderUsuario";
            this.placeHolderUsuario.PlaceHolderText = null;
            this.placeHolderUsuario.Size = new System.Drawing.Size(138, 20);
            this.placeHolderUsuario.TabIndex = 6;
            this.placeHolderUsuario.Text = "username@example.com";
            this.placeHolderUsuario.TextChanged += new System.EventHandler(this.placeHolderUsuario_TextChanged);
            // 
            // frmLogin
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
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logogrande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOlvideCredenciales;
        private System.Windows.Forms.PictureBox logogrande;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PlaceHolderTextBox placeHolderUsuario;
    }
}