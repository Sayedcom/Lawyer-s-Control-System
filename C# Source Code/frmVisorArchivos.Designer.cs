namespace ProyectoFinal
{
    partial class frmVisorArchivos
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
            this.lvVisor = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTamano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbCargar = new System.Windows.Forms.ToolStripButton();
            this.tsbDescargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripButton();
            this.fdElegirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.ilGrandes = new System.Windows.Forms.ImageList(this.components);
            this.ilChicas = new System.Windows.Forms.ImageList(this.components);
            this.ssVisorArchivos = new System.Windows.Forms.StatusStrip();
            this.tspbSubirArchivo = new System.Windows.Forms.ToolStripProgressBar();
            this.tslblSubirArchivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.fbdGuardarRuta = new System.Windows.Forms.FolderBrowserDialog();
            this.tsMenu.SuspendLayout();
            this.ssVisorArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVisor
            // 
            this.lvVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVisor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chExtension,
            this.chTamano});
            this.lvVisor.Location = new System.Drawing.Point(0, 39);
            this.lvVisor.MultiSelect = false;
            this.lvVisor.Name = "lvVisor";
            this.lvVisor.ShowItemToolTips = true;
            this.lvVisor.Size = new System.Drawing.Size(480, 295);
            this.lvVisor.TabIndex = 0;
            this.lvVisor.UseCompatibleStateImageBehavior = false;
            this.lvVisor.View = System.Windows.Forms.View.Details;
            this.lvVisor.SelectedIndexChanged += new System.EventHandler(this.lvVisor_SelectedIndexChanged);
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 100;
            // 
            // chExtension
            // 
            this.chExtension.Text = "Extension";
            this.chExtension.Width = 71;
            // 
            // chTamano
            // 
            this.chTamano.Text = "Tamaño";
            this.chTamano.Width = 100;
            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.Color.LightCoral;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCargar,
            this.tsbDescargarArchivo,
            this.tsmiEliminar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(480, 38);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbCargar
            // 
            this.tsbCargar.Image = global::ProyectoFinal.Properties.Resources.agregar;
            this.tsbCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCargar.Name = "tsbCargar";
            this.tsbCargar.Size = new System.Drawing.Size(90, 35);
            this.tsbCargar.Text = "Cargar Archivo";
            this.tsbCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCargar.Click += new System.EventHandler(this.tsbCargar_Click);
            // 
            // tsbDescargarArchivo
            // 
            this.tsbDescargarArchivo.Image = global::ProyectoFinal.Properties.Resources.usb;
            this.tsbDescargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDescargarArchivo.Name = "tsbDescargarArchivo";
            this.tsbDescargarArchivo.Size = new System.Drawing.Size(107, 35);
            this.tsbDescargarArchivo.Text = "Descargar Archivo";
            this.tsbDescargarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDescargarArchivo.Visible = false;
            this.tsbDescargarArchivo.Click += new System.EventHandler(this.tsbDescargarArchivo_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Image = global::ProyectoFinal.Properties.Resources.error;
            this.tsmiEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(54, 35);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiEliminar.Visible = false;
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // fdElegirArchivo
            // 
            this.fdElegirArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.fdElegirArchivo_FileOk);
            // 
            // ilGrandes
            // 
            this.ilGrandes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilGrandes.ImageSize = new System.Drawing.Size(16, 16);
            this.ilGrandes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilChicas
            // 
            this.ilChicas.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilChicas.ImageSize = new System.Drawing.Size(30, 30);
            this.ilChicas.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ssVisorArchivos
            // 
            this.ssVisorArchivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbSubirArchivo,
            this.tslblSubirArchivo});
            this.ssVisorArchivos.Location = new System.Drawing.Point(0, 310);
            this.ssVisorArchivos.Name = "ssVisorArchivos";
            this.ssVisorArchivos.Size = new System.Drawing.Size(480, 22);
            this.ssVisorArchivos.TabIndex = 2;
            this.ssVisorArchivos.Text = "statusStrip1";
            // 
            // tspbSubirArchivo
            // 
            this.tspbSubirArchivo.Name = "tspbSubirArchivo";
            this.tspbSubirArchivo.Size = new System.Drawing.Size(100, 16);
            this.tspbSubirArchivo.Visible = false;
            // 
            // tslblSubirArchivo
            // 
            this.tslblSubirArchivo.Name = "tslblSubirArchivo";
            this.tslblSubirArchivo.Size = new System.Drawing.Size(99, 17);
            this.tslblSubirArchivo.Text = "Subiendo archivo";
            this.tslblSubirArchivo.Visible = false;
            // 
            // fbdGuardarRuta
            // 
            this.fbdGuardarRuta.Description = "Seleccione la carpeta donde desea guardar el archivo.";
            // 
            // frmVisorArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 332);
            this.Controls.Add(this.ssVisorArchivos);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.lvVisor);
            this.Name = "frmVisorArchivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Archivos";
            this.Load += new System.EventHandler(this.frmVisorArchivos_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ssVisorArchivos.ResumeLayout(false);
            this.ssVisorArchivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVisor;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbCargar;
        private System.Windows.Forms.ToolStripButton tsbDescargarArchivo;
        private System.Windows.Forms.OpenFileDialog fdElegirArchivo;
        private System.Windows.Forms.ImageList ilGrandes;
        private System.Windows.Forms.ImageList ilChicas;
        private System.Windows.Forms.ToolStripButton tsmiEliminar;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chExtension;
        private System.Windows.Forms.ColumnHeader chTamano;
        private System.Windows.Forms.StatusStrip ssVisorArchivos;
        private System.Windows.Forms.ToolStripStatusLabel tslblSubirArchivo;
        public System.Windows.Forms.ToolStripProgressBar tspbSubirArchivo;
        private System.Windows.Forms.FolderBrowserDialog fbdGuardarRuta;
    }
}