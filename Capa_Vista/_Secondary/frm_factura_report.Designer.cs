namespace Capa_Vista
{
    partial class frm_factura_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_factura_report));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.rpvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.pnlTop.Size = new System.Drawing.Size(707, 16);
            this.pnlTop.TabIndex = 0;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(673, 0);
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
            this.ptbClose.Location = new System.Drawing.Point(691, 0);
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
            this.pnlContent.Controls.Add(this.rpvFactura);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(707, 568);
            this.pnlContent.TabIndex = 3;
            // 
            // rpvFactura
            // 
            this.rpvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvFactura.LocalReport.ReportEmbeddedResource = "Capa_Vista._Secondary.ifm_factura.rdlc";
            this.rpvFactura.Location = new System.Drawing.Point(0, 0);
            this.rpvFactura.Name = "rpvFactura";
            this.rpvFactura.ServerReport.BearerToken = null;
            this.rpvFactura.Size = new System.Drawing.Size(707, 568);
            this.rpvFactura.TabIndex = 0;
            // 
            // frm_factura_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 584);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_factura_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_people_crud";
            this.Load += new System.EventHandler(this.frm_factura_report_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox ptbMinimize;
        public System.Windows.Forms.PictureBox ptbClose;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Panel pnlContent;
        public Microsoft.Reporting.WinForms.ReportViewer rpvFactura;
        // public Microsoft.Reporting.WinForms.ReportViewer rpv_factura;
    }
}