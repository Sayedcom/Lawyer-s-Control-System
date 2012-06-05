namespace ProyectoFinal
{
    partial class frmBuscarAsunto
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
            this.cbAsunto = new System.Windows.Forms.ComboBox();
            this.bsAsuntos = new System.Windows.Forms.BindingSource(this.components);
            this.btnVerAsunto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsAsuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAsunto
            // 
            this.cbAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAsunto.DataSource = this.bsAsuntos;
            this.cbAsunto.DisplayMember = "Nombre";
            this.cbAsunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsunto.FormattingEnabled = true;
            this.cbAsunto.Location = new System.Drawing.Point(42, 12);
            this.cbAsunto.Name = "cbAsunto";
            this.cbAsunto.Size = new System.Drawing.Size(273, 21);
            this.cbAsunto.TabIndex = 0;
            this.cbAsunto.ValueMember = "ID_Asunto";
            this.cbAsunto.SelectedIndexChanged += new System.EventHandler(this.cbAsunto_SelectedIndexChanged);
            // 
            // bsAsuntos
            // 
            this.bsAsuntos.DataSource = typeof(ProyectoFinal.sistema.Asuntos);
            // 
            // btnVerAsunto
            // 
            this.btnVerAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerAsunto.Location = new System.Drawing.Point(42, 40);
            this.btnVerAsunto.Name = "btnVerAsunto";
            this.btnVerAsunto.Size = new System.Drawing.Size(273, 23);
            this.btnVerAsunto.TabIndex = 1;
            this.btnVerAsunto.Text = "Ver Asunto";
            this.btnVerAsunto.UseVisualStyleBackColor = true;
            this.btnVerAsunto.Click += new System.EventHandler(this.btnVerAsunto_Click);
            // 
            // frmBuscarAsunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 78);
            this.Controls.Add(this.btnVerAsunto);
            this.Controls.Add(this.cbAsunto);
            this.MaximizeBox = false;
            this.Name = "frmBuscarAsunto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione asunto";
            this.Load += new System.EventHandler(this.frmBuscarAsunto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAsuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAsunto;
        private System.Windows.Forms.Button btnVerAsunto;
        private System.Windows.Forms.BindingSource bsAsuntos;
    }
}