namespace Capa_Vista
{
    partial class frm_employee_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employee_crud));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOffice = new System.Windows.Forms.ComboBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtJefeInmediato = new System.Windows.Forms.TextBox();
            this.btnBuscarJefeInmediato = new System.Windows.Forms.Button();
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
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(608, 25);
            this.pnlTop.TabIndex = 0;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(556, 0);
            this.ptbMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(22, 23);
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
            this.ptbClose.Location = new System.Drawing.Point(584, 0);
            this.ptbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(22, 23);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.txtJefeInmediato);
            this.pnlContent.Controls.Add(this.btnBuscarJefeInmediato);
            this.pnlContent.Controls.Add(this.txtEmpleado);
            this.pnlContent.Controls.Add(this.btnBuscarEmpleado);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.cmbTurn);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.cmbOffice);
            this.pnlContent.Controls.Add(this.btnAcept);
            this.pnlContent.Controls.Add(this.label17);
            this.pnlContent.Controls.Add(this.cmbPost);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.lblFirstName);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(608, 360);
            this.pnlContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Turno";
            // 
            // cmbTurn
            // 
            this.cmbTurn.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(18, 223);
            this.cmbTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTurn.Size = new System.Drawing.Size(276, 30);
            this.cmbTurn.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sucursal";
            // 
            // cmbOffice
            // 
            this.cmbOffice.BackColor = System.Drawing.SystemColors.Control;
            this.cmbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice.FormattingEnabled = true;
            this.cmbOffice.Location = new System.Drawing.Point(368, 145);
            this.cmbOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOffice.Size = new System.Drawing.Size(220, 30);
            this.cmbOffice.TabIndex = 47;
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
            this.btnAcept.Location = new System.Drawing.Point(436, 277);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(152, 54);
            this.btnAcept.TabIndex = 19;
            this.btnAcept.Text = "Guardar";
            this.btnAcept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcept.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(363, 35);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 22);
            this.label17.TabIndex = 46;
            this.label17.Text = "Puesto";
            // 
            // cmbPost
            // 
            this.cmbPost.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(368, 65);
            this.cmbPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPost.Size = new System.Drawing.Size(220, 30);
            this.cmbPost.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Empleado";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(14, 119);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(140, 22);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "Jefe inmediato";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(18, 65);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(290, 28);
            this.txtEmpleado.TabIndex = 61;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(309, 54);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(45, 52);
            this.btnBuscarEmpleado.TabIndex = 60;
            this.btnBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtJefeInmediato
            // 
            this.txtJefeInmediato.BackColor = System.Drawing.SystemColors.Control;
            this.txtJefeInmediato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJefeInmediato.Location = new System.Drawing.Point(18, 147);
            this.txtJefeInmediato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJefeInmediato.Name = "txtJefeInmediato";
            this.txtJefeInmediato.ReadOnly = true;
            this.txtJefeInmediato.Size = new System.Drawing.Size(290, 28);
            this.txtJefeInmediato.TabIndex = 63;
            // 
            // btnBuscarJefeInmediato
            // 
            this.btnBuscarJefeInmediato.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarJefeInmediato.FlatAppearance.BorderSize = 0;
            this.btnBuscarJefeInmediato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarJefeInmediato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarJefeInmediato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarJefeInmediato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarJefeInmediato.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarJefeInmediato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarJefeInmediato.Image")));
            this.btnBuscarJefeInmediato.Location = new System.Drawing.Point(309, 136);
            this.btnBuscarJefeInmediato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarJefeInmediato.Name = "btnBuscarJefeInmediato";
            this.btnBuscarJefeInmediato.Size = new System.Drawing.Size(45, 52);
            this.btnBuscarJefeInmediato.TabIndex = 62;
            this.btnBuscarJefeInmediato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarJefeInmediato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarJefeInmediato.UseVisualStyleBackColor = false;
            // 
            // frm_employee_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 385);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_employee_crud";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button btnAcept;
        public System.Windows.Forms.ComboBox cmbPost;
        public System.Windows.Forms.PictureBox ptbMinimize;
        public System.Windows.Forms.PictureBox ptbClose;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbOffice;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtJefeInmediato;
        public System.Windows.Forms.Button btnBuscarJefeInmediato;
        public System.Windows.Forms.TextBox txtEmpleado;
        public System.Windows.Forms.Button btnBuscarEmpleado;
    }
}