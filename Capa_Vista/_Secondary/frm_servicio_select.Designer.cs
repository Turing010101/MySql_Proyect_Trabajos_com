namespace Capa_Vista
{
    partial class frm_servicio_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_servicio_select));
            this.dtgTableServiceS = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.clave_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableServiceS)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTableServiceS
            // 
            this.dtgTableServiceS.AllowUserToAddRows = false;
            this.dtgTableServiceS.AllowUserToOrderColumns = true;
            this.dtgTableServiceS.AllowUserToResizeRows = false;
            this.dtgTableServiceS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTableServiceS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTableServiceS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.dtgTableServiceS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTableServiceS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTableServiceS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTableServiceS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableServiceS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave_servicio,
            this.servicio_nombre,
            this.servicio_descripcion,
            this.servicio_costo,
            this.categoria,
            this.rfc_trabajador,
            this.nombre_trabajador});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTableServiceS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTableServiceS.EnableHeadersVisualStyles = false;
            this.dtgTableServiceS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.dtgTableServiceS.Location = new System.Drawing.Point(0, 100);
            this.dtgTableServiceS.MultiSelect = false;
            this.dtgTableServiceS.Name = "dtgTableServiceS";
            this.dtgTableServiceS.ReadOnly = true;
            this.dtgTableServiceS.RowHeadersVisible = false;
            this.dtgTableServiceS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTableServiceS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTableServiceS.ShowCellToolTips = false;
            this.dtgTableServiceS.ShowEditingIcon = false;
            this.dtgTableServiceS.Size = new System.Drawing.Size(881, 271);
            this.dtgTableServiceS.TabIndex = 0;
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
            this.label19.Text = "SERVICIOS";
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
            // clave_servicio
            // 
            this.clave_servicio.DataPropertyName = "clave_servicio";
            this.clave_servicio.HeaderText = "ID";
            this.clave_servicio.Name = "clave_servicio";
            this.clave_servicio.ReadOnly = true;
            this.clave_servicio.Width = 44;
            // 
            // servicio_nombre
            // 
            this.servicio_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_nombre.DataPropertyName = "servicio_nombre";
            this.servicio_nombre.HeaderText = "Servicio";
            this.servicio_nombre.Name = "servicio_nombre";
            this.servicio_nombre.ReadOnly = true;
            // 
            // servicio_descripcion
            // 
            this.servicio_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_descripcion.DataPropertyName = "servicio_descripcion";
            this.servicio_descripcion.HeaderText = "Descripción";
            this.servicio_descripcion.Name = "servicio_descripcion";
            this.servicio_descripcion.ReadOnly = true;
            // 
            // servicio_costo
            // 
            this.servicio_costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_costo.DataPropertyName = "servicio_costo";
            this.servicio_costo.HeaderText = "Costo";
            this.servicio_costo.Name = "servicio_costo";
            this.servicio_costo.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // rfc_trabajador
            // 
            this.rfc_trabajador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rfc_trabajador.DataPropertyName = "rfc_trabajador";
            this.rfc_trabajador.HeaderText = "RFC";
            this.rfc_trabajador.Name = "rfc_trabajador";
            this.rfc_trabajador.ReadOnly = true;
            // 
            // nombre_trabajador
            // 
            this.nombre_trabajador.DataPropertyName = "nombre_trabajador";
            this.nombre_trabajador.HeaderText = "Trabajador";
            this.nombre_trabajador.Name = "nombre_trabajador";
            this.nombre_trabajador.ReadOnly = true;
            // 
            // frm_servicio_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 371);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgTableServiceS);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_servicio_select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_people";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableServiceS)).EndInit();
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
        public System.Windows.Forms.DataGridView dtgTableServiceS;
        public System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_trabajador;
    }
}