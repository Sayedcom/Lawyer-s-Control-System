namespace ProyectoFinal
{
    partial class frmNuevaEtapa
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
            this.txtDescripcionForma = new System.Windows.Forms.Label();
            this.lblID_Asunto = new System.Windows.Forms.Label();
            this.txtID_Asunto = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbEstadoProceso = new System.Windows.Forms.ComboBox();
            this.bsEstadoProceso = new System.Windows.Forms.BindingSource(this.components);
            this.lblEdoProceso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionForma
            // 
            this.txtDescripcionForma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionForma.AutoSize = true;
            this.txtDescripcionForma.Location = new System.Drawing.Point(24, 95);
            this.txtDescripcionForma.Name = "txtDescripcionForma";
            this.txtDescripcionForma.Size = new System.Drawing.Size(160, 13);
            this.txtDescripcionForma.TabIndex = 1;
            this.txtDescripcionForma.Text = "Crear nueva etapa para asunto: ";
            // 
            // lblID_Asunto
            // 
            this.lblID_Asunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID_Asunto.AutoSize = true;
            this.lblID_Asunto.Location = new System.Drawing.Point(27, 129);
            this.lblID_Asunto.Name = "lblID_Asunto";
            this.lblID_Asunto.Size = new System.Drawing.Size(60, 13);
            this.lblID_Asunto.TabIndex = 2;
            this.lblID_Asunto.Text = "ID Asunto: ";
            // 
            // txtID_Asunto
            // 
            this.txtID_Asunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID_Asunto.Location = new System.Drawing.Point(115, 122);
            this.txtID_Asunto.Name = "txtID_Asunto";
            this.txtID_Asunto.ReadOnly = true;
            this.txtID_Asunto.Size = new System.Drawing.Size(207, 20);
            this.txtID_Asunto.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(115, 151);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(207, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(82, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha de inicio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 187);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(115, 183);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 52);
            this.txtDescripcion.TabIndex = 15;
            // 
            // cbEstadoProceso
            // 
            this.cbEstadoProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoProceso.DataSource = this.bsEstadoProceso;
            this.cbEstadoProceso.DisplayMember = "Nombre";
            this.cbEstadoProceso.FormattingEnabled = true;
            this.cbEstadoProceso.Location = new System.Drawing.Point(115, 243);
            this.cbEstadoProceso.Name = "cbEstadoProceso";
            this.cbEstadoProceso.Size = new System.Drawing.Size(207, 21);
            this.cbEstadoProceso.TabIndex = 16;
            this.cbEstadoProceso.ValueMember = "ID_EstadoProceso";
            // 
            // bsEstadoProceso
            // 
            this.bsEstadoProceso.DataSource = typeof(ProyectoFinal.sistema.EstadoProceso);
            // 
            // lblEdoProceso
            // 
            this.lblEdoProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdoProceso.AutoSize = true;
            this.lblEdoProceso.Location = new System.Drawing.Point(26, 246);
            this.lblEdoProceso.Name = "lblEdoProceso";
            this.lblEdoProceso.Size = new System.Drawing.Size(81, 13);
            this.lblEdoProceso.TabIndex = 17;
            this.lblEdoProceso.Text = "Etapa procesal:";
            // 
            // frmNuevaEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 298);
            this.Controls.Add(this.lblEdoProceso);
            this.Controls.Add(this.cbEstadoProceso);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtID_Asunto);
            this.Controls.Add(this.lblID_Asunto);
            this.Controls.Add(this.txtDescripcionForma);
            this.Name = "frmNuevaEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva etapa ";
            this.Load += new System.EventHandler(this.frmNuevaEtapa_Load);
            this.Controls.SetChildIndex(this.txtDescripcionForma, 0);
            this.Controls.SetChildIndex(this.lblID_Asunto, 0);
            this.Controls.SetChildIndex(this.txtID_Asunto, 0);
            this.Controls.SetChildIndex(this.dtpFechaInicio, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cbEstadoProceso, 0);
            this.Controls.SetChildIndex(this.lblEdoProceso, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDescripcionForma;
        private System.Windows.Forms.Label lblID_Asunto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEdoProceso;
        private System.Windows.Forms.BindingSource bsEstadoProceso;
        public System.Windows.Forms.TextBox txtID_Asunto;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.ComboBox cbEstadoProceso;
    }
}