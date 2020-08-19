namespace Capa_Vista
{
    partial class frm_contrato_select
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_contrato_select));
            this.dtgTableContratoS = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.id_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableContratoS)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTableContratoS
            // 
            this.dtgTableContratoS.AllowUserToAddRows = false;
            this.dtgTableContratoS.AllowUserToOrderColumns = true;
            this.dtgTableContratoS.AllowUserToResizeRows = false;
            this.dtgTableContratoS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTableContratoS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTableContratoS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.dtgTableContratoS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTableContratoS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTableContratoS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTableContratoS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableContratoS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_contrato,
            this.rfc_cliente,
            this.nombre_cliente,
            this.modo_pago,
            this.fecha_contrato,
            this.estado,
            this.subtotal,
            this.comision,
            this.total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTableContratoS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTableContratoS.EnableHeadersVisualStyles = false;
            this.dtgTableContratoS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.dtgTableContratoS.Location = new System.Drawing.Point(0, 100);
            this.dtgTableContratoS.MultiSelect = false;
            this.dtgTableContratoS.Name = "dtgTableContratoS";
            this.dtgTableContratoS.ReadOnly = true;
            this.dtgTableContratoS.RowHeadersVisible = false;
            this.dtgTableContratoS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTableContratoS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTableContratoS.ShowCellToolTips = false;
            this.dtgTableContratoS.ShowEditingIcon = false;
            this.dtgTableContratoS.Size = new System.Drawing.Size(881, 271);
            this.dtgTableContratoS.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "Buscar";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSearch.Location = new System.Drawing.Point(62, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 21);
            this.txtSearch.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(3, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 25);
            this.label19.TabIndex = 43;
            this.label19.Text = "CONTRATOS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(326, 60);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 34);
            this.btnSelect.TabIndex = 44;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(881, 371);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 4000;
            this.lineShape1.Y1 = 49;
            this.lineShape1.Y2 = 49;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.ptbClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(881, 16);
            this.pnlTop.TabIndex = 49;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(865, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(15, 15);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(473, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 34);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // id_contrato
            // 
            this.id_contrato.DataPropertyName = "id_contrato";
            this.id_contrato.HeaderText = "ID";
            this.id_contrato.Name = "id_contrato";
            this.id_contrato.ReadOnly = true;
            this.id_contrato.Width = 44;
            // 
            // rfc_cliente
            // 
            this.rfc_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rfc_cliente.DataPropertyName = "rfc_cliente";
            this.rfc_cliente.HeaderText = "RFC";
            this.rfc_cliente.Name = "rfc_cliente";
            this.rfc_cliente.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_cliente.DataPropertyName = "nombre_cliente";
            this.nombre_cliente.HeaderText = "Cliente";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // modo_pago
            // 
            this.modo_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modo_pago.DataPropertyName = "modo_pago";
            this.modo_pago.HeaderText = "Modo de pago";
            this.modo_pago.Name = "modo_pago";
            this.modo_pago.ReadOnly = true;
            // 
            // fecha_contrato
            // 
            this.fecha_contrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_contrato.DataPropertyName = "fecha_contrato";
            this.fecha_contrato.HeaderText = "Fecha de contrato";
            this.fecha_contrato.Name = "fecha_contrato";
            this.fecha_contrato.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 74;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Visible = false;
            this.subtotal.Width = 87;
            // 
            // comision
            // 
            this.comision.DataPropertyName = "comision";
            this.comision.HeaderText = "Comisión";
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            this.comision.Visible = false;
            this.comision.Width = 90;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            this.total.Width = 62;
            // 
            // frm_contrato_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 371);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgTableContratoS);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_contrato_select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_people";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableContratoS)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.DataGridView dtgTableContratoS;
        public System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.PictureBox ptbClose;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn modo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}