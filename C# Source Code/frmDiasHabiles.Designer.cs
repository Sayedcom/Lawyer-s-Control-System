namespace ProyectoFinal
{
    partial class frmDiasHabiles
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
            this.lbDiasInhabiles = new System.Windows.Forms.ListBox();
            this.bsDiaNoHabil = new System.Windows.Forms.BindingSource(this.components);
            this.lblAño = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDiasNoHabiles = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpInhabiles = new System.Windows.Forms.DateTimePicker();
            this.gbNuevaFecha = new System.Windows.Forms.GroupBox();
            this.btnAgregarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiaNoHabil)).BeginInit();
            this.gbDiasNoHabiles.SuspendLayout();
            this.gbNuevaFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDiasInhabiles
            // 
            this.lbDiasInhabiles.DataSource = this.bsDiaNoHabil;
            this.lbDiasInhabiles.DisplayMember = "Dia";
            this.lbDiasInhabiles.FormattingEnabled = true;
            this.lbDiasInhabiles.Location = new System.Drawing.Point(47, 55);
            this.lbDiasInhabiles.Name = "lbDiasInhabiles";
            this.lbDiasInhabiles.Size = new System.Drawing.Size(177, 173);
            this.lbDiasInhabiles.TabIndex = 0;
            this.lbDiasInhabiles.ValueMember = "ID_DiaNoHabil";
            // 
            // bsDiaNoHabil
            // 
            this.bsDiaNoHabil.DataSource = typeof(ProyectoFinal.sistema.DiaNoHabil);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(9, 19);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año:";
            // 
            // cbAño
            // 
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(47, 19);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(177, 21);
            this.cbAño.TabIndex = 2;
            this.cbAño.SelectedIndexChanged += new System.EventHandler(this.cbAño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dias:";
            // 
            // gbDiasNoHabiles
            // 
            this.gbDiasNoHabiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDiasNoHabiles.Controls.Add(this.btnEliminar);
            this.gbDiasNoHabiles.Controls.Add(this.lbDiasInhabiles);
            this.gbDiasNoHabiles.Controls.Add(this.label1);
            this.gbDiasNoHabiles.Controls.Add(this.lblAño);
            this.gbDiasNoHabiles.Controls.Add(this.cbAño);
            this.gbDiasNoHabiles.Location = new System.Drawing.Point(12, 12);
            this.gbDiasNoHabiles.Name = "gbDiasNoHabiles";
            this.gbDiasNoHabiles.Size = new System.Drawing.Size(260, 280);
            this.gbDiasNoHabiles.TabIndex = 4;
            this.gbDiasNoHabiles.TabStop = false;
            this.gbDiasNoHabiles.Text = "Dias inhabiles";
            this.gbDiasNoHabiles.Enter += new System.EventHandler(this.gbDiasNoHabiles_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(47, 234);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpInhabiles
            // 
            this.dtpInhabiles.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInhabiles.Location = new System.Drawing.Point(22, 31);
            this.dtpInhabiles.Name = "dtpInhabiles";
            this.dtpInhabiles.Size = new System.Drawing.Size(202, 20);
            this.dtpInhabiles.TabIndex = 6;
            this.dtpInhabiles.ValueChanged += new System.EventHandler(this.dtpInhabiles_ValueChanged);
            // 
            // gbNuevaFecha
            // 
            this.gbNuevaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNuevaFecha.Controls.Add(this.btnAgregarFecha);
            this.gbNuevaFecha.Controls.Add(this.dtpInhabiles);
            this.gbNuevaFecha.Location = new System.Drawing.Point(12, 298);
            this.gbNuevaFecha.Name = "gbNuevaFecha";
            this.gbNuevaFecha.Size = new System.Drawing.Size(260, 100);
            this.gbNuevaFecha.TabIndex = 7;
            this.gbNuevaFecha.TabStop = false;
            this.gbNuevaFecha.Text = "Agregar nueva fecha inhábil";
            // 
            // btnAgregarFecha
            // 
            this.btnAgregarFecha.Location = new System.Drawing.Point(22, 58);
            this.btnAgregarFecha.Name = "btnAgregarFecha";
            this.btnAgregarFecha.Size = new System.Drawing.Size(202, 23);
            this.btnAgregarFecha.TabIndex = 7;
            this.btnAgregarFecha.Text = "Agregar Fecha";
            this.btnAgregarFecha.UseVisualStyleBackColor = true;
            this.btnAgregarFecha.Click += new System.EventHandler(this.btnAgregarFecha_Click);
            // 
            // frmDiasHabiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 409);
            this.Controls.Add(this.gbNuevaFecha);
            this.Controls.Add(this.gbDiasNoHabiles);
            this.Name = "frmDiasHabiles";
            this.ShowIcon = false;
            this.Text = "Dias No Hábiles";
            this.Load += new System.EventHandler(this.frmDiasHabiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDiaNoHabil)).EndInit();
            this.gbDiasNoHabiles.ResumeLayout(false);
            this.gbDiasNoHabiles.PerformLayout();
            this.gbNuevaFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDiasInhabiles;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDiasNoHabiles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpInhabiles;
        private System.Windows.Forms.GroupBox gbNuevaFecha;
        private System.Windows.Forms.Button btnAgregarFecha;
        private System.Windows.Forms.BindingSource bsDiaNoHabil;
    }
}