namespace ProyectoFinal
{
    partial class frmTipoMoneda
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
            this.gbNuevaFecha = new System.Windows.Forms.GroupBox();
            this.lblNombreNuevoTipoMoneda = new System.Windows.Forms.Label();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.btnAgregarTipoMoneda = new System.Windows.Forms.Button();
            this.gbTipoMoneda = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbTipoMoneda = new System.Windows.Forms.ListBox();
            this.bsTipoMoneda = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbNuevaFecha.SuspendLayout();
            this.gbTipoMoneda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevaFecha
            // 
            this.gbNuevaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNuevaFecha.Controls.Add(this.lblNombreNuevoTipoMoneda);
            this.gbNuevaFecha.Controls.Add(this.txtTipoMoneda);
            this.gbNuevaFecha.Controls.Add(this.btnAgregarTipoMoneda);
            this.gbNuevaFecha.Location = new System.Drawing.Point(25, 247);
            this.gbNuevaFecha.Name = "gbNuevaFecha";
            this.gbNuevaFecha.Size = new System.Drawing.Size(308, 117);
            this.gbNuevaFecha.TabIndex = 9;
            this.gbNuevaFecha.TabStop = false;
            this.gbNuevaFecha.Text = "Agregar tipo de moneda";
            // 
            // lblNombreNuevoTipoMoneda
            // 
            this.lblNombreNuevoTipoMoneda.AutoSize = true;
            this.lblNombreNuevoTipoMoneda.Location = new System.Drawing.Point(20, 29);
            this.lblNombreNuevoTipoMoneda.Name = "lblNombreNuevoTipoMoneda";
            this.lblNombreNuevoTipoMoneda.Size = new System.Drawing.Size(47, 13);
            this.lblNombreNuevoTipoMoneda.TabIndex = 7;
            this.lblNombreNuevoTipoMoneda.Text = "Nombre:";
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Location = new System.Drawing.Point(86, 29);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.Size = new System.Drawing.Size(177, 20);
            this.txtTipoMoneda.TabIndex = 8;
            // 
            // btnAgregarTipoMoneda
            // 
            this.btnAgregarTipoMoneda.Location = new System.Drawing.Point(86, 55);
            this.btnAgregarTipoMoneda.Name = "btnAgregarTipoMoneda";
            this.btnAgregarTipoMoneda.Size = new System.Drawing.Size(177, 35);
            this.btnAgregarTipoMoneda.TabIndex = 7;
            this.btnAgregarTipoMoneda.Text = "Agregar TipoMoneda";
            this.btnAgregarTipoMoneda.UseVisualStyleBackColor = true;
            this.btnAgregarTipoMoneda.Click += new System.EventHandler(this.btnAgregarTipoMoneda_Click);
            // 
            // gbTipoMoneda
            // 
            this.gbTipoMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTipoMoneda.Controls.Add(this.btnEliminar);
            this.gbTipoMoneda.Controls.Add(this.lbTipoMoneda);
            this.gbTipoMoneda.Controls.Add(this.lblNombre);
            this.gbTipoMoneda.Location = new System.Drawing.Point(25, 6);
            this.gbTipoMoneda.Name = "gbTipoMoneda";
            this.gbTipoMoneda.Size = new System.Drawing.Size(308, 238);
            this.gbTipoMoneda.TabIndex = 8;
            this.gbTipoMoneda.TabStop = false;
            this.gbTipoMoneda.Text = "Tipos de moneda";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(86, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbTipoMoneda
            // 
            this.lbTipoMoneda.DataSource = this.bsTipoMoneda;
            this.lbTipoMoneda.DisplayMember = "Nombre";
            this.lbTipoMoneda.FormattingEnabled = true;
            this.lbTipoMoneda.Location = new System.Drawing.Point(86, 38);
            this.lbTipoMoneda.Name = "lbTipoMoneda";
            this.lbTipoMoneda.Size = new System.Drawing.Size(177, 147);
            this.lbTipoMoneda.TabIndex = 0;
            this.lbTipoMoneda.ValueMember = "ID_Tipo_Moneda";
            // 
            // bsTipoMoneda
            // 
            this.bsTipoMoneda.DataSource = typeof(ProyectoFinal.sistema.TipoMoneda);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmTipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 390);
            this.Controls.Add(this.gbNuevaFecha);
            this.Controls.Add(this.gbTipoMoneda);
            this.Name = "frmTipoMoneda";
            this.ShowIcon = false;
            this.Text = "Tipos de Moneda";
            this.Load += new System.EventHandler(this.frmTipoMoneda_Load);
            this.gbNuevaFecha.ResumeLayout(false);
            this.gbNuevaFecha.PerformLayout();
            this.gbTipoMoneda.ResumeLayout(false);
            this.gbTipoMoneda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevaFecha;
        private System.Windows.Forms.Label lblNombreNuevoTipoMoneda;
        private System.Windows.Forms.TextBox txtTipoMoneda;
        private System.Windows.Forms.Button btnAgregarTipoMoneda;
        private System.Windows.Forms.GroupBox gbTipoMoneda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lbTipoMoneda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.BindingSource bsTipoMoneda;
    }
}