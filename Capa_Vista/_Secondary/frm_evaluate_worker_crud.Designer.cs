namespace Capa_Vista
{
    partial class frm_evaluate_worker_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_evaluate_worker_crud));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAcept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.btnBuscarTrabjador = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.ptbMinimize);
            this.pnlTop.Controls.Add(this.ptbClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(405, 16);
            this.pnlTop.TabIndex = 0;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(371, 0);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(15, 15);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimize.TabIndex = 5;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Visible = false;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(389, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(15, 15);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.txtTrabajador);
            this.pnlContent.Controls.Add(this.btnBuscarTrabjador);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtObservaciones);
            this.pnlContent.Controls.Add(this.cmbEstado);
            this.pnlContent.Controls.Add(this.label15);
            this.pnlContent.Controls.Add(this.btnAcept);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(405, 210);
            this.pnlContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.Control;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(12, 88);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(381, 68);
            this.txtObservaciones.TabIndex = 54;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Aceptado",
            "Rechazado",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(292, 43);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEstado.Size = new System.Drawing.Size(101, 23);
            this.cmbEstado.TabIndex = 53;
            this.cmbEstado.Text = "--Elegir--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(289, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "Estado";
            // 
            // btnAcept
            // 
            this.btnAcept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcept.BackColor = System.Drawing.Color.Transparent;
            this.btnAcept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcept.FlatAppearance.BorderSize = 0;
            this.btnAcept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnAcept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.ForeColor = System.Drawing.Color.Black;
            this.btnAcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAcept.Image")));
            this.btnAcept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcept.Location = new System.Drawing.Point(292, 163);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(101, 35);
            this.btnAcept.TabIndex = 19;
            this.btnAcept.Text = "Guardar";
            this.btnAcept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcept.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trabajador";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.BackColor = System.Drawing.SystemColors.Control;
            this.txtTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajador.Location = new System.Drawing.Point(12, 42);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.ReadOnly = true;
            this.txtTrabajador.Size = new System.Drawing.Size(241, 21);
            this.txtTrabajador.TabIndex = 61;
            // 
            // btnBuscarTrabjador
            // 
            this.btnBuscarTrabjador.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarTrabjador.FlatAppearance.BorderSize = 0;
            this.btnBuscarTrabjador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarTrabjador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarTrabjador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTrabjador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTrabjador.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarTrabjador.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTrabjador.Image")));
            this.btnBuscarTrabjador.Location = new System.Drawing.Point(253, 36);
            this.btnBuscarTrabjador.Name = "btnBuscarTrabjador";
            this.btnBuscarTrabjador.Size = new System.Drawing.Size(30, 34);
            this.btnBuscarTrabjador.TabIndex = 60;
            this.btnBuscarTrabjador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTrabjador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTrabjador.UseVisualStyleBackColor = false;
            // 
            // frm_evaluate_worker_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 226);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_evaluate_worker_crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_people_crud";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAcept;
        public System.Windows.Forms.PictureBox ptbMinimize;
        public System.Windows.Forms.PictureBox ptbClose;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtObservaciones;
        public System.Windows.Forms.TextBox txtTrabajador;
        public System.Windows.Forms.Button btnBuscarTrabjador;
    }
}