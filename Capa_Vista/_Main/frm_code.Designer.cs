namespace Capa_Vista
{
    partial class frm_code
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_code));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.gbxReCaptche = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblReCaptcha = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.ckbNoSoyRobot = new System.Windows.Forms.CheckBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lkl_codigo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.gbxReCaptche.SuspendLayout();
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
            this.btnAceptar.Location = new System.Drawing.Point(275, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(208, 32);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "CONTINUAR";
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
            this.pnlTop.Size = new System.Drawing.Size(506, 16);
            this.pnlTop.TabIndex = 2;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(490, 1);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(15, 15);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            // 
            // gbxReCaptche
            // 
            this.gbxReCaptche.BackColor = System.Drawing.Color.Transparent;
            this.gbxReCaptche.Controls.Add(this.btnGenerate);
            this.gbxReCaptche.Controls.Add(this.lblReCaptcha);
            this.gbxReCaptche.Controls.Add(this.txt_valor);
            this.gbxReCaptche.Controls.Add(this.lblContador);
            this.gbxReCaptche.Controls.Add(this.ckbNoSoyRobot);
            this.gbxReCaptche.Controls.Add(this.shapeContainer2);
            this.gbxReCaptche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReCaptche.Location = new System.Drawing.Point(18, 115);
            this.gbxReCaptche.Name = "gbxReCaptche";
            this.gbxReCaptche.Size = new System.Drawing.Size(221, 106);
            this.gbxReCaptche.TabIndex = 56;
            this.gbxReCaptche.TabStop = false;
            this.gbxReCaptche.Text = "Resorlver Captcha";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(152, 52);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(68, 22);
            this.btnGenerate.TabIndex = 55;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // lblReCaptcha
            // 
            this.lblReCaptcha.AutoSize = true;
            this.lblReCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReCaptcha.Location = new System.Drawing.Point(9, 52);
            this.lblReCaptcha.Name = "lblReCaptcha";
            this.lblReCaptcha.Size = new System.Drawing.Size(76, 20);
            this.lblReCaptcha.TabIndex = 4;
            this.lblReCaptcha.Text = "Captcha";
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(220)))), ((int)(((byte)(253)))));
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(6, 75);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(214, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(196, 21);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(15, 15);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0";
            // 
            // ckbNoSoyRobot
            // 
            this.ckbNoSoyRobot.AutoSize = true;
            this.ckbNoSoyRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNoSoyRobot.Location = new System.Drawing.Point(13, 20);
            this.ckbNoSoyRobot.Name = "ckbNoSoyRobot";
            this.ckbNoSoyRobot.Size = new System.Drawing.Size(131, 19);
            this.ckbNoSoyRobot.TabIndex = 0;
            this.ckbNoSoyRobot.Text = "No soy un Robot";
            this.ckbNoSoyRobot.UseVisualStyleBackColor = true;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5});
            this.shapeContainer2.Size = new System.Drawing.Size(215, 86);
            this.shapeContainer2.TabIndex = 3;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape4";
            this.lineShape5.X1 = 216;
            this.lineShape5.X2 = 4;
            this.lineShape5.Y1 = 82;
            this.lineShape5.Y2 = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Comprueba si recibiste un correo electrónico con un código de 6 digitos";
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(191)))), ((int)(((byte)(235)))));
            this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_code.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(28, 80);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(205, 20);
            this.txt_code.TabIndex = 58;
            this.txt_code.Text = "CÓDIGO";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(12, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(244, 25);
            this.label19.TabIndex = 59;
            this.label19.Text = "Código de seguridad";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape6.Enabled = false;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 496;
            this.lineShape6.X2 = 8;
            this.lineShape6.Y1 = 50;
            this.lineShape6.Y2 = 50;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape6});
            this.shapeContainer1.Size = new System.Drawing.Size(506, 233);
            this.shapeContainer1.TabIndex = 60;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 232;
            this.lineShape1.X2 = 27;
            this.lineShape1.Y1 = 102;
            this.lineShape1.Y2 = 102;
            // 
            // lkl_codigo
            // 
            this.lkl_codigo.AutoSize = true;
            this.lkl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lkl_codigo.Location = new System.Drawing.Point(320, 190);
            this.lkl_codigo.Name = "lkl_codigo";
            this.lkl_codigo.Size = new System.Drawing.Size(121, 13);
            this.lkl_codigo.TabIndex = 61;
            this.lkl_codigo.TabStop = true;
            this.lkl_codigo.Text = "¿No recibiste el código?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Enviamos el código a:";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.BackColor = System.Drawing.Color.Transparent;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(270, 95);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(38, 15);
            this.lblGmail.TabIndex = 63;
            this.lblGmail.Text = "gmail";
            // 
            // frm_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 233);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lkl_codigo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxReCaptche);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_logeo";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.gbxReCaptche.ResumeLayout(false);
            this.gbxReCaptche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.GroupBox gbxReCaptche;
        public System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.Label lblReCaptcha;
        public System.Windows.Forms.TextBox txt_valor;
        public System.Windows.Forms.Label lblContador;
        public System.Windows.Forms.CheckBox ckbNoSoyRobot;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.LinkLabel lkl_codigo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblGmail;
    }
}