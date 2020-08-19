namespace Capa_Vista
{
    partial class frm_operation_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_operation_crud));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pnlContent.Controls.Add(this.cmbModule);
            this.pnlContent.Controls.Add(this.btnAcept);
            this.pnlContent.Controls.Add(this.label17);
            this.pnlContent.Controls.Add(this.cmbAction);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(405, 147);
            this.pnlContent.TabIndex = 3;
            // 
            // cmbModule
            // 
            this.cmbModule.BackColor = System.Drawing.SystemColors.Control;
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(12, 43);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbModule.Size = new System.Drawing.Size(191, 23);
            this.cmbModule.TabIndex = 51;
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
            this.btnAcept.Location = new System.Drawing.Point(292, 100);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(101, 35);
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
            this.label17.Location = new System.Drawing.Point(206, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 46;
            this.label17.Text = "Acción";
            // 
            // cmbAction
            // 
            this.cmbAction.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Location = new System.Drawing.Point(209, 42);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAction.Size = new System.Drawing.Size(184, 23);
            this.cmbAction.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Módulo";
            // 
            // frm_operation_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 163);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_operation_crud";
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
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button btnAcept;
        public System.Windows.Forms.ComboBox cmbAction;
        public System.Windows.Forms.PictureBox ptbMinimize;
        public System.Windows.Forms.PictureBox ptbClose;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label label4;
    }
}