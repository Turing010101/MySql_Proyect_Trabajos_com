namespace Capa_Vista
{
    partial class frm_people
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_people));
            this.dtgTablePeople = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnEstablish = new System.Windows.Forms.Button();
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
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTablePeople
            // 
            this.dtgTablePeople.AllowUserToAddRows = false;
            this.dtgTablePeople.AllowUserToOrderColumns = true;
            this.dtgTablePeople.AllowUserToResizeRows = false;
            this.dtgTablePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTablePeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTablePeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.dtgTablePeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTablePeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablePeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTablePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablePeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.usuario,
            this.contrasena,
            this.rol,
            this.statu,
            this.fecha_modificar,
            this.estado_modificacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTablePeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTablePeople.Enabled = false;
            this.dtgTablePeople.EnableHeadersVisualStyles = false;
            this.dtgTablePeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.dtgTablePeople.Location = new System.Drawing.Point(0, 103);
            this.dtgTablePeople.MultiSelect = false;
            this.dtgTablePeople.Name = "dtgTablePeople";
            this.dtgTablePeople.ReadOnly = true;
            this.dtgTablePeople.RowHeadersVisible = false;
            this.dtgTablePeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTablePeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTablePeople.ShowCellToolTips = false;
            this.dtgTablePeople.ShowEditingIcon = false;
            this.dtgTablePeople.Size = new System.Drawing.Size(1089, 593);
            this.dtgTablePeople.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "Buscar";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSearch.Location = new System.Drawing.Point(62, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 21);
            this.txtSearch.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 25);
            this.label19.TabIndex = 43;
            this.label19.Text = "PERSONAS";
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
            this.btnAdd.Location = new System.Drawing.Point(343, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
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
            this.btnUpdate.Location = new System.Drawing.Point(469, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 34);
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
            this.btnDelete.Location = new System.Drawing.Point(595, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 34);
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
            // btnEstablish
            // 
            this.btnEstablish.BackColor = System.Drawing.Color.Transparent;
            this.btnEstablish.Enabled = false;
            this.btnEstablish.FlatAppearance.BorderSize = 0;
            this.btnEstablish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnEstablish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.btnEstablish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablish.ForeColor = System.Drawing.Color.Black;
            this.btnEstablish.Image = ((System.Drawing.Image)(resources.GetObject("btnEstablish.Image")));
            this.btnEstablish.Location = new System.Drawing.Point(721, 64);
            this.btnEstablish.Name = "btnEstablish";
            this.btnEstablish.Size = new System.Drawing.Size(127, 34);
            this.btnEstablish.TabIndex = 49;
            this.btnEstablish.Text = " Establecer";
            this.btnEstablish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstablish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstablish.UseVisualStyleBackColor = false;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "ID";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 44;
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            this.rfc.ReadOnly = true;
            this.rfc.Width = 57;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Fotografía";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 76;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 81;
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "Ap.Paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            this.apellido_paterno.ReadOnly = true;
            // 
            // apellido_materno
            // 
            this.apellido_materno.DataPropertyName = "apellido_materno";
            this.apellido_materno.HeaderText = "Ap.Materno";
            this.apellido_materno.Name = "apellido_materno";
            this.apellido_materno.ReadOnly = true;
            this.apellido_materno.Width = 103;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 62;
            // 
            // telefono_personal
            // 
            this.telefono_personal.DataPropertyName = "telefono_personal";
            this.telefono_personal.HeaderText = "Tel.Personal";
            this.telefono_personal.Name = "telefono_personal";
            this.telefono_personal.ReadOnly = true;
            this.telefono_personal.Width = 111;
            // 
            // telefono_pariente
            // 
            this.telefono_pariente.DataPropertyName = "telefono_pariente";
            this.telefono_pariente.HeaderText = "Tel.Pariente";
            this.telefono_pariente.Name = "telefono_pariente";
            this.telefono_pariente.ReadOnly = true;
            this.telefono_pariente.Width = 108;
            // 
            // correo_electronico
            // 
            this.correo_electronico.DataPropertyName = "correo_electronico";
            this.correo_electronico.HeaderText = "Correo electrónico";
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.ReadOnly = true;
            this.correo_electronico.Width = 135;
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "localidad";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Width = 93;
            // 
            // nombre_calle
            // 
            this.nombre_calle.DataPropertyName = "nombre_calle";
            this.nombre_calle.HeaderText = "Nom.Calle";
            this.nombre_calle.Name = "nombre_calle";
            this.nombre_calle.ReadOnly = true;
            this.nombre_calle.Width = 97;
            // 
            // numero_calle
            // 
            this.numero_calle.DataPropertyName = "numero_calle";
            this.numero_calle.HeaderText = "No.Calle";
            this.numero_calle.Name = "numero_calle";
            this.numero_calle.ReadOnly = true;
            this.numero_calle.Width = 85;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 93;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 74;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Código postal";
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            this.codigo_postal.Width = 108;
            // 
            // fecha_registro
            // 
            this.fecha_registro.DataPropertyName = "fecha_registro";
            this.fecha_registro.HeaderText = "Fecha registro";
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.ReadOnly = true;
            this.fecha_registro.Width = 112;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 80;
            // 
            // contrasena
            // 
            this.contrasena.DataPropertyName = "contrasena";
            this.contrasena.HeaderText = "Contraseña";
            this.contrasena.Name = "contrasena";
            this.contrasena.ReadOnly = true;
            this.contrasena.Width = 103;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 52;
            // 
            // statu
            // 
            this.statu.DataPropertyName = "statu";
            this.statu.HeaderText = "Estado";
            this.statu.Name = "statu";
            this.statu.ReadOnly = true;
            this.statu.Width = 74;
            // 
            // fecha_modificar
            // 
            this.fecha_modificar.DataPropertyName = "fecha_modificar";
            this.fecha_modificar.HeaderText = "Fecha para modificar contraseña";
            this.fecha_modificar.Name = "fecha_modificar";
            this.fecha_modificar.ReadOnly = true;
            this.fecha_modificar.Width = 219;
            // 
            // estado_modificacion
            // 
            this.estado_modificacion.DataPropertyName = "estado_modificacion";
            this.estado_modificacion.HeaderText = "Estado de modificación de contraseña";
            this.estado_modificacion.Name = "estado_modificacion";
            this.estado_modificacion.ReadOnly = true;
            this.estado_modificacion.Width = 185;
            // 
            // frm_people
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 696);
            this.Controls.Add(this.btnEstablish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgTablePeople);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_people";
            this.Text = "frm_people";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablePeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.DataGridView dtgTablePeople;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnEstablish;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_modificacion;
    }
}