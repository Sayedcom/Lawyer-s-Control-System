namespace ProyectoFinal
{
    partial class frmAlta
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
            this.tsHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHerramientas
            // 
            this.tsHerramientas.AllowDrop = true;
            this.tsHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsHerramientas.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsSeparador,
            this.tsbLimpiar,
            this.tsbCerrar});
            this.tsHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsHerramientas.Name = "tsHerramientas";
            this.tsHerramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsHerramientas.Size = new System.Drawing.Size(434, 74);
            this.tsHerramientas.Stretch = true;
            this.tsHerramientas.TabIndex = 0;
            this.tsHerramientas.Text = "Menu";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = global::ProyectoFinal.Properties.Resources.usb;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(60, 71);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsSeparador
            // 
            this.tsSeparador.Name = "tsSeparador";
            this.tsSeparador.Size = new System.Drawing.Size(6, 74);
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLimpiar.Image = global::ProyectoFinal.Properties.Resources.clear;
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(55, 71);
            this.tsbLimpiar.Text = "Limpiar";
            this.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLimpiar.Click += new System.EventHandler(this.tsbLimpiar_Click);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = global::ProyectoFinal.Properties.Resources.error;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(57, 71);
            this.tsbCerrar.Text = "Cancelar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 317);
            this.Controls.Add(this.tsHerramientas);
            this.Name = "frmAlta";
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.tsHerramientas.ResumeLayout(false);
            this.tsHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsHerramientas;
        public System.Windows.Forms.ToolStripButton tsbGuardar;
        public System.Windows.Forms.ToolStripSeparator tsSeparador;
        public System.Windows.Forms.ToolStripButton tsbLimpiar;
        public System.Windows.Forms.ToolStripButton tsbCerrar;


    }
}