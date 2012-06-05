namespace ProyectoFinal
{
    partial class frmAsunto
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnGuardarAsunto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.cbAbogado = new System.Windows.Forms.ComboBox();
            this.bsAbogados = new System.Windows.Forms.BindingSource(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblAbogado = new System.Windows.Forms.Label();
            this.cbAutoridad = new System.Windows.Forms.ComboBox();
            this.bsAutoridad = new System.Windows.Forms.BindingSource(this.components);
            this.lbAutoridad = new System.Windows.Forms.Label();
            this.cbProceso = new System.Windows.Forms.ComboBox();
            this.bsProceso = new System.Windows.Forms.BindingSource(this.components);
            this.lbProceso = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.bsEstadoAsunto = new System.Windows.Forms.BindingSource(this.components);
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbFechafin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bsEtapaAsunto = new System.Windows.Forms.BindingSource(this.components);
            this.bsEtapaProceso = new System.Windows.Forms.BindingSource(this.components);
            this.tcEtapasPagos = new System.Windows.Forms.TabControl();
            this.tpEtapaAsunto = new System.Windows.Forms.TabPage();
            this.lblEtapasProcesalesDescripcion = new System.Windows.Forms.Label();
            this.btnVerArchivos = new System.Windows.Forms.Button();
            this.btnAgregarEtapa = new System.Windows.Forms.Button();
            this.btnEliminarEtapa = new System.Windows.Forms.Button();
            this.btnEditarEtapa = new System.Windows.Forms.Button();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.lblDiasVencimiento = new System.Windows.Forms.Label();
            this.txtDescripcionProceso = new System.Windows.Forms.TextBox();
            this.lblDescripcionProceso = new System.Windows.Forms.Label();
            this.txtDescripcionEtapa = new System.Windows.Forms.TextBox();
            this.dtpFechaInicioEtapaProcesal = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcionAsunto = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblEtapasProcesales = new System.Windows.Forms.Label();
            this.cbEtapasProcesoAsunto = new System.Windows.Forms.ComboBox();
            this.bsEtapaAsuntoCombo = new System.Windows.Forms.BindingSource(this.components);
            this.tpPagos = new System.Windows.Forms.TabPage();
            this.gbPagos = new System.Windows.Forms.GroupBox();
            this.lblCantidadRestante = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPago = new System.Windows.Forms.BindingSource(this.components);
            this.gbConvenio = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbTipoMoneda = new System.Windows.Forms.ComboBox();
            this.bsTipoMoneda = new System.Windows.Forms.BindingSource(this.components);
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDescripcionConvenio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbogados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutoridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaProceso)).BeginInit();
            this.tcEtapasPagos.SuspendLayout();
            this.tpEtapaAsunto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaAsuntoCombo)).BeginInit();
            this.tpPagos.SuspendLayout();
            this.gbPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPago)).BeginInit();
            this.gbConvenio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gb.Controls.Add(this.btnGuardarAsunto);
            this.gb.Controls.Add(this.button1);
            this.gb.Controls.Add(this.cbCliente);
            this.gb.Controls.Add(this.cbAbogado);
            this.gb.Controls.Add(this.lblCliente);
            this.gb.Controls.Add(this.btnEditar);
            this.gb.Controls.Add(this.lblAbogado);
            this.gb.Controls.Add(this.cbAutoridad);
            this.gb.Controls.Add(this.lbAutoridad);
            this.gb.Controls.Add(this.cbProceso);
            this.gb.Controls.Add(this.lbProceso);
            this.gb.Controls.Add(this.cbEstado);
            this.gb.Controls.Add(this.lbEstado);
            this.gb.Controls.Add(this.lbFechafin);
            this.gb.Controls.Add(this.dtpFechaFin);
            this.gb.Controls.Add(this.lbFechaIni);
            this.gb.Controls.Add(this.lbDescripcion);
            this.gb.Controls.Add(this.dtpFechaInicio);
            this.gb.Controls.Add(this.txtDescripcion);
            this.gb.Controls.Add(this.txtNombre);
            this.gb.Controls.Add(this.lblNombre);
            this.gb.Location = new System.Drawing.Point(24, 24);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(444, 362);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Información del asunto";
            // 
            // btnGuardarAsunto
            // 
            this.btnGuardarAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarAsunto.BackgroundImage = global::ProyectoFinal.Properties.Resources.usb;
            this.btnGuardarAsunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAsunto.Enabled = false;
            this.btnGuardarAsunto.Location = new System.Drawing.Point(375, 103);
            this.btnGuardarAsunto.Name = "btnGuardarAsunto";
            this.btnGuardarAsunto.Size = new System.Drawing.Size(56, 56);
            this.btnGuardarAsunto.TabIndex = 62;
            this.btnGuardarAsunto.Tag = "Guardar";
            this.btnGuardarAsunto.UseVisualStyleBackColor = true;
            this.btnGuardarAsunto.Click += new System.EventHandler(this.btnGuardarAsunto_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::ProyectoFinal.Properties.Resources.error;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(375, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 56);
            this.button1.TabIndex = 61;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.DataSource = this.bsClientes;
            this.cbCliente.DisplayMember = "Nombre";
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(92, 300);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(277, 21);
            this.cbCliente.TabIndex = 58;
            this.cbCliente.ValueMember = "ID_Cliente";
            // 
            // bsClientes
            // 
            this.bsClientes.DataSource = typeof(ProyectoFinal.sistema.Clientes);
            // 
            // cbAbogado
            // 
            this.cbAbogado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbogado.DataSource = this.bsAbogados;
            this.cbAbogado.DisplayMember = "Nombre";
            this.cbAbogado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbogado.FormattingEnabled = true;
            this.cbAbogado.Location = new System.Drawing.Point(92, 271);
            this.cbAbogado.Name = "cbAbogado";
            this.cbAbogado.Size = new System.Drawing.Size(277, 21);
            this.cbAbogado.TabIndex = 57;
            this.cbAbogado.ValueMember = "ID_Abogado";
            // 
            // bsAbogados
            // 
            this.bsAbogados.DataSource = typeof(ProyectoFinal.sistema.Abogados);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 308);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 56;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackgroundImage = global::ProyectoFinal.Properties.Resources.edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(375, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 56);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblAbogado
            // 
            this.lblAbogado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbogado.AutoSize = true;
            this.lblAbogado.Location = new System.Drawing.Point(6, 279);
            this.lblAbogado.Name = "lblAbogado";
            this.lblAbogado.Size = new System.Drawing.Size(53, 13);
            this.lblAbogado.TabIndex = 55;
            this.lblAbogado.Text = "Abogado:";
            // 
            // cbAutoridad
            // 
            this.cbAutoridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoridad.DataSource = this.bsAutoridad;
            this.cbAutoridad.DisplayMember = "Nombre";
            this.cbAutoridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoridad.FormattingEnabled = true;
            this.cbAutoridad.Location = new System.Drawing.Point(92, 240);
            this.cbAutoridad.Name = "cbAutoridad";
            this.cbAutoridad.Size = new System.Drawing.Size(277, 21);
            this.cbAutoridad.TabIndex = 54;
            this.cbAutoridad.ValueMember = "ID_Autoridad";
            // 
            // bsAutoridad
            // 
            this.bsAutoridad.DataSource = typeof(ProyectoFinal.sistema.Autoridad);
            // 
            // lbAutoridad
            // 
            this.lbAutoridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAutoridad.AutoSize = true;
            this.lbAutoridad.Location = new System.Drawing.Point(6, 248);
            this.lbAutoridad.Name = "lbAutoridad";
            this.lbAutoridad.Size = new System.Drawing.Size(55, 13);
            this.lbAutoridad.TabIndex = 53;
            this.lbAutoridad.Text = "Autoridad:";
            // 
            // cbProceso
            // 
            this.cbProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProceso.DataSource = this.bsProceso;
            this.cbProceso.DisplayMember = "Nombre";
            this.cbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProceso.FormattingEnabled = true;
            this.cbProceso.Location = new System.Drawing.Point(92, 211);
            this.cbProceso.Name = "cbProceso";
            this.cbProceso.Size = new System.Drawing.Size(277, 21);
            this.cbProceso.TabIndex = 52;
            this.cbProceso.ValueMember = "ID_Proceso";
            // 
            // bsProceso
            // 
            this.bsProceso.DataSource = typeof(ProyectoFinal.sistema.Proceso);
            // 
            // lbProceso
            // 
            this.lbProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProceso.AutoSize = true;
            this.lbProceso.Location = new System.Drawing.Point(6, 219);
            this.lbProceso.Name = "lbProceso";
            this.lbProceso.Size = new System.Drawing.Size(49, 13);
            this.lbProceso.TabIndex = 51;
            this.lbProceso.Text = "Proceso:";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.DataSource = this.bsEstadoAsunto;
            this.cbEstado.DisplayMember = "Nombre";
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(92, 184);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(277, 21);
            this.cbEstado.TabIndex = 50;
            this.cbEstado.ValueMember = "ID_Estado";
            // 
            // bsEstadoAsunto
            // 
            this.bsEstadoAsunto.DataSource = typeof(ProyectoFinal.sistema.EstadoAsunto);
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(6, 187);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 49;
            this.lbEstado.Text = "Estado:";
            // 
            // lbFechafin
            // 
            this.lbFechafin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFechafin.AutoSize = true;
            this.lbFechafin.Location = new System.Drawing.Point(6, 164);
            this.lbFechafin.Name = "lbFechafin";
            this.lbFechafin.Size = new System.Drawing.Size(54, 13);
            this.lbFechafin.TabIndex = 48;
            this.lbFechafin.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(92, 158);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(277, 20);
            this.dtpFechaFin.TabIndex = 47;
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(6, 132);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(67, 13);
            this.lbFechaIni.TabIndex = 46;
            this.lbFechaIni.Text = "Fecha inicio:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 70);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 45;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(92, 132);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(277, 20);
            this.dtpFechaInicio.TabIndex = 44;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(92, 70);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(277, 55);
            this.txtDescripcion.TabIndex = 43;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(92, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 20);
            this.txtNombre.TabIndex = 42;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre:";
            // 
            // bsEtapaAsunto
            // 
            this.bsEtapaAsunto.DataSource = typeof(ProyectoFinal.sistema.Etapa);
            // 
            // bsEtapaProceso
            // 
            this.bsEtapaProceso.DataSource = typeof(ProyectoFinal.sistema.EstadoProceso);
            // 
            // tcEtapasPagos
            // 
            this.tcEtapasPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcEtapasPagos.Controls.Add(this.tpEtapaAsunto);
            this.tcEtapasPagos.Controls.Add(this.tpPagos);
            this.tcEtapasPagos.Location = new System.Drawing.Point(474, 24);
            this.tcEtapasPagos.Name = "tcEtapasPagos";
            this.tcEtapasPagos.SelectedIndex = 0;
            this.tcEtapasPagos.Size = new System.Drawing.Size(463, 362);
            this.tcEtapasPagos.TabIndex = 2;
            this.tcEtapasPagos.SelectedIndexChanged += new System.EventHandler(this.tcEtapasPagos_SelectedIndexChanged);
            this.tcEtapasPagos.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcEtapasPagos_Selected);
            // 
            // tpEtapaAsunto
            // 
            this.tpEtapaAsunto.Controls.Add(this.lblEtapasProcesalesDescripcion);
            this.tpEtapaAsunto.Controls.Add(this.btnVerArchivos);
            this.tpEtapaAsunto.Controls.Add(this.btnAgregarEtapa);
            this.tpEtapaAsunto.Controls.Add(this.btnEliminarEtapa);
            this.tpEtapaAsunto.Controls.Add(this.btnEditarEtapa);
            this.tpEtapaAsunto.Controls.Add(this.lblFechaLimite);
            this.tpEtapaAsunto.Controls.Add(this.txtVencimiento);
            this.tpEtapaAsunto.Controls.Add(this.lblDiasVencimiento);
            this.tpEtapaAsunto.Controls.Add(this.txtDescripcionProceso);
            this.tpEtapaAsunto.Controls.Add(this.lblDescripcionProceso);
            this.tpEtapaAsunto.Controls.Add(this.txtDescripcionEtapa);
            this.tpEtapaAsunto.Controls.Add(this.dtpFechaInicioEtapaProcesal);
            this.tpEtapaAsunto.Controls.Add(this.lblDescripcionAsunto);
            this.tpEtapaAsunto.Controls.Add(this.lblFechaIni);
            this.tpEtapaAsunto.Controls.Add(this.lblEtapasProcesales);
            this.tpEtapaAsunto.Controls.Add(this.cbEtapasProcesoAsunto);
            this.tpEtapaAsunto.Location = new System.Drawing.Point(4, 22);
            this.tpEtapaAsunto.Name = "tpEtapaAsunto";
            this.tpEtapaAsunto.Padding = new System.Windows.Forms.Padding(3);
            this.tpEtapaAsunto.Size = new System.Drawing.Size(455, 336);
            this.tpEtapaAsunto.TabIndex = 0;
            this.tpEtapaAsunto.Text = "Etapas procesales";
            this.tpEtapaAsunto.UseVisualStyleBackColor = true;
            // 
            // lblEtapasProcesalesDescripcion
            // 
            this.lblEtapasProcesalesDescripcion.AutoSize = true;
            this.lblEtapasProcesalesDescripcion.Location = new System.Drawing.Point(20, 25);
            this.lblEtapasProcesalesDescripcion.Name = "lblEtapasProcesalesDescripcion";
            this.lblEtapasProcesalesDescripcion.Size = new System.Drawing.Size(270, 13);
            this.lblEtapasProcesalesDescripcion.TabIndex = 79;
            this.lblEtapasProcesalesDescripcion.Text = "Etapas del proceso legal en que se encuentra el asunto";
            // 
            // btnVerArchivos
            // 
            this.btnVerArchivos.Enabled = false;
            this.btnVerArchivos.Location = new System.Drawing.Point(117, 289);
            this.btnVerArchivos.Name = "btnVerArchivos";
            this.btnVerArchivos.Size = new System.Drawing.Size(248, 31);
            this.btnVerArchivos.TabIndex = 78;
            this.btnVerArchivos.Text = "Ver archivos de la etapa";
            this.btnVerArchivos.UseVisualStyleBackColor = true;
            this.btnVerArchivos.Click += new System.EventHandler(this.btnVerArchivos_Click_1);
            // 
            // btnAgregarEtapa
            // 
            this.btnAgregarEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEtapa.BackgroundImage = global::ProyectoFinal.Properties.Resources.agregar;
            this.btnAgregarEtapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEtapa.Location = new System.Drawing.Point(379, 56);
            this.btnAgregarEtapa.Name = "btnAgregarEtapa";
            this.btnAgregarEtapa.Size = new System.Drawing.Size(56, 56);
            this.btnAgregarEtapa.TabIndex = 77;
            this.btnAgregarEtapa.Tag = "Editar";
            this.btnAgregarEtapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarEtapa.UseVisualStyleBackColor = true;
            this.btnAgregarEtapa.Click += new System.EventHandler(this.btnAgregarEtapa_Click);
            // 
            // btnEliminarEtapa
            // 
            this.btnEliminarEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEtapa.BackgroundImage = global::ProyectoFinal.Properties.Resources.error;
            this.btnEliminarEtapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarEtapa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarEtapa.Location = new System.Drawing.Point(380, 179);
            this.btnEliminarEtapa.Name = "btnEliminarEtapa";
            this.btnEliminarEtapa.Size = new System.Drawing.Size(56, 56);
            this.btnEliminarEtapa.TabIndex = 76;
            this.btnEliminarEtapa.UseVisualStyleBackColor = true;
            this.btnEliminarEtapa.Click += new System.EventHandler(this.btnEliminarEtapa_Click);
            // 
            // btnEditarEtapa
            // 
            this.btnEditarEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEtapa.BackgroundImage = global::ProyectoFinal.Properties.Resources.edit;
            this.btnEditarEtapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarEtapa.Location = new System.Drawing.Point(380, 117);
            this.btnEditarEtapa.Name = "btnEditarEtapa";
            this.btnEditarEtapa.Size = new System.Drawing.Size(56, 56);
            this.btnEditarEtapa.TabIndex = 74;
            this.btnEditarEtapa.Tag = "Editar";
            this.btnEditarEtapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarEtapa.UseVisualStyleBackColor = true;
            this.btnEditarEtapa.Click += new System.EventHandler(this.btnEditarEtapa_Click);
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Location = new System.Drawing.Point(19, 261);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(115, 13);
            this.lblFechaLimite.TabIndex = 73;
            this.lblFechaLimite.Text = "Fecha de vencimiento:";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapaProceso, "Dias_Vencimiento", true));
            this.txtVencimiento.Enabled = false;
            this.txtVencimiento.Location = new System.Drawing.Point(117, 220);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(248, 20);
            this.txtVencimiento.TabIndex = 72;
            // 
            // lblDiasVencimiento
            // 
            this.lblDiasVencimiento.AutoSize = true;
            this.lblDiasVencimiento.Location = new System.Drawing.Point(19, 223);
            this.lblDiasVencimiento.Name = "lblDiasVencimiento";
            this.lblDiasVencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblDiasVencimiento.TabIndex = 71;
            this.lblDiasVencimiento.Text = "Vencimiento (Dias):";
            // 
            // txtDescripcionProceso
            // 
            this.txtDescripcionProceso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapaProceso, "Nombre", true));
            this.txtDescripcionProceso.Enabled = false;
            this.txtDescripcionProceso.Location = new System.Drawing.Point(117, 169);
            this.txtDescripcionProceso.Multiline = true;
            this.txtDescripcionProceso.Name = "txtDescripcionProceso";
            this.txtDescripcionProceso.Size = new System.Drawing.Size(248, 41);
            this.txtDescripcionProceso.TabIndex = 70;
            // 
            // lblDescripcionProceso
            // 
            this.lblDescripcionProceso.AutoSize = true;
            this.lblDescripcionProceso.Location = new System.Drawing.Point(20, 172);
            this.lblDescripcionProceso.Name = "lblDescripcionProceso";
            this.lblDescripcionProceso.Size = new System.Drawing.Size(49, 13);
            this.lblDescripcionProceso.TabIndex = 69;
            this.lblDescripcionProceso.Text = "Proceso:";
            // 
            // txtDescripcionEtapa
            // 
            this.txtDescripcionEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapaAsunto, "Descripcion", true));
            this.txtDescripcionEtapa.Enabled = false;
            this.txtDescripcionEtapa.Location = new System.Drawing.Point(117, 117);
            this.txtDescripcionEtapa.Multiline = true;
            this.txtDescripcionEtapa.Name = "txtDescripcionEtapa";
            this.txtDescripcionEtapa.Size = new System.Drawing.Size(248, 41);
            this.txtDescripcionEtapa.TabIndex = 68;
            // 
            // dtpFechaInicioEtapaProcesal
            // 
            this.dtpFechaInicioEtapaProcesal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsEtapaAsunto, "Fecha_Inicio", true));
            this.dtpFechaInicioEtapaProcesal.Enabled = false;
            this.dtpFechaInicioEtapaProcesal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioEtapaProcesal.Location = new System.Drawing.Point(117, 89);
            this.dtpFechaInicioEtapaProcesal.Name = "dtpFechaInicioEtapaProcesal";
            this.dtpFechaInicioEtapaProcesal.Size = new System.Drawing.Size(248, 20);
            this.dtpFechaInicioEtapaProcesal.TabIndex = 67;
            // 
            // lblDescripcionAsunto
            // 
            this.lblDescripcionAsunto.AutoSize = true;
            this.lblDescripcionAsunto.Location = new System.Drawing.Point(20, 126);
            this.lblDescripcionAsunto.Name = "lblDescripcionAsunto";
            this.lblDescripcionAsunto.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionAsunto.TabIndex = 66;
            this.lblDescripcionAsunto.Text = "Descripcion:";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(20, 89);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(82, 13);
            this.lblFechaIni.TabIndex = 65;
            this.lblFechaIni.Text = "Fecha de inicio:";
            // 
            // lblEtapasProcesales
            // 
            this.lblEtapasProcesales.AutoSize = true;
            this.lblEtapasProcesales.Location = new System.Drawing.Point(20, 59);
            this.lblEtapasProcesales.Name = "lblEtapasProcesales";
            this.lblEtapasProcesales.Size = new System.Drawing.Size(43, 13);
            this.lblEtapasProcesales.TabIndex = 64;
            this.lblEtapasProcesales.Text = "Etapas:";
            // 
            // cbEtapasProcesoAsunto
            // 
            this.cbEtapasProcesoAsunto.DataSource = this.bsEtapaAsuntoCombo;
            this.cbEtapasProcesoAsunto.DisplayMember = "ID_EstadoProceso";
            this.cbEtapasProcesoAsunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtapasProcesoAsunto.FormattingEnabled = true;
            this.cbEtapasProcesoAsunto.Location = new System.Drawing.Point(117, 56);
            this.cbEtapasProcesoAsunto.Name = "cbEtapasProcesoAsunto";
            this.cbEtapasProcesoAsunto.Size = new System.Drawing.Size(248, 21);
            this.cbEtapasProcesoAsunto.TabIndex = 63;
            this.cbEtapasProcesoAsunto.ValueMember = "ID_EstadoProceso";
            this.cbEtapasProcesoAsunto.SelectedIndexChanged += new System.EventHandler(this.cbEtapasProcesoAsunto_SelectedIndexChanged_1);
            // 
            // bsEtapaAsuntoCombo
            // 
            this.bsEtapaAsuntoCombo.DataSource = typeof(ProyectoFinal.sistema.Etapa);
            // 
            // tpPagos
            // 
            this.tpPagos.Controls.Add(this.gbPagos);
            this.tpPagos.Controls.Add(this.gbConvenio);
            this.tpPagos.Location = new System.Drawing.Point(4, 22);
            this.tpPagos.Name = "tpPagos";
            this.tpPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPagos.Size = new System.Drawing.Size(455, 336);
            this.tpPagos.TabIndex = 1;
            this.tpPagos.Text = "Convenio / Pagos";
            this.tpPagos.UseVisualStyleBackColor = true;
            this.tpPagos.Click += new System.EventHandler(this.tpPagos_Click);
            // 
            // gbPagos
            // 
            this.gbPagos.Controls.Add(this.lblCantidadRestante);
            this.gbPagos.Controls.Add(this.lblResta);
            this.gbPagos.Controls.Add(this.btnEliminarPago);
            this.gbPagos.Controls.Add(this.btnAgregarPago);
            this.gbPagos.Controls.Add(this.dgPagos);
            this.gbPagos.Location = new System.Drawing.Point(21, 174);
            this.gbPagos.Name = "gbPagos";
            this.gbPagos.Size = new System.Drawing.Size(412, 144);
            this.gbPagos.TabIndex = 7;
            this.gbPagos.TabStop = false;
            this.gbPagos.Text = "Pagos";
            // 
            // lblCantidadRestante
            // 
            this.lblCantidadRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadRestante.AutoSize = true;
            this.lblCantidadRestante.Location = new System.Drawing.Point(279, 104);
            this.lblCantidadRestante.Name = "lblCantidadRestante";
            this.lblCantidadRestante.Size = new System.Drawing.Size(10, 13);
            this.lblCantidadRestante.TabIndex = 80;
            this.lblCantidadRestante.Text = " ";
            // 
            // lblResta
            // 
            this.lblResta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(279, 82);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(38, 13);
            this.lblResta.TabIndex = 79;
            this.lblResta.Text = "Resta:";
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPago.BackgroundImage = global::ProyectoFinal.Properties.Resources.error;
            this.btnEliminarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPago.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarPago.Location = new System.Drawing.Point(341, 19);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(56, 56);
            this.btnEliminarPago.TabIndex = 63;
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPago.BackgroundImage = global::ProyectoFinal.Properties.Resources.agregar;
            this.btnAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPago.Location = new System.Drawing.Point(279, 19);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(56, 56);
            this.btnAgregarPago.TabIndex = 78;
            this.btnAgregarPago.Tag = "Editar";
            this.btnAgregarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.AllowUserToDeleteRows = false;
            this.dgPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPagos.AutoGenerateColumns = false;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgPagos.DataSource = this.bsPago;
            this.dgPagos.Location = new System.Drawing.Point(12, 19);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.ReadOnly = true;
            this.dgPagos.Size = new System.Drawing.Size(243, 115);
            this.dgPagos.TabIndex = 0;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPago
            // 
            this.bsPago.DataSource = typeof(ProyectoFinal.sistema.Pago);
            // 
            // gbConvenio
            // 
            this.gbConvenio.Controls.Add(this.txtCantidad);
            this.gbConvenio.Controls.Add(this.cbTipoMoneda);
            this.gbConvenio.Controls.Add(this.lblCantidad);
            this.gbConvenio.Controls.Add(this.txtDescripcionConvenio);
            this.gbConvenio.Controls.Add(this.lblDescripcion);
            this.gbConvenio.Location = new System.Drawing.Point(21, 21);
            this.gbConvenio.Name = "gbConvenio";
            this.gbConvenio.Size = new System.Drawing.Size(412, 147);
            this.gbConvenio.TabIndex = 6;
            this.gbConvenio.TabStop = false;
            this.gbConvenio.Text = "Convenio del asunto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(95, 33);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // cbTipoMoneda
            // 
            this.cbTipoMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoMoneda.DataSource = this.bsTipoMoneda;
            this.cbTipoMoneda.DisplayMember = "Nombre";
            this.cbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMoneda.FormattingEnabled = true;
            this.cbTipoMoneda.Location = new System.Drawing.Point(230, 33);
            this.cbTipoMoneda.Name = "cbTipoMoneda";
            this.cbTipoMoneda.Size = new System.Drawing.Size(105, 21);
            this.cbTipoMoneda.TabIndex = 5;
            this.cbTipoMoneda.ValueMember = "ID_Tipo_Moneda";
            // 
            // bsTipoMoneda
            // 
            this.bsTipoMoneda.DataSource = typeof(ProyectoFinal.sistema.TipoMoneda);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 36);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtDescripcionConvenio
            // 
            this.txtDescripcionConvenio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionConvenio.Location = new System.Drawing.Point(95, 67);
            this.txtDescripcionConvenio.Multiline = true;
            this.txtDescripcionConvenio.Name = "txtDescripcionConvenio";
            this.txtDescripcionConvenio.Size = new System.Drawing.Size(240, 60);
            this.txtDescripcionConvenio.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // frmAsunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 422);
            this.Controls.Add(this.tcEtapasPagos);
            this.Controls.Add(this.gb);
            this.Name = "frmAsunto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asunto: ";
            this.Load += new System.EventHandler(this.frmAsunto_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbogados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutoridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaProceso)).EndInit();
            this.tcEtapasPagos.ResumeLayout(false);
            this.tpEtapaAsunto.ResumeLayout(false);
            this.tpEtapaAsunto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapaAsuntoCombo)).EndInit();
            this.tpPagos.ResumeLayout(false);
            this.gbPagos.ResumeLayout(false);
            this.gbPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPago)).EndInit();
            this.gbConvenio.ResumeLayout(false);
            this.gbConvenio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbAbogado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblAbogado;
        private System.Windows.Forms.ComboBox cbAutoridad;
        private System.Windows.Forms.Label lbAutoridad;
        private System.Windows.Forms.ComboBox cbProceso;
        private System.Windows.Forms.Label lbProceso;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbFechafin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.BindingSource bsEtapaProceso;
        private System.Windows.Forms.BindingSource bsEtapaAsunto;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnGuardarAsunto;
        private System.Windows.Forms.BindingSource bsEstadoAsunto;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsAbogados;
        private System.Windows.Forms.BindingSource bsAutoridad;
        private System.Windows.Forms.BindingSource bsProceso;
        private System.Windows.Forms.TabControl tcEtapasPagos;
        private System.Windows.Forms.TabPage tpEtapaAsunto;
        private System.Windows.Forms.TabPage tpPagos;
        private System.Windows.Forms.Button btnVerArchivos;
        public System.Windows.Forms.Button btnAgregarEtapa;
        public System.Windows.Forms.Button btnEliminarEtapa;
        public System.Windows.Forms.Button btnEditarEtapa;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.Label lblDiasVencimiento;
        private System.Windows.Forms.TextBox txtDescripcionProceso;
        private System.Windows.Forms.Label lblDescripcionProceso;
        private System.Windows.Forms.TextBox txtDescripcionEtapa;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioEtapaProcesal;
        private System.Windows.Forms.Label lblDescripcionAsunto;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblEtapasProcesales;
        private System.Windows.Forms.ComboBox cbEtapasProcesoAsunto;
        private System.Windows.Forms.Label lblEtapasProcesalesDescripcion;
        private System.Windows.Forms.GroupBox gbPagos;
        private System.Windows.Forms.Label lblCantidadRestante;
        private System.Windows.Forms.Label lblResta;
        public System.Windows.Forms.Button btnEliminarPago;
        public System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbConvenio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbTipoMoneda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtDescripcionConvenio;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.BindingSource bsPago;
        private System.Windows.Forms.BindingSource bsEtapaAsuntoCombo;
        private System.Windows.Forms.BindingSource bsTipoMoneda;
    }
}