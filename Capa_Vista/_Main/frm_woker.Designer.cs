﻿namespace Capa_Vista
{
    partial class frm_woker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_woker));
            this.dtgTableWorker = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.id_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_pariente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTableWorker
            // 
            this.dtgTableWorker.AllowUserToAddRows = false;
            this.dtgTableWorker.AllowUserToOrderColumns = true;
            this.dtgTableWorker.AllowUserToResizeRows = false;
            this.dtgTableWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTableWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTableWorker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.dtgTableWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTableWorker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTableWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTableWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_trabajador,
            this.clave,
            this.rfc,
            this.foto,
            this.nombre,
            this.apellido_paterno,
            this.apellido_materno,
            this.sexo,
            this.telefono_personal,
            this.telefono_pariente,
            this.correo_electronico,
            this.localidad,
            this.nombre_calle,
            this.numero_calle,
            this.municipio,
            this.estado,
            this.codigo_postal,
            this.fecha_registro,
            this.sucursal,
            this.usuario,
            this.rol,
            this.statu,
            this.fecha_modificar,
            this.estado_modificacion,
            this.trabajador,
            this.contrasena,
            this.estado_trabajador,
            this.calificacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTableWorker.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTableWorker.Enabled = false;
            this.dtgTableWorker.EnableHeadersVisualStyles = false;
            this.dtgTableWorker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.dtgTableWorker.Location = new System.Drawing.Point(0, 158);
            this.dtgTableWorker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgTableWorker.MultiSelect = false;
            this.dtgTableWorker.Name = "dtgTableWorker";
            this.dtgTableWorker.ReadOnly = true;
            this.dtgTableWorker.RowHeadersVisible = false;
            this.dtgTableWorker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTableWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTableWorker.ShowCellToolTips = false;
            this.dtgTableWorker.ShowEditingIcon = false;
            this.dtgTableWorker.Size = new System.Drawing.Size(1634, 912);
            this.dtgTableWorker.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 112);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 39;
            this.label18.Text = "Buscar";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSearch.Location = new System.Drawing.Point(93, 112);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 28);
            this.txtSearch.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(4, 14);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(328, 38);
            this.label19.TabIndex = 43;
            this.label19.Text = "TRABAJADORES";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(514, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 52);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(704, 97);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 52);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(892, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 52);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1634, 1071);
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
            // id_trabajador
            // 
            this.id_trabajador.DataPropertyName = "id_trabajador";
            this.id_trabajador.HeaderText = "ID";
            this.id_trabajador.Name = "id_trabajador";
            this.id_trabajador.ReadOnly = true;
            this.id_trabajador.Width = 63;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "Clave persona";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            this.clave.Width = 173;
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            this.rfc.ReadOnly = true;
            this.rfc.Width = 84;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Fotografía";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.MinimumWidth = 100;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.foto.Width = 135;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 113;
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "Ap.Paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            this.apellido_paterno.ReadOnly = true;
            this.apellido_paterno.Width = 144;
            // 
            // apellido_materno
            // 
            this.apellido_materno.DataPropertyName = "apellido_materno";
            this.apellido_materno.HeaderText = "Ap.Materno";
            this.apellido_materno.Name = "apellido_materno";
            this.apellido_materno.ReadOnly = true;
            this.apellido_materno.Width = 146;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 89;
            // 
            // telefono_personal
            // 
            this.telefono_personal.DataPropertyName = "telefono_personal";
            this.telefono_personal.HeaderText = "Tel.Personal";
            this.telefono_personal.Name = "telefono_personal";
            this.telefono_personal.ReadOnly = true;
            this.telefono_personal.Width = 158;
            // 
            // telefono_pariente
            // 
            this.telefono_pariente.DataPropertyName = "telefono_pariente";
            this.telefono_pariente.HeaderText = "Tel.Pariente";
            this.telefono_pariente.Name = "telefono_pariente";
            this.telefono_pariente.ReadOnly = true;
            this.telefono_pariente.Width = 154;
            // 
            // correo_electronico
            // 
            this.correo_electronico.DataPropertyName = "correo_electronico";
            this.correo_electronico.HeaderText = "Correo electrónico";
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.ReadOnly = true;
            this.correo_electronico.Width = 191;
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "localidad";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Width = 130;
            // 
            // nombre_calle
            // 
            this.nombre_calle.DataPropertyName = "nombre_calle";
            this.nombre_calle.HeaderText = "Nom.Calle";
            this.nombre_calle.Name = "nombre_calle";
            this.nombre_calle.ReadOnly = true;
            this.nombre_calle.Width = 136;
            // 
            // numero_calle
            // 
            this.numero_calle.DataPropertyName = "numero_calle";
            this.numero_calle.HeaderText = "No.Calle";
            this.numero_calle.Name = "numero_calle";
            this.numero_calle.ReadOnly = true;
            this.numero_calle.Width = 121;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 128;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 106;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Código postal";
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            this.codigo_postal.Width = 153;
            // 
            // fecha_registro
            // 
            this.fecha_registro.DataPropertyName = "fecha_registro";
            this.fecha_registro.HeaderText = "Fecha registro";
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.ReadOnly = true;
            this.fecha_registro.Width = 159;
            // 
            // sucursal
            // 
            this.sucursal.DataPropertyName = "sucursal";
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            this.sucursal.Width = 122;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 113;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 74;
            // 
            // statu
            // 
            this.statu.DataPropertyName = "statu";
            this.statu.HeaderText = "Estatus";
            this.statu.Name = "statu";
            this.statu.ReadOnly = true;
            this.statu.Width = 111;
            // 
            // fecha_modificar
            // 
            this.fecha_modificar.DataPropertyName = "fecha_modificar";
            this.fecha_modificar.HeaderText = "Fecha para modificar contraseña";
            this.fecha_modificar.Name = "fecha_modificar";
            this.fecha_modificar.ReadOnly = true;
            this.fecha_modificar.Width = 306;
            // 
            // estado_modificacion
            // 
            this.estado_modificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_modificacion.DataPropertyName = "estado_modificacion";
            this.estado_modificacion.HeaderText = "Estado de modificación de contraseña";
            this.estado_modificacion.Name = "estado_modificacion";
            this.estado_modificacion.ReadOnly = true;
            this.estado_modificacion.Width = 259;
            // 
            // trabajador
            // 
            this.trabajador.DataPropertyName = "trabajador";
            this.trabajador.HeaderText = "Trabajador";
            this.trabajador.Name = "trabajador";
            this.trabajador.ReadOnly = true;
            this.trabajador.Visible = false;
            this.trabajador.Width = 142;
            // 
            // contrasena
            // 
            this.contrasena.DataPropertyName = "contrasena";
            this.contrasena.HeaderText = "Contraseña";
            this.contrasena.Name = "contrasena";
            this.contrasena.ReadOnly = true;
            this.contrasena.Visible = false;
            this.contrasena.Width = 147;
            // 
            // estado_trabajador
            // 
            this.estado_trabajador.DataPropertyName = "estado_trabajador";
            this.estado_trabajador.HeaderText = "Estado trabajador";
            this.estado_trabajador.Name = "estado_trabajador";
            this.estado_trabajador.ReadOnly = true;
            this.estado_trabajador.Width = 186;
            // 
            // calificacion
            // 
            this.calificacion.DataPropertyName = "calificacion";
            this.calificacion.HeaderText = "Calificación crediticia";
            this.calificacion.Name = "calificacion";
            this.calificacion.ReadOnly = true;
            this.calificacion.Width = 214;
            // 
            // frm_woker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1634, 1071);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgTableWorker);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_woker";
            this.Text = "frm_people";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.DataGridView dtgTableWorker;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_pariente;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacion;
    }
}