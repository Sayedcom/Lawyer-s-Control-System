namespace ProyectoFinal
{
    partial class frmNuevoCliente
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
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.gbAbogado = new System.Windows.Forms.GroupBox();
            this.lblSugerencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreAbogado = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNextel = new System.Windows.Forms.Label();
            this.lblEmailAbogado = new System.Windows.Forms.Label();
            this.txtNextel = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gbAbogado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(12, 57);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(307, 13);
            this.lblInstrucciones.TabIndex = 21;
            this.lblInstrucciones.Text = "Por favor, complete los siguientes datos del cliente a dar de alta";
            // 
            // gbAbogado
            // 
            this.gbAbogado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAbogado.Controls.Add(this.lblSugerencia);
            this.gbAbogado.Controls.Add(this.txtNombre);
            this.gbAbogado.Controls.Add(this.lblNombreAbogado);
            this.gbAbogado.Controls.Add(this.txtEmail);
            this.gbAbogado.Controls.Add(this.lblNextel);
            this.gbAbogado.Controls.Add(this.lblEmailAbogado);
            this.gbAbogado.Controls.Add(this.txtNextel);
            this.gbAbogado.Controls.Add(this.lblCelular);
            this.gbAbogado.Controls.Add(this.txtCelular);
            this.gbAbogado.Controls.Add(this.label2);
            this.gbAbogado.Controls.Add(this.lblTelefono);
            this.gbAbogado.Controls.Add(this.dtpFechaN);
            this.gbAbogado.Controls.Add(this.txtTelefono);
            this.gbAbogado.Controls.Add(this.txtDireccion);
            this.gbAbogado.Controls.Add(this.lblDireccion);
            this.gbAbogado.Location = new System.Drawing.Point(15, 88);
            this.gbAbogado.Name = "gbAbogado";
            this.gbAbogado.Size = new System.Drawing.Size(388, 271);
            this.gbAbogado.TabIndex = 22;
            this.gbAbogado.TabStop = false;
            this.gbAbogado.Text = "Datos Personales del Cliente";
            this.gbAbogado.Enter += new System.EventHandler(this.gbAbogado_Enter);
            // 
            // lblSugerencia
            // 
            this.lblSugerencia.AutoSize = true;
            this.lblSugerencia.Location = new System.Drawing.Point(21, 32);
            this.lblSugerencia.Name = "lblSugerencia";
            this.lblSugerencia.Size = new System.Drawing.Size(0, 13);
            this.lblSugerencia.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(137, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombreAbogado
            // 
            this.lblNombreAbogado.AutoSize = true;
            this.lblNombreAbogado.Location = new System.Drawing.Point(21, 66);
            this.lblNombreAbogado.Name = "lblNombreAbogado";
            this.lblNombreAbogado.Size = new System.Drawing.Size(91, 13);
            this.lblNombreAbogado.TabIndex = 1;
            this.lblNombreAbogado.Text = "Nombre Completo";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(138, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblNextel
            // 
            this.lblNextel.AutoSize = true;
            this.lblNextel.Location = new System.Drawing.Point(21, 227);
            this.lblNextel.Name = "lblNextel";
            this.lblNextel.Size = new System.Drawing.Size(37, 13);
            this.lblNextel.TabIndex = 19;
            this.lblNextel.Text = "Nextel";
            // 
            // lblEmailAbogado
            // 
            this.lblEmailAbogado.AutoSize = true;
            this.lblEmailAbogado.Location = new System.Drawing.Point(21, 92);
            this.lblEmailAbogado.Name = "lblEmailAbogado";
            this.lblEmailAbogado.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAbogado.TabIndex = 4;
            this.lblEmailAbogado.Text = "Email";
            // 
            // txtNextel
            // 
            this.txtNextel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextel.Location = new System.Drawing.Point(136, 227);
            this.txtNextel.Name = "txtNextel";
            this.txtNextel.Size = new System.Drawing.Size(207, 20);
            this.txtNextel.TabIndex = 18;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(21, 198);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 17;
            this.lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.Location = new System.Drawing.Point(136, 198);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(207, 20);
            this.txtCelular.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 172);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 13);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Teléfono (Fijo)";
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(138, 119);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaN.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(137, 172);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(137, 145);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(206, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 145);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección";
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 386);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.gbAbogado);
            this.Name = "frmNuevoCliente";
            this.ShowIcon = false;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frmNuevoCliente_Load);
            this.Controls.SetChildIndex(this.gbAbogado, 0);
            this.Controls.SetChildIndex(this.lblInstrucciones, 0);
            this.gbAbogado.ResumeLayout(false);
            this.gbAbogado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.GroupBox gbAbogado;
        private System.Windows.Forms.Label lblSugerencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreAbogado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNextel;
        private System.Windows.Forms.Label lblEmailAbogado;
        private System.Windows.Forms.TextBox txtNextel;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;

    }
}