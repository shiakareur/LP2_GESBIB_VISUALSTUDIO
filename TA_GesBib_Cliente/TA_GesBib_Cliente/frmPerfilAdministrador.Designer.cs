namespace TA_GesBib_Cliente
{
    partial class frmPerfilAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAdministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdmGestores = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdmBibliotecas = new System.Windows.Forms.Button();
            this.btnAdmPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAdmGestores);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAdmBibliotecas);
            this.panel1.Controls.Add(this.btnAdmPersonal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblTipoPerfil);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 679);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_ver_grande;
            this.button2.Location = new System.Drawing.Point(25, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 61;
            this.button2.Text = "VER COMO";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAdmGestores
            // 
            this.btnAdmGestores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAdmGestores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmGestores.FlatAppearance.BorderSize = 0;
            this.btnAdmGestores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmGestores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmGestores.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_1_usuario;
            this.btnAdmGestores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmGestores.Location = new System.Drawing.Point(25, 176);
            this.btnAdmGestores.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmGestores.Name = "btnAdmGestores";
            this.btnAdmGestores.Size = new System.Drawing.Size(200, 60);
            this.btnAdmGestores.TabIndex = 60;
            this.btnAdmGestores.Text = "ADMINISTRAR\r\nGESTORES";
            this.btnAdmGestores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmGestores.UseVisualStyleBackColor = false;
            this.btnAdmGestores.Click += new System.EventHandler(this.btnAdmGestores_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_cerrar_sesion_pequeño;
            this.btnCerrarSesion.Location = new System.Drawing.Point(25, 519);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(227, 50);
            this.btnCerrarSesion.TabIndex = 59;
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_configuracion_pequeño;
            this.button3.Location = new System.Drawing.Point(25, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 58;
            this.button3.Text = "CONFIGURACIÓN";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAdmBibliotecas
            // 
            this.btnAdmBibliotecas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAdmBibliotecas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmBibliotecas.FlatAppearance.BorderSize = 0;
            this.btnAdmBibliotecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmBibliotecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmBibliotecas.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_biblioteca;
            this.btnAdmBibliotecas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmBibliotecas.Location = new System.Drawing.Point(25, 292);
            this.btnAdmBibliotecas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmBibliotecas.Name = "btnAdmBibliotecas";
            this.btnAdmBibliotecas.Size = new System.Drawing.Size(200, 60);
            this.btnAdmBibliotecas.TabIndex = 57;
            this.btnAdmBibliotecas.Text = "ADMINISTRAR BIBLIOTECAS";
            this.btnAdmBibliotecas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmBibliotecas.UseVisualStyleBackColor = false;
            this.btnAdmBibliotecas.Click += new System.EventHandler(this.btnAdmBibliotecas_Click);
            // 
            // btnAdmPersonal
            // 
            this.btnAdmPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.btnAdmPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmPersonal.FlatAppearance.BorderSize = 0;
            this.btnAdmPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmPersonal.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_personal2;
            this.btnAdmPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmPersonal.Location = new System.Drawing.Point(25, 233);
            this.btnAdmPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmPersonal.Name = "btnAdmPersonal";
            this.btnAdmPersonal.Size = new System.Drawing.Size(200, 60);
            this.btnAdmPersonal.TabIndex = 41;
            this.btnAdmPersonal.Text = "ADMINISTRAR\r\nPERSONAL";
            this.btnAdmPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmPersonal.UseVisualStyleBackColor = false;
            this.btnAdmPersonal.Click += new System.EventHandler(this.btnAdministrarPersonal_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(384, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 962);
            this.panel2.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(67)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(42, 729);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "___________________________";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::TA_GesBib_Cliente.Properties.Resources.icono_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(32, 47);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 58);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTipoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTipoPerfil.Location = new System.Drawing.Point(92, 47);
            this.lblTipoPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(84, 25);
            this.lblTipoPerfil.TabIndex = 10;
            this.lblTipoPerfil.Text = "ADMIN";
            this.lblTipoPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TA_GesBib_Cliente.Properties.Resources.logoMediano;
            this.pictureBox1.Location = new System.Drawing.Point(93, 775);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(93, 77);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(94, 24);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Arianator";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.Window;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBienvenido.Location = new System.Drawing.Point(430, 89);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(449, 33);
            this.lblBienvenido.TabIndex = 58;
            this.lblBienvenido.Text = "Bienvenido, te informamos que ...";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.Yellow;
            this.panelAviso.BackgroundImage = global::TA_GesBib_Cliente.Properties.Resources.posit;
            this.panelAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAviso.Location = new System.Drawing.Point(554, 196);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(343, 285);
            this.panelAviso.TabIndex = 59;
            // 
            // frmPerfilAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::TA_GesBib_Cliente.Properties.Resources.biblio_ari_borroso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 679);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPerfilAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmPerfilAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdmBibliotecas;
        private System.Windows.Forms.Button btnAdmPersonal;
        private System.Windows.Forms.Button btnAdmGestores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panelAviso;
    }
}