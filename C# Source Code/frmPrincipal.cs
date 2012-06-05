using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoFinal.sistema;

namespace ProyectoFinal
{
    public partial class frmPrincipal : Form
    {
        public ServicioCasosFiscales servicioWeb;
        public frmLogin frmLogin;
        public frmAbogados frmAbogados;
        public frmClientes frmClientes;
        public frmNuevoAbogado frmNuevoAbogado;
        public frmNuevoCliente frmNuevoCliente;
        public frmNuevoAsunto frmNuevoAsunto;
        public frmDiasHabiles frmDiasHabiles;
        public frmAsunto frmAsunto;
        public frmBuscarAsunto frmBuscarAsunto;
        public frmVisorArchivos frmVisorArchivos;
        public frmNuevaEtapa frmNuevaEtapa;
        public frmNuevoConvenio frmNuevoConvenio;
        public frmTipoMoneda frmTipoMoneda;
        public frmNuevoPago frmNuevoPago;
        public frmEditarEtapa frmEditarEtapa;
        public frmPrincipal()
        {
            InitializeComponent();
            servicioWeb = new ServicioCasosFiscales();
           
        }

        public void activarMenu()
        {
           //activa menu una vez iniciada sesión
            tsmiAbogados.Enabled = true;
            tsmiAsunto.Enabled = true;
            tsmiClientes.Enabled = true;
            tsmiIniciarSesion.Enabled = false;
            tsmiAutoridad.Enabled = true;
            tsmiConfiguraciones.Enabled = true;
            
         
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsmiUsuario_Click(object sender, EventArgs e)
        {

        }

        private void msMenuLogged_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
                frmLogin.Show();
        }

        private void nuevoAbogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.sesionAbogado.Superusuario == true)
            {
                frmNuevoAbogado frmNuevoAbogado = new frmNuevoAbogado();
                frmNuevoAbogado.Show();
            }
            else
            {
                MessageBox.Show("Usted necesita tener privilegios de administrador");
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNuevoCliente == null|| frmNuevoCliente.IsDisposed)
                    frmNuevoCliente = new frmNuevoCliente();
            frmNuevoCliente.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmAbogados == null || frmAbogados.IsDisposed)
                frmAbogados = new frmAbogados();
            frmAbogados.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientes == null || frmClientes.IsDisposed)
                frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoAsuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNuevoAsunto == null|| frmNuevoAsunto.IsDisposed)
            {
                frmNuevoAsunto = new frmNuevoAsunto();
                frmNuevoAsunto.Show();
            }
        }

        private void asuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiProcesos_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDiasNoHabiles_Click(object sender, EventArgs e)
        {
            if (frmDiasHabiles == null || frmDiasHabiles.IsDisposed)
                frmDiasHabiles = new frmDiasHabiles();
            frmDiasHabiles.Show();
        }

        private void tsmiBuscarAsunto_Click(object sender, EventArgs e)
        {
            if (frmBuscarAsunto == null || frmBuscarAsunto.IsDisposed)
                frmBuscarAsunto = new frmBuscarAsunto();
            frmBuscarAsunto.Show();
            
        }

        private void tsmiTipoMoneda_Click(object sender, EventArgs e)
        {
            if (frmTipoMoneda == null || frmTipoMoneda.IsDisposed)
                frmTipoMoneda = new frmTipoMoneda();

            frmTipoMoneda.Show();
        }
    }
}
