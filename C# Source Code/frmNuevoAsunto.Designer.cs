namespace ProyectoFinal
{
    partial class frmNuevoAsunto
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
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.lbFechafin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.estadoAsuntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbProceso = new System.Windows.Forms.Label();
            this.cbProceso = new System.Windows.Forms.ComboBox();
            this.procesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbAutoridad = new System.Windows.Forms.Label();
            this.cbAutoridad = new System.Windows.Forms.ComboBox();
            this.autoridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAbogado = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAbogado = new System.Windows.Forms.ComboBox();
            this.abogadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.estadoAsuntoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abogadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(24, 79);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(222, 13);
            this.lblAsunto.TabIndex = 1;
            this.lblAsunto.Text = "Llene los datos del asunto que desea agregar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(108, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(108, 133);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(271, 55);
            this.txtDescripcion.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(108, 195);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(271, 20);
            this.dtpFechaInicio.TabIndex = 11;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(24, 133);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 12;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(27, 195);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(67, 13);
            this.lbFechaIni.TabIndex = 13;
            this.lbFechaIni.Text = "Fecha inicio:";
            // 
            // lbFechafin
            // 
            this.lbFechafin.AutoSize = true;
            this.lbFechafin.Location = new System.Drawing.Point(27, 221);
            this.lbFechafin.Name = "lbFechafin";
            this.lbFechafin.Size = new System.Drawing.Size(54, 13);
            this.lbFechafin.TabIndex = 15;
            this.lbFechafin.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(108, 221);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(271, 20);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(28, 251);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 16;
            this.lbEstado.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.DataSource = this.estadoAsuntoBindingSource;
            this.cbEstado.DisplayMember = "Nombre";
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(108, 247);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(271, 21);
            this.cbEstado.TabIndex = 17;
            this.cbEstado.ValueMember = "ID_Estado";
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // estadoAsuntoBindingSource
            // 
            this.estadoAsuntoBindingSource.DataSource = typeof(ProyectoFinal.sistema.EstadoAsunto);
            // 
            // lbProceso
            // 
            this.lbProceso.AutoSize = true;
            this.lbProceso.Location = new System.Drawing.Point(29, 280);
            this.lbProceso.Name = "lbProceso";
            this.lbProceso.Size = new System.Drawing.Size(49, 13);
            this.lbProceso.TabIndex = 18;
            this.lbProceso.Text = "Proceso:";
            // 
            // cbProceso
            // 
            this.cbProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProceso.DataSource = this.procesoBindingSource;
            this.cbProceso.DisplayMember = "Nombre";
            this.cbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProceso.FormattingEnabled = true;
            this.cbProceso.Location = new System.Drawing.Point(108, 274);
            this.cbProceso.Name = "cbProceso";
            this.cbProceso.Size = new System.Drawing.Size(271, 21);
            this.cbProceso.TabIndex = 19;
            this.cbProceso.ValueMember = "ID_Proceso";
            // 
            // procesoBindingSource
            // 
            this.procesoBindingSource.DataSource = typeof(ProyectoFinal.sistema.Proceso);
            // 
            // lbAutoridad
            // 
            this.lbAutoridad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAutoridad.AutoSize = true;
            this.lbAutoridad.Location = new System.Drawing.Point(29, 310);
            this.lbAutoridad.Name = "lbAutoridad";
            this.lbAutoridad.Size = new System.Drawing.Size(55, 13);
            this.lbAutoridad.TabIndex = 20;
            this.lbAutoridad.Text = "Autoridad:";
            // 
            // cbAutoridad
            // 
            this.cbAutoridad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoridad.DataSource = this.autoridadBindingSource;
            this.cbAutoridad.DisplayMember = "Nombre";
            this.cbAutoridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoridad.FormattingEnabled = true;
            this.cbAutoridad.Location = new System.Drawing.Point(108, 303);
            this.cbAutoridad.Name = "cbAutoridad";
            this.cbAutoridad.Size = new System.Drawing.Size(271, 21);
            this.cbAutoridad.TabIndex = 21;
            this.cbAutoridad.ValueMember = "ID_Autoridad";
            // 
            // autoridadBindingSource
            // 
            this.autoridadBindingSource.DataSource = typeof(ProyectoFinal.sistema.Autoridad);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 369);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 23;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblAbogado
            // 
            this.lblAbogado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbogado.AutoSize = true;
            this.lblAbogado.Location = new System.Drawing.Point(29, 342);
            this.lblAbogado.Name = "lblAbogado";
            this.lblAbogado.Size = new System.Drawing.Size(53, 13);
            this.lblAbogado.TabIndex = 22;
            this.lblAbogado.Text = "Abogado:";
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.DataSource = this.clientesBindingSource;
            this.cbCliente.DisplayMember = "Nombre";
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(108, 363);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(271, 21);
            this.cbCliente.TabIndex = 25;
            this.cbCliente.ValueMember = "ID_Cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(ProyectoFinal.sistema.Clientes);
            // 
            // cbAbogado
            // 
            this.cbAbogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbogado.DataSource = this.abogadosBindingSource;
            this.cbAbogado.DisplayMember = "Nombre";
            this.cbAbogado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbogado.FormattingEnabled = true;
            this.cbAbogado.Location = new System.Drawing.Point(108, 334);
            this.cbAbogado.Name = "cbAbogado";
            this.cbAbogado.Size = new System.Drawing.Size(271, 21);
            this.cbAbogado.TabIndex = 24;
            this.cbAbogado.ValueMember = "ID_Abogado";
            // 
            // abogadosBindingSource
            // 
            this.abogadosBindingSource.DataSource = typeof(ProyectoFinal.sistema.Abogados);
            this.abogadosBindingSource.CurrentChanged += new System.EventHandler(this.abogadosBindingSource_CurrentChanged);
            // 
            // frmNuevoAsunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 411);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbAbogado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblAbogado);
            this.Controls.Add(this.cbAutoridad);
            this.Controls.Add(this.lbAutoridad);
            this.Controls.Add(this.cbProceso);
            this.Controls.Add(this.lbProceso);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbFechafin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lbFechaIni);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAsunto);
            this.Name = "frmNuevoAsunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Asunto";
            this.Load += new System.EventHandler(this.frmNuevoAsunto_Load);
            this.Controls.SetChildIndex(this.lblAsunto, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.lbDescripcion, 0);
            this.Controls.SetChildIndex(this.lbFechaIni, 0);
            this.Controls.SetChildIndex(this.dtpFechaFin, 0);
            this.Controls.SetChildIndex(this.lbFechafin, 0);
            this.Controls.SetChildIndex(this.lbEstado, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.lbProceso, 0);
            this.Controls.SetChildIndex(this.cbProceso, 0);
            this.Controls.SetChildIndex(this.lbAutoridad, 0);
            this.Controls.SetChildIndex(this.cbAutoridad, 0);
            this.Controls.SetChildIndex(this.lblAbogado, 0);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.cbAbogado, 0);
            this.Controls.SetChildIndex(this.cbCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.estadoAsuntoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abogadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.Label lbFechafin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbProceso;
        private System.Windows.Forms.ComboBox cbProceso;
        private System.Windows.Forms.Label lbAutoridad;
        private System.Windows.Forms.ComboBox cbAutoridad;
        private System.Windows.Forms.BindingSource estadoAsuntoBindingSource;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblAbogado;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbAbogado;
        private System.Windows.Forms.BindingSource procesoBindingSource;
        private System.Windows.Forms.BindingSource autoridadBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource abogadosBindingSource;
    }
}