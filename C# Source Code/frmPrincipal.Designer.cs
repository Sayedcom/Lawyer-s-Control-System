namespace ProyectoFinal
{
    partial class frmPrincipal
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
            System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msMenuLogged = new System.Windows.Forms.MenuStrip();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbogados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoAbogado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarAbogado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsunto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoAsunto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarAsunto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfiguraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiasNoHabiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipoMoneda = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiNuevaAutoridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarAutoridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoridad = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuLogged.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiCerrarSesion
            // 
            tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            tsmiCerrarSesion.Size = new System.Drawing.Size(165, 22);
            tsmiCerrarSesion.Text = "Cerrar Sesión";
            tsmiCerrarSesion.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // msMenuLogged
            // 
            this.msMenuLogged.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuario,
            this.tsmiAbogados,
            this.tsmiClientes,
            this.tsmiAsunto,
            this.tsmiAutoridad,
            this.tsmiConfiguraciones});
            this.msMenuLogged.Location = new System.Drawing.Point(0, 0);
            this.msMenuLogged.Name = "msMenuLogged";
            this.msMenuLogged.Size = new System.Drawing.Size(834, 24);
            this.msMenuLogged.TabIndex = 1;
            this.msMenuLogged.Text = "menuStrip1";
            this.msMenuLogged.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMenuLogged_ItemClicked);
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIniciarSesion,
            tsmiCerrarSesion,
            this.tsmiSalir});
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(48, 20);
            this.tsmiUsuario.Text = "Inicio";
            this.tsmiUsuario.Click += new System.EventHandler(this.tsmiUsuario_Click);
            // 
            // tsmiIniciarSesion
            // 
            this.tsmiIniciarSesion.Name = "tsmiIniciarSesion";
            this.tsmiIniciarSesion.Size = new System.Drawing.Size(165, 22);
            this.tsmiIniciarSesion.Text = "Iniciar Sesión";
            this.tsmiIniciarSesion.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(165, 22);
            this.tsmiSalir.Text = "Cerrar Aplicación";
            this.tsmiSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmiAbogados
            // 
            this.tsmiAbogados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoAbogado,
            this.tsmiBuscarAbogado});
            this.tsmiAbogados.Enabled = false;
            this.tsmiAbogados.Name = "tsmiAbogados";
            this.tsmiAbogados.Size = new System.Drawing.Size(73, 20);
            this.tsmiAbogados.Text = "Abogados";
            // 
            // tsmiNuevoAbogado
            // 
            this.tsmiNuevoAbogado.Name = "tsmiNuevoAbogado";
            this.tsmiNuevoAbogado.Size = new System.Drawing.Size(161, 22);
            this.tsmiNuevoAbogado.Text = "Nuevo Abogado";
            this.tsmiNuevoAbogado.Click += new System.EventHandler(this.nuevoAbogadoToolStripMenuItem_Click);
            // 
            // tsmiBuscarAbogado
            // 
            this.tsmiBuscarAbogado.Name = "tsmiBuscarAbogado";
            this.tsmiBuscarAbogado.Size = new System.Drawing.Size(161, 22);
            this.tsmiBuscarAbogado.Text = "Buscar";
            this.tsmiBuscarAbogado.Click += new System.EventHandler(this.buscarToolStripMenuItem2_Click);
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoCliente,
            this.tsmiBuscarCliente});
            this.tsmiClientes.Enabled = false;
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmiClientes.Text = "Clientes";
            // 
            // tsmiNuevoCliente
            // 
            this.tsmiNuevoCliente.Name = "tsmiNuevoCliente";
            this.tsmiNuevoCliente.Size = new System.Drawing.Size(147, 22);
            this.tsmiNuevoCliente.Text = "Nuevo cliente";
            this.tsmiNuevoCliente.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // tsmiBuscarCliente
            // 
            this.tsmiBuscarCliente.Name = "tsmiBuscarCliente";
            this.tsmiBuscarCliente.Size = new System.Drawing.Size(147, 22);
            this.tsmiBuscarCliente.Text = "Buscar";
            this.tsmiBuscarCliente.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // tsmiAsunto
            // 
            this.tsmiAsunto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoAsunto,
            this.tsmiBuscarAsunto});
            this.tsmiAsunto.Enabled = false;
            this.tsmiAsunto.Name = "tsmiAsunto";
            this.tsmiAsunto.Size = new System.Drawing.Size(57, 20);
            this.tsmiAsunto.Text = "Asunto";
            // 
            // tsmiNuevoAsunto
            // 
            this.tsmiNuevoAsunto.Name = "tsmiNuevoAsunto";
            this.tsmiNuevoAsunto.Size = new System.Drawing.Size(150, 22);
            this.tsmiNuevoAsunto.Text = "Nuevo Asunto";
            this.tsmiNuevoAsunto.Click += new System.EventHandler(this.nuevoAsuntoToolStripMenuItem_Click);
            // 
            // tsmiBuscarAsunto
            // 
            this.tsmiBuscarAsunto.Name = "tsmiBuscarAsunto";
            this.tsmiBuscarAsunto.Size = new System.Drawing.Size(150, 22);
            this.tsmiBuscarAsunto.Text = "Buscar";
            this.tsmiBuscarAsunto.Click += new System.EventHandler(this.tsmiBuscarAsunto_Click);
            // 
            // tsmiConfiguraciones
            // 
            this.tsmiConfiguraciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDiasNoHabiles,
            this.tsmiTipoMoneda});
            this.tsmiConfiguraciones.Enabled = false;
            this.tsmiConfiguraciones.Name = "tsmiConfiguraciones";
            this.tsmiConfiguraciones.Size = new System.Drawing.Size(106, 20);
            this.tsmiConfiguraciones.Text = "Configuraciones";
            this.tsmiConfiguraciones.Click += new System.EventHandler(this.configuracionesToolStripMenuItem_Click);
            // 
            // tsmiDiasNoHabiles
            // 
            this.tsmiDiasNoHabiles.Name = "tsmiDiasNoHabiles";
            this.tsmiDiasNoHabiles.Size = new System.Drawing.Size(153, 22);
            this.tsmiDiasNoHabiles.Text = "Dias no habiles";
            this.tsmiDiasNoHabiles.Click += new System.EventHandler(this.tsmiDiasNoHabiles_Click);
            // 
            // tsmiTipoMoneda
            // 
            this.tsmiTipoMoneda.Name = "tsmiTipoMoneda";
            this.tsmiTipoMoneda.Size = new System.Drawing.Size(153, 22);
            this.tsmiTipoMoneda.Text = "Tipo Moneda";
            this.tsmiTipoMoneda.Click += new System.EventHandler(this.tsmiTipoMoneda_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 390);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(834, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(42, 17);
            this.tsStatus.Text = "Status:";
            // 
            // tsmiNuevaAutoridad
            // 
            this.tsmiNuevaAutoridad.Name = "tsmiNuevaAutoridad";
            this.tsmiNuevaAutoridad.Size = new System.Drawing.Size(164, 22);
            this.tsmiNuevaAutoridad.Text = "Nueva Autoridad";
            // 
            // tsmiBuscarAutoridad
            // 
            this.tsmiBuscarAutoridad.Name = "tsmiBuscarAutoridad";
            this.tsmiBuscarAutoridad.Size = new System.Drawing.Size(164, 22);
            this.tsmiBuscarAutoridad.Text = "Buscar";
            // 
            // tsmiAutoridad
            // 
            this.tsmiAutoridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaAutoridad,
            this.tsmiBuscarAutoridad});
            this.tsmiAutoridad.Enabled = false;
            this.tsmiAutoridad.Name = "tsmiAutoridad";
            this.tsmiAutoridad.Size = new System.Drawing.Size(72, 20);
            this.tsmiAutoridad.Text = "Autoridad";
            this.tsmiAutoridad.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.msMenuLogged);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuLogged;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Control  -- 4G Corporativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msMenuLogged.ResumeLayout(false);
            this.msMenuLogged.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuLogged;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsunto;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoAsunto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbogados;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoAbogado;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarAbogado;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarAsunto;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfiguraciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiasNoHabiles;
        public System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiTipoMoneda;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoridad;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaAutoridad;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarAutoridad;
    }
}

