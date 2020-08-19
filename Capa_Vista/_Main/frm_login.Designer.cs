namespace Capa_Vista
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lkl_recuperar = new System.Windows.Forms.LinkLabel();
            this.ptbInvisible = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInvisible)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(13, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(213, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "INICIAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.ptbClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(240, 16);
            this.pnlTop.TabIndex = 2;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(224, 1);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(15, 15);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(240, 357);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 225;
            this.lineShape2.X2 = 13;
            this.lineShape2.Y1 = 266;
            this.lineShape2.Y2 = 266;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 225;
            this.lineShape1.X2 = 13;
            this.lineShape1.Y1 = 227;
            this.lineShape1.Y2 = 227;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txt_password.Location = new System.Drawing.Point(12, 247);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(214, 15);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "CONTRASEÑA";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(208)))), ((int)(((byte)(246)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(12, 204);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(214, 20);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "USUARIO";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(38, 22);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(170, 155);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 7;
            this.ptbLogo.TabStop = false;
            // 
            // lkl_recuperar
            // 
            this.lkl_recuperar.AutoSize = true;
            this.lkl_recuperar.BackColor = System.Drawing.Color.Transparent;
            this.lkl_recuperar.Location = new System.Drawing.Point(67, 332);
            this.lkl_recuperar.Name = "lkl_recuperar";
            this.lkl_recuperar.Size = new System.Drawing.Size(111, 13);
            this.lkl_recuperar.TabIndex = 0;
            this.lkl_recuperar.TabStop = true;
            this.lkl_recuperar.Text = "¿Olvidaste tu cuenta?";
            // 
            // ptbInvisible
            // 
            this.ptbInvisible.BackColor = System.Drawing.Color.Transparent;
            this.ptbInvisible.Image = ((System.Drawing.Image)(resources.GetObject("ptbInvisible.Image")));
            this.ptbInvisible.Location = new System.Drawing.Point(209, 246);
            this.ptbInvisible.Name = "ptbInvisible";
            this.ptbInvisible.Size = new System.Drawing.Size(17, 17);
            this.ptbInvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbInvisible.TabIndex = 48;
            this.ptbInvisible.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 357);
            this.Controls.Add(this.ptbInvisible);
            this.Controls.Add(this.lkl_recuperar);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_logeo";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInvisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.PictureBox ptbClose;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox ptbLogo;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_user;
        public System.Windows.Forms.LinkLabel lkl_recuperar;
        public System.Windows.Forms.PictureBox ptbInvisible;
    }
}