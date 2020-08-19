namespace Capa_Vista
{
    partial class frm_facture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facture));
            this.dtgTableBill = new System.Windows.Forms.DataGridView();
            this.clave_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_solicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label18 = new System.Windows.Forms.Label();
            this.grbContrato = new System.Windows.Forms.GroupBox();
            this.btnContrato = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbModoPago = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.btnBuscarContrato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscarContrato = new System.Windows.Forms.TextBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableBill)).BeginInit();
            this.grbContrato.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTableBill
            // 
            this.dtgTableBill.AllowUserToAddRows = false;
            this.dtgTableBill.AllowUserToOrderColumns = true;
            this.dtgTableBill.AllowUserToResizeRows = false;
            this.dtgTableBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTableBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTableBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.dtgTableBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTableBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTableBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTableBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave_servicio,
            this.servicio_solicitado,
            this.servicio_precio,
            this.servicio_cantidad,
            this.total,
            this.clave_contrato,
            this.clave_detalle});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTableBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTableBill.EnableHeadersVisualStyles = false;
            this.dtgTableBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.dtgTableBill.Location = new System.Drawing.Point(74, 373);
            this.dtgTableBill.MultiSelect = false;
            this.dtgTableBill.Name = "dtgTableBill";
            this.dtgTableBill.ReadOnly = true;
            this.dtgTableBill.RowHeadersVisible = false;
            this.dtgTableBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTableBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTableBill.ShowCellToolTips = false;
            this.dtgTableBill.ShowEditingIcon = false;
            this.dtgTableBill.Size = new System.Drawing.Size(948, 183);
            this.dtgTableBill.TabIndex = 0;
            // 
            // clave_servicio
            // 
            this.clave_servicio.DataPropertyName = "clave_servicio";
            this.clave_servicio.HeaderText = "Clave";
            this.clave_servicio.Name = "clave_servicio";
            this.clave_servicio.ReadOnly = true;
            this.clave_servicio.Width = 65;
            // 
            // servicio_solicitado
            // 
            this.servicio_solicitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_solicitado.DataPropertyName = "servicio_solicitado";
            this.servicio_solicitado.HeaderText = "Servicio";
            this.servicio_solicitado.Name = "servicio_solicitado";
            this.servicio_solicitado.ReadOnly = true;
            // 
            // servicio_precio
            // 
            this.servicio_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_precio.DataPropertyName = "servicio_precio";
            this.servicio_precio.HeaderText = "Precio";
            this.servicio_precio.Name = "servicio_precio";
            this.servicio_precio.ReadOnly = true;
            // 
            // servicio_cantidad
            // 
            this.servicio_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio_cantidad.DataPropertyName = "servicio_cantidad";
            this.servicio_cantidad.HeaderText = "Cantidad";
            this.servicio_cantidad.Name = "servicio_cantidad";
            this.servicio_cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 62;
            // 
            // clave_contrato
            // 
            this.clave_contrato.DataPropertyName = "clave_contrato";
            this.clave_contrato.HeaderText = "Clave contrato";
            this.clave_contrato.Name = "clave_contrato";
            this.clave_contrato.ReadOnly = true;
            this.clave_contrato.Visible = false;
            this.clave_contrato.Width = 121;
            // 
            // clave_detalle
            // 
            this.clave_detalle.DataPropertyName = "clave_detalle";
            this.clave_detalle.HeaderText = "Clave detalle";
            this.clave_detalle.Name = "clave_detalle";
            this.clave_detalle.ReadOnly = true;
            this.clave_detalle.Visible = false;
            this.clave_detalle.Width = 113;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 25);
            this.label19.TabIndex = 43;
            this.label19.Text = "FACTURACIÓN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1089, 696);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 4000;
            this.lineShape1.Y1 = 39;
            this.lineShape1.Y2 = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(263, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "Cliente";
            // 
            // grbContrato
            // 
            this.grbContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbContrato.BackColor = System.Drawing.Color.Transparent;
            this.grbContrato.Controls.Add(this.btnContrato);
            this.grbContrato.Controls.Add(this.label17);
            this.grbContrato.Controls.Add(this.txtCliente);
            this.grbContrato.Controls.Add(this.cmbModoPago);
            this.grbContrato.Controls.Add(this.btnBuscarCliente);
            this.grbContrato.Controls.Add(this.label14);
            this.grbContrato.Controls.Add(this.label18);
            this.grbContrato.Controls.Add(this.dtpFechaContrato);
            this.grbContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grbContrato.Location = new System.Drawing.Point(74, 65);
            this.grbContrato.Name = "grbContrato";
            this.grbContrato.Size = new System.Drawing.Size(948, 86);
            this.grbContrato.TabIndex = 49;
            this.grbContrato.TabStop = false;
            this.grbContrato.Text = "CONTRATO";
            // 
            // btnContrato
            // 
            this.btnContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContrato.BackColor = System.Drawing.Color.Transparent;
            this.btnContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContrato.FlatAppearance.BorderSize = 0;
            this.btnContrato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrato.ForeColor = System.Drawing.Color.Black;
            this.btnContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnContrato.Image")));
            this.btnContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContrato.Location = new System.Drawing.Point(819, 39);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(101, 35);
            this.btnContrato.TabIndex = 50;
            this.btnContrato.Text = "Guardar";
            this.btnContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContrato.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(590, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 51;
            this.label17.Text = "Modo de pago";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(266, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(262, 21);
            this.txtCliente.TabIndex = 51;
            // 
            // cmbModoPago
            // 
            this.cmbModoPago.BackColor = System.Drawing.SystemColors.Control;
            this.cmbModoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModoPago.FormattingEnabled = true;
            this.cmbModoPago.Location = new System.Drawing.Point(593, 39);
            this.cmbModoPago.Name = "cmbModoPago";
            this.cmbModoPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbModoPago.Size = new System.Drawing.Size(186, 23);
            this.cmbModoPago.TabIndex = 50;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(534, 32);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 34);
            this.btnBuscarCliente.TabIndex = 50;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Fecha";
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContrato.Location = new System.Drawing.Point(9, 39);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(226, 21);
            this.dtpFechaContrato.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAgregarServicio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServicio);
            this.groupBox1.Controls.Add(this.btnBuscarServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdContrato);
            this.groupBox1.Controls.Add(this.btnBuscarContrato);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(74, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 165);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVICIOS CONTRATADOS";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnAgregarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarServicio.Image")));
            this.btnAgregarServicio.Location = new System.Drawing.Point(374, 120);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(109, 34);
            this.btnAgregarServicio.TabIndex = 53;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(266, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(95, 21);
            this.txtCantidad.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(73, 72);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(90, 21);
            this.txtPrecio.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(475, 41);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(445, 65);
            this.txtDescripcion.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Descripción del servicio";
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(266, 27);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Size = new System.Drawing.Size(152, 21);
            this.txtServicio.TabIndex = 54;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarServicio.FlatAppearance.BorderSize = 0;
            this.btnBuscarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarServicio.Image")));
            this.btnBuscarServicio.Location = new System.Drawing.Point(424, 20);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(30, 34);
            this.btnBuscarServicio.TabIndex = 53;
            this.btnBuscarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Servicio";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdContrato.Location = new System.Drawing.Point(73, 29);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.ReadOnly = true;
            this.txtIdContrato.Size = new System.Drawing.Size(90, 21);
            this.txtIdContrato.TabIndex = 51;
            // 
            // btnBuscarContrato
            // 
            this.btnBuscarContrato.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarContrato.FlatAppearance.BorderSize = 0;
            this.btnBuscarContrato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContrato.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarContrato.Image")));
            this.btnBuscarContrato.Location = new System.Drawing.Point(166, 23);
            this.btnBuscarContrato.Name = "btnBuscarContrato";
            this.btnBuscarContrato.Size = new System.Drawing.Size(30, 34);
            this.btnBuscarContrato.TabIndex = 50;
            this.btnBuscarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarContrato.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Contrato";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(893, 568);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(129, 21);
            this.txtSubTotal.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(819, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(819, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Comisión";
            // 
            // cmbComision
            // 
            this.cmbComision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComision.BackColor = System.Drawing.SystemColors.Control;
            this.cmbComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(893, 595);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbComision.Size = new System.Drawing.Size(129, 23);
            this.cmbComision.TabIndex = 52;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(893, 624);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 21);
            this.txtTotal.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(819, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "Total";
            // 
            // btnFactura
            // 
            this.btnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Black;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(893, 656);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(129, 35);
            this.btnFactura.TabIndex = 67;
            this.btnFactura.Text = "Guardar";
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(205)))), ((int)(((byte)(241)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(800, 333);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(106, 35);
            this.btnReporte.TabIndex = 68;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(913, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 34);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarContrato
            // 
            this.txtBuscarContrato.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarContrato.Location = new System.Drawing.Point(181, 344);
            this.txtBuscarContrato.Name = "txtBuscarContrato";
            this.txtBuscarContrato.ReadOnly = true;
            this.txtBuscarContrato.Size = new System.Drawing.Size(141, 21);
            this.txtBuscarContrato.TabIndex = 71;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarFactura.FlatAppearance.BorderSize = 0;
            this.btnBuscarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnBuscarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnBuscarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFactura.Image")));
            this.btnBuscarFactura.Location = new System.Drawing.Point(322, 337);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(30, 34);
            this.btnBuscarFactura.TabIndex = 70;
            this.btnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFactura.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Buscar contrato";
            // 
            // frm_facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.txtBuscarContrato);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbComision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbContrato);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtgTableBill);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_facture";
            this.Text = "frm_people";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableBill)).EndInit();
            this.grbContrato.ResumeLayout(false);
            this.grbContrato.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.DataGridView dtgTableBill;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbContrato;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dtpFechaContrato;
        public System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cmbModoPago;
        public System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtIdContrato;
        public System.Windows.Forms.Button btnBuscarContrato;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtServicio;
        public System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAgregarServicio;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbComision;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnFactura;
        public System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_solicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave_detalle;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox txtBuscarContrato;
        public System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Label label8;
    }
}