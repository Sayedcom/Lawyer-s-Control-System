namespace ProyectoFinal
{
    partial class frmAbogados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgAbogados = new System.Windows.Forms.DataGridView();
            this.iDAbogadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbogados = new System.Windows.Forms.BindingSource(this.components);
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblColumna = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.bsAutoridad = new System.Windows.Forms.BindingSource(this.components);
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bsEtapaProceso = new System.Windows.Forms.BindingSource(this.components);
            this.bsEstadoAsunto = new System.Windows.Forms.BindingSource(this.components);
            this.bsAsuntos = new System.Windows.Forms.BindingSource(this.components);
            this.tpAbogado = new System.Windows.Forms.TabPage();
            this.gbHerramientas = new System.Windows.Forms.GroupBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNextel = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombreAbogado = new System.Windows.Forms.Label();
            this.lblNextel = new System.Windows.Forms.Label();
            this.lblEmailAbogado = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tpCasos = new System.Windows.Forms.TabPage();
            this.gbAsunto = new System.Windows.Forms.GroupBox();
            this.txtAutoridad = new System.Windows.Forms.TextBox();
            this.lblAutoridad = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnVerAsunto = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.cbEstadoAsunto = new System.Windows.Forms.ComboBox();
            this.lblEstadoAsunto = new System.Windows.Forms.Label();
            this.lbAsuntos = new System.Windows.Forms.ListBox();
            this.tcAbogados = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbogados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbogados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutoridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAsuntos)).BeginInit();
            this.tpAbogado.SuspendLayout();
            this.gbHerramientas.SuspendLayout();
            this.tpCasos.SuspendLayout();
            this.gbAsunto.SuspendLayout();
            this.tcAbogados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAbogados
            // 
            this.dgAbogados.AllowUserToAddRows = false;
            this.dgAbogados.AllowUserToDeleteRows = false;
            this.dgAbogados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAbogados.AutoGenerateColumns = false;
            this.dgAbogados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgAbogados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgAbogados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAbogados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAbogados.ColumnHeadersHeight = 40;
            this.dgAbogados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAbogadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fechaNDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.nextelDataGridViewTextBoxColumn});
            this.dgAbogados.DataSource = this.bsAbogados;
            this.dgAbogados.Location = new System.Drawing.Point(28, 55);
            this.dgAbogados.MultiSelect = false;
            this.dgAbogados.Name = "dgAbogados";
            this.dgAbogados.ReadOnly = true;
            this.dgAbogados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbogados.Size = new System.Drawing.Size(742, 170);
            this.dgAbogados.TabIndex = 0;
            this.dgAbogados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbogados_CellContentClick);
            this.dgAbogados.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbogados_CellEnter);
            // 
            // iDAbogadoDataGridViewTextBoxColumn
            // 
            this.iDAbogadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Abogado";
            this.iDAbogadoDataGridViewTextBoxColumn.HeaderText = "ID_Abogado";
            this.iDAbogadoDataGridViewTextBoxColumn.Name = "iDAbogadoDataGridViewTextBoxColumn";
            this.iDAbogadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 77;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 64;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 86;
            // 
            // fechaNDataGridViewTextBoxColumn
            // 
            this.fechaNDataGridViewTextBoxColumn.DataPropertyName = "FechaN";
            this.fechaNDataGridViewTextBoxColumn.HeaderText = "FechaN";
            this.fechaNDataGridViewTextBoxColumn.Name = "fechaNDataGridViewTextBoxColumn";
            this.fechaNDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNDataGridViewTextBoxColumn.Width = 75;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 84;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 80;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 71;
            // 
            // nextelDataGridViewTextBoxColumn
            // 
            this.nextelDataGridViewTextBoxColumn.DataPropertyName = "Nextel";
            this.nextelDataGridViewTextBoxColumn.HeaderText = "Nextel";
            this.nextelDataGridViewTextBoxColumn.Name = "nextelDataGridViewTextBoxColumn";
            this.nextelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextelDataGridViewTextBoxColumn.Width = 67;
            // 
            // bsAbogados
            // 
            this.bsAbogados.DataSource = typeof(ProyectoFinal.sistema.Abogados);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(28, 24);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(44, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(78, 24);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(480, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // lblColumna
            // 
            this.lblColumna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColumna.AutoSize = true;
            this.lblColumna.Location = new System.Drawing.Point(565, 26);
            this.lblColumna.Name = "lblColumna";
            this.lblColumna.Size = new System.Drawing.Size(51, 13);
            this.lblColumna.TabIndex = 3;
            this.lblColumna.Text = "Columna:";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(622, 23);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(148, 21);
            this.cbCampo.TabIndex = 6;
            // 
            // bsAutoridad
            // 
            this.bsAutoridad.DataSource = typeof(ProyectoFinal.sistema.Autoridad);
            // 
            // bsClientes
            // 
            this.bsClientes.DataSource = typeof(ProyectoFinal.sistema.Clientes);
            // 
            // bsEtapaProceso
            // 
            this.bsEtapaProceso.DataSource = typeof(ProyectoFinal.sistema.EstadoProceso);
            // 
            // bsEstadoAsunto
            // 
            this.bsEstadoAsunto.DataSource = typeof(ProyectoFinal.sistema.EstadoAsunto);
            // 
            // bsAsuntos
            // 
            this.bsAsuntos.DataSource = typeof(ProyectoFinal.sistema.Asuntos);
            // 
            // tpAbogado
            // 
            this.tpAbogado.Controls.Add(this.gbHerramientas);
            this.tpAbogado.Controls.Add(this.txtNombre);
            this.tpAbogado.Controls.Add(this.txtEmail);
            this.tpAbogado.Controls.Add(this.txtNextel);
            this.tpAbogado.Controls.Add(this.txtPassword);
            this.tpAbogado.Controls.Add(this.txtCelular);
            this.tpAbogado.Controls.Add(this.txtTelefono);
            this.tpAbogado.Controls.Add(this.txtDireccion);
            this.tpAbogado.Controls.Add(this.lblNombreAbogado);
            this.tpAbogado.Controls.Add(this.lblNextel);
            this.tpAbogado.Controls.Add(this.lblEmailAbogado);
            this.tpAbogado.Controls.Add(this.lblCelular);
            this.tpAbogado.Controls.Add(this.lblPassword);
            this.tpAbogado.Controls.Add(this.label2);
            this.tpAbogado.Controls.Add(this.lblTelefono);
            this.tpAbogado.Controls.Add(this.dtpFechaN);
            this.tpAbogado.Controls.Add(this.lblDireccion);
            this.tpAbogado.Location = new System.Drawing.Point(4, 25);
            this.tpAbogado.Name = "tpAbogado";
            this.tpAbogado.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbogado.Size = new System.Drawing.Size(731, 243);
            this.tpAbogado.TabIndex = 2;
            this.tpAbogado.Text = "Informacion Personal";
            this.tpAbogado.UseVisualStyleBackColor = true;
            // 
            // gbHerramientas
            // 
            this.gbHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHerramientas.Controls.Add(this.lblEliminar);
            this.gbHerramientas.Controls.Add(this.lblGuardar);
            this.gbHerramientas.Controls.Add(this.lblEditar);
            this.gbHerramientas.Controls.Add(this.btnEditar);
            this.gbHerramientas.Controls.Add(this.btnEliminar);
            this.gbHerramientas.Controls.Add(this.btnGuardar);
            this.gbHerramientas.Enabled = false;
            this.gbHerramientas.Location = new System.Drawing.Point(551, 11);
            this.gbHerramientas.Name = "gbHerramientas";
            this.gbHerramientas.Size = new System.Drawing.Size(139, 208);
            this.gbHerramientas.TabIndex = 39;
            this.gbHerramientas.TabStop = false;
            this.gbHerramientas.Text = "Herramientas";
            // 
            // lblEliminar
            // 
            this.lblEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(68, 162);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(56, 16);
            this.lblEliminar.TabIndex = 41;
            this.lblEliminar.Text = "Eliminar";
            // 
            // lblGuardar
            // 
            this.lblGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(67, 103);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(57, 16);
            this.lblGuardar.TabIndex = 40;
            this.lblGuardar.Text = "Guardar";
            // 
            // lblEditar
            // 
            this.lblEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditar.AutoSize = true;
            this.lblEditar.Location = new System.Drawing.Point(67, 35);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(43, 16);
            this.lblEditar.TabIndex = 39;
            this.lblEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackgroundImage = global::ProyectoFinal.Properties.Resources.edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(6, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 56);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackgroundImage = global::ProyectoFinal.Properties.Resources.error;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Location = new System.Drawing.Point(6, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 55);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackgroundImage = global::ProyectoFinal.Properties.Resources.usb;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(6, 82);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 58);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Tag = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(196, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 21);
            this.txtNombre.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 21);
            this.txtEmail.TabIndex = 23;
            // 
            // txtNextel
            // 
            this.txtNextel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNextel.Enabled = false;
            this.txtNextel.Location = new System.Drawing.Point(195, 203);
            this.txtNextel.Name = "txtNextel";
            this.txtNextel.Size = new System.Drawing.Size(309, 22);
            this.txtNextel.TabIndex = 34;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(196, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(308, 21);
            this.txtPassword.TabIndex = 24;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(195, 174);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(309, 21);
            this.txtCelular.TabIndex = 32;
            this.txtCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCelular_KeyDown);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(196, 148);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(308, 21);
            this.txtTelefono.TabIndex = 30;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(196, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(308, 21);
            this.txtDireccion.TabIndex = 28;
            // 
            // lblNombreAbogado
            // 
            this.lblNombreAbogado.AutoSize = true;
            this.lblNombreAbogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAbogado.Location = new System.Drawing.Point(25, 15);
            this.lblNombreAbogado.Name = "lblNombreAbogado";
            this.lblNombreAbogado.Size = new System.Drawing.Size(108, 15);
            this.lblNombreAbogado.TabIndex = 20;
            this.lblNombreAbogado.Text = "Nombre Completo";
            // 
            // lblNextel
            // 
            this.lblNextel.AutoSize = true;
            this.lblNextel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextel.Location = new System.Drawing.Point(25, 203);
            this.lblNextel.Name = "lblNextel";
            this.lblNextel.Size = new System.Drawing.Size(46, 16);
            this.lblNextel.TabIndex = 35;
            this.lblNextel.Text = "Nextel";
            // 
            // lblEmailAbogado
            // 
            this.lblEmailAbogado.AutoSize = true;
            this.lblEmailAbogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAbogado.Location = new System.Drawing.Point(25, 41);
            this.lblEmailAbogado.Name = "lblEmailAbogado";
            this.lblEmailAbogado.Size = new System.Drawing.Size(39, 15);
            this.lblEmailAbogado.TabIndex = 22;
            this.lblEmailAbogado.Text = "Email";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(25, 174);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 15);
            this.lblCelular.TabIndex = 33;
            this.lblCelular.Text = "Celular";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(25, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 15);
            this.lblTelefono.TabIndex = 31;
            this.lblTelefono.Text = "Teléfono (Fijo)";
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaN.Enabled = false;
            this.dtpFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(197, 95);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(307, 21);
            this.dtpFechaN.TabIndex = 27;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(25, 121);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 29;
            this.lblDireccion.Text = "Dirección";
            // 
            // tpCasos
            // 
            this.tpCasos.Controls.Add(this.gbAsunto);
            this.tpCasos.Controls.Add(this.cbEstadoAsunto);
            this.tpCasos.Controls.Add(this.lblEstadoAsunto);
            this.tpCasos.Controls.Add(this.lbAsuntos);
            this.tpCasos.Location = new System.Drawing.Point(4, 25);
            this.tpCasos.Name = "tpCasos";
            this.tpCasos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCasos.Size = new System.Drawing.Size(731, 243);
            this.tpCasos.TabIndex = 0;
            this.tpCasos.Text = "Casos";
            this.tpCasos.UseVisualStyleBackColor = true;
            // 
            // gbAsunto
            // 
            this.gbAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAsunto.Controls.Add(this.txtAutoridad);
            this.gbAsunto.Controls.Add(this.lblAutoridad);
            this.gbAsunto.Controls.Add(this.dtpFechaInicio);
            this.gbAsunto.Controls.Add(this.lblFechaInicio);
            this.gbAsunto.Controls.Add(this.btnVerAsunto);
            this.gbAsunto.Controls.Add(this.txtCliente);
            this.gbAsunto.Controls.Add(this.lblCliente);
            this.gbAsunto.Controls.Add(this.txtEtapa);
            this.gbAsunto.Controls.Add(this.lblEtapa);
            this.gbAsunto.Location = new System.Drawing.Point(339, 16);
            this.gbAsunto.Name = "gbAsunto";
            this.gbAsunto.Size = new System.Drawing.Size(370, 202);
            this.gbAsunto.TabIndex = 4;
            this.gbAsunto.TabStop = false;
            this.gbAsunto.Text = "Detalles";
            this.gbAsunto.Enter += new System.EventHandler(this.gbAsunto_Enter);
            // 
            // txtAutoridad
            // 
            this.txtAutoridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutoridad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAutoridad, "Nombre", true));
            this.txtAutoridad.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsAutoridad, "ID_Autoridad", true));
            this.txtAutoridad.Location = new System.Drawing.Point(145, 132);
            this.txtAutoridad.Name = "txtAutoridad";
            this.txtAutoridad.ReadOnly = true;
            this.txtAutoridad.Size = new System.Drawing.Size(202, 22);
            this.txtAutoridad.TabIndex = 13;
            // 
            // lblAutoridad
            // 
            this.lblAutoridad.AutoSize = true;
            this.lblAutoridad.Location = new System.Drawing.Point(22, 137);
            this.lblAutoridad.Name = "lblAutoridad";
            this.lblAutoridad.Size = new System.Drawing.Size(69, 16);
            this.lblAutoridad.TabIndex = 12;
            this.lblAutoridad.Text = "Autoridad:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(145, 105);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(202, 22);
            this.dtpFechaInicio.TabIndex = 11;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(19, 107);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(102, 16);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // btnVerAsunto
            // 
            this.btnVerAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerAsunto.Enabled = false;
            this.btnVerAsunto.Location = new System.Drawing.Point(145, 163);
            this.btnVerAsunto.Name = "btnVerAsunto";
            this.btnVerAsunto.Size = new System.Drawing.Size(201, 29);
            this.btnVerAsunto.TabIndex = 4;
            this.btnVerAsunto.Text = "Más detalles sobre asunto";
            this.btnVerAsunto.UseVisualStyleBackColor = true;
            this.btnVerAsunto.Click += new System.EventHandler(this.btnVerAsunto_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Nombre", true));
            this.txtCliente.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsClientes, "ID_Cliente", true));
            this.txtCliente.Location = new System.Drawing.Point(145, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(202, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(121, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Nombre del cliente";
            // 
            // txtEtapa
            // 
            this.txtEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapaProceso, "Nombre", true));
            this.txtEtapa.Location = new System.Drawing.Point(145, 57);
            this.txtEtapa.Multiline = true;
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.ReadOnly = true;
            this.txtEtapa.Size = new System.Drawing.Size(202, 42);
            this.txtEtapa.TabIndex = 1;
            // 
            // lblEtapa
            // 
            this.lblEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Location = new System.Drawing.Point(18, 59);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(122, 16);
            this.lblEtapa.TabIndex = 0;
            this.lblEtapa.Text = "Etapa del proceso:";
            // 
            // cbEstadoAsunto
            // 
            this.cbEstadoAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEstadoAsunto.DataSource = this.bsEstadoAsunto;
            this.cbEstadoAsunto.DisplayMember = "Nombre";
            this.cbEstadoAsunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoAsunto.FormattingEnabled = true;
            this.cbEstadoAsunto.Location = new System.Drawing.Point(147, 16);
            this.cbEstadoAsunto.Name = "cbEstadoAsunto";
            this.cbEstadoAsunto.Size = new System.Drawing.Size(165, 24);
            this.cbEstadoAsunto.TabIndex = 3;
            this.cbEstadoAsunto.ValueMember = "ID_Estado";
            this.cbEstadoAsunto.SelectedIndexChanged += new System.EventHandler(this.cbEstadoAsunto_SelectedIndexChanged);
            // 
            // lblEstadoAsunto
            // 
            this.lblEstadoAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoAsunto.AutoSize = true;
            this.lblEstadoAsunto.Location = new System.Drawing.Point(20, 22);
            this.lblEstadoAsunto.Name = "lblEstadoAsunto";
            this.lblEstadoAsunto.Size = new System.Drawing.Size(120, 16);
            this.lblEstadoAsunto.TabIndex = 2;
            this.lblEstadoAsunto.Text = "Estado del Asunto:";
            // 
            // lbAsuntos
            // 
            this.lbAsuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAsuntos.DataSource = this.bsAsuntos;
            this.lbAsuntos.DisplayMember = "Nombre";
            this.lbAsuntos.FormattingEnabled = true;
            this.lbAsuntos.ItemHeight = 16;
            this.lbAsuntos.Location = new System.Drawing.Point(23, 54);
            this.lbAsuntos.Name = "lbAsuntos";
            this.lbAsuntos.Size = new System.Drawing.Size(289, 164);
            this.lbAsuntos.TabIndex = 1;
            this.lbAsuntos.ValueMember = "ID_Asunto";
            this.lbAsuntos.SelectedIndexChanged += new System.EventHandler(this.lbAsuntos_SelectedIndexChanged);
            // 
            // tcAbogados
            // 
            this.tcAbogados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAbogados.Controls.Add(this.tpCasos);
            this.tcAbogados.Controls.Add(this.tpAbogado);
            this.tcAbogados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAbogados.Location = new System.Drawing.Point(31, 231);
            this.tcAbogados.Name = "tcAbogados";
            this.tcAbogados.SelectedIndex = 0;
            this.tcAbogados.Size = new System.Drawing.Size(739, 272);
            this.tcAbogados.TabIndex = 5;
            // 
            // frmAbogados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnEliminar;
            this.ClientSize = new System.Drawing.Size(809, 517);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.tcAbogados);
            this.Controls.Add(this.lblColumna);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgAbogados);
            this.Name = "frmAbogados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abogados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbogados_FormClosed);
            this.Load += new System.EventHandler(this.frmAbogados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbogados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbogados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutoridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAsuntos)).EndInit();
            this.tpAbogado.ResumeLayout(false);
            this.tpAbogado.PerformLayout();
            this.gbHerramientas.ResumeLayout(false);
            this.gbHerramientas.PerformLayout();
            this.tpCasos.ResumeLayout(false);
            this.tpCasos.PerformLayout();
            this.gbAsunto.ResumeLayout(false);
            this.gbAsunto.PerformLayout();
            this.tcAbogados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingSource bsAbogados;
        public System.Windows.Forms.Label lblFiltro;
        public System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.Label lblColumna;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDAbogadoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn fechaNDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nextelDataGridViewTextBoxColumn;
        public System.Windows.Forms.ComboBox cbCampo;
        internal System.Windows.Forms.DataGridView dgAbogados;
        private System.Windows.Forms.BindingSource bsEstadoAsunto;
        private System.Windows.Forms.BindingSource bsAsuntos;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsEtapaProceso;
        private System.Windows.Forms.BindingSource bsAutoridad;
        public System.Windows.Forms.TabPage tpAbogado;
        private System.Windows.Forms.GroupBox gbHerramientas;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblEditar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNextel;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.Label lblNombreAbogado;
        public System.Windows.Forms.Label lblNextel;
        public System.Windows.Forms.Label lblEmailAbogado;
        public System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.DateTimePicker dtpFechaN;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TabPage tpCasos;
        private System.Windows.Forms.GroupBox gbAsunto;
        private System.Windows.Forms.TextBox txtAutoridad;
        private System.Windows.Forms.Label lblAutoridad;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnVerAsunto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.ComboBox cbEstadoAsunto;
        private System.Windows.Forms.Label lblEstadoAsunto;
        private System.Windows.Forms.ListBox lbAsuntos;
        public System.Windows.Forms.TabControl tcAbogados;

    }
}