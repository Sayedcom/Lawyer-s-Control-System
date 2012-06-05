namespace ProyectoFinal
{
    partial class frmEditarEtapa
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
            this.lblEdoProceso = new System.Windows.Forms.Label();
            this.cbEstadoProceso = new System.Windows.Forms.ComboBox();
            this.bsEstadoProceso = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bsEtapa = new System.Windows.Forms.BindingSource(this.components);
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtID_Asunto = new System.Windows.Forms.TextBox();
            this.lblID_Asunto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdoProceso
            // 
            this.lblEdoProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdoProceso.AutoSize = true;
            this.lblEdoProceso.Location = new System.Drawing.Point(14, 233);
            this.lblEdoProceso.Name = "lblEdoProceso";
            this.lblEdoProceso.Size = new System.Drawing.Size(81, 13);
            this.lblEdoProceso.TabIndex = 25;
            this.lblEdoProceso.Text = "Etapa procesal:";
            // 
            // cbEstadoProceso
            // 
            this.cbEstadoProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoProceso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEstadoProceso, "Nombre", true));
            this.cbEstadoProceso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsEstadoProceso, "ID_EstadoProceso", true));
            this.cbEstadoProceso.DataSource = this.bsEstadoProceso;
            this.cbEstadoProceso.DisplayMember = "Nombre";
            this.cbEstadoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoProceso.FormattingEnabled = true;
            this.cbEstadoProceso.Location = new System.Drawing.Point(103, 230);
            this.cbEstadoProceso.Name = "cbEstadoProceso";
            this.cbEstadoProceso.Size = new System.Drawing.Size(180, 21);
            this.cbEstadoProceso.TabIndex = 24;
            this.cbEstadoProceso.ValueMember = "ID_EstadoProceso";
            // 
            // bsEstadoProceso
            // 
            this.bsEstadoProceso.DataSource = typeof(ProyectoFinal.sistema.EstadoProceso);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapa, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(103, 170);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 52);
            this.txtDescripcion.TabIndex = 23;
            // 
            // bsEtapa
            // 
            this.bsEtapa.DataSource = typeof(ProyectoFinal.sistema.Etapa);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 145);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(82, 13);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha de inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapa, "Fecha_Inicio", true));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(103, 138);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaInicio.TabIndex = 20;
            // 
            // txtID_Asunto
            // 
            this.txtID_Asunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID_Asunto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEtapa, "ID_Asunto", true));
            this.txtID_Asunto.Location = new System.Drawing.Point(103, 109);
            this.txtID_Asunto.Name = "txtID_Asunto";
            this.txtID_Asunto.ReadOnly = true;
            this.txtID_Asunto.Size = new System.Drawing.Size(180, 20);
            this.txtID_Asunto.TabIndex = 19;
            // 
            // lblID_Asunto
            // 
            this.lblID_Asunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID_Asunto.AutoSize = true;
            this.lblID_Asunto.Location = new System.Drawing.Point(15, 116);
            this.lblID_Asunto.Name = "lblID_Asunto";
            this.lblID_Asunto.Size = new System.Drawing.Size(60, 13);
            this.lblID_Asunto.TabIndex = 18;
            this.lblID_Asunto.Text = "ID Asunto: ";
            // 
            // frmEditarEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 282);
            this.Controls.Add(this.lblEdoProceso);
            this.Controls.Add(this.cbEstadoProceso);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtID_Asunto);
            this.Controls.Add(this.lblID_Asunto);
            this.Name = "frmEditarEtapa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Etapa";
            this.Load += new System.EventHandler(this.frmEditarEtapa_Load);
            this.Controls.SetChildIndex(this.lblID_Asunto, 0);
            this.Controls.SetChildIndex(this.txtID_Asunto, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cbEstadoProceso, 0);
            this.Controls.SetChildIndex(this.lblEdoProceso, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdoProceso;
        public System.Windows.Forms.ComboBox cbEstadoProceso;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.TextBox txtID_Asunto;
        private System.Windows.Forms.Label lblID_Asunto;
        private System.Windows.Forms.BindingSource bsEstadoProceso;
        private System.Windows.Forms.BindingSource bsEtapa;
    }
}