using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmAsunto : Form
    {
        sistema.Asuntos Asunto;
        
        public frmAsunto(sistema.Asuntos asunto)
        {
            InitializeComponent();
            this.Asunto = asunto;
            this.MdiParent = Program.frmPrincipal;
        }

        private void frmAsunto_Load(object sender, EventArgs e)
        {
            rellenarCampos();
        }

        public void rellenarCampos()
        {
            try
            {
                
                //informacion del asunto
                txtNombre.Text = Asunto.Nombre;
                txtDescripcion.Text = Asunto.Descripcion;
                dtpFechaInicio.Value = Asunto.Fecha_inicio;
                dtpFechaFin.Value = Asunto.Fecha_fin;
                //binding sources
                bsEstadoAsunto.DataSource = Program.frmPrincipal.servicioWeb.getEstadoAsunto("ID_Estado", Asunto.ID_Estado.ToString())[0];
                bsProceso.DataSource = Program.frmPrincipal.servicioWeb.getProceso("ID_Proceso", Asunto.ID_Proceso.ToString())[0];
                bsAbogados.DataSource = Program.frmPrincipal.servicioWeb.getAbogados("ID_Abogado", Asunto.ID_Abogado.ToString())[0];
                bsAutoridad.DataSource = Program.frmPrincipal.servicioWeb.getAutoridad("ID_Autoridad", Asunto.ID_Autoridad.ToString())[0];
                bsClientes.DataSource = Program.frmPrincipal.servicioWeb.getCliente("ID_Cliente", Asunto.ID_Cliente.ToString())[0];
            
                //Etapas procesales del asunto
                sistema.Etapa[] etapasDelAsunto = Program.frmPrincipal.servicioWeb.getEtapa("ID_Asunto", Asunto.ID_Asunto.ToString());
                if (etapasDelAsunto!=null) 
                {
                    bsEtapaAsuntoCombo.DataSource = etapasDelAsunto;
                 }
                else
                {
                    cbEtapasProcesoAsunto.Text = "No hay etapas";
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //activar controles
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
            cbProceso.Enabled = true;
            cbEstado.Enabled = true;
            cbAbogado.Enabled = true;
            cbCliente.Enabled = true;
            cbAutoridad.Enabled = true;
            //rellenar los data bindings
            bsEstadoAsunto.DataSource = Program.frmPrincipal.servicioWeb.getEstadoAsunto("", "");
            bsProceso.DataSource = Program.frmPrincipal.servicioWeb.getProceso("", "");
            bsAbogados.DataSource = Program.frmPrincipal.servicioWeb.getAbogados("", "");
            bsAutoridad.DataSource = Program.frmPrincipal.servicioWeb.getAutoridad("", "");
            bsClientes.DataSource = Program.frmPrincipal.servicioWeb.getCliente("", "");
            //botones
            btnEditar.Enabled = false;
            btnGuardarAsunto.Enabled = true;
        }

        private void btnGuardarAsunto_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Program.frmPrincipal.servicioWeb.updateAsunto(Asunto.ID_Asunto.ToString(), txtNombre.Text, txtDescripcion.Text, dtpFechaInicio.Value, dtpFechaFin.Value, (int)cbEstado.SelectedValue, (int)cbProceso.SelectedValue, (int)cbAutoridad.SelectedValue, (int)cbCliente.SelectedValue, (int)cbAbogado.SelectedValue));

            }
            catch
                (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void cbEtapasProcesoAsunto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbEtapasProcesoAsunto.SelectedValue != null)
                {

                    sistema.Etapa[] Etapa = Program.frmPrincipal.servicioWeb.getEtapa("ID_EstadoProceso", cbEtapasProcesoAsunto.SelectedValue.ToString());
                    bsEtapaAsunto.DataSource = Etapa;
                     //Saco la información de la etapa procesal con el ID que se encuentra en la etapa del asunto registrada
                    bsEtapaProceso.DataSource = Program.frmPrincipal.servicioWeb.getEstadoProceso("ID_EstadoProceso", cbEtapasProcesoAsunto.SelectedValue.ToString());
                     //calculo vencimiento
                    //si los dias de vencimiento = 0, entonces no hay dia definido
                    if (int.Parse(txtVencimiento.Text) != 0)
                        lblFechaLimite.Text = "Fecha Limite para contestar: " + Funciones.fechaLimite(Etapa[0].Fecha_Inicio, double.Parse(txtVencimiento.Text)).ToShortDateString();
                    else
                        lblFechaLimite.Text = "";
                    btnVerArchivos.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerArchivos_Click_1(object sender, EventArgs e)
        {
            if (Program.frmPrincipal.frmVisorArchivos == null || Program.frmPrincipal.frmVisorArchivos.IsDisposed)
                Program.frmPrincipal.frmVisorArchivos = new frmVisorArchivos(Asunto, int.Parse(cbEtapasProcesoAsunto.SelectedValue.ToString()));
            Program.frmPrincipal.frmVisorArchivos.Show();
        }

        private void btnAgregarEtapa_Click(object sender, EventArgs e)
        {
            if (Program.frmPrincipal.frmNuevaEtapa == null || Program.frmPrincipal.frmNuevaEtapa.IsDisposed)
                Program.frmPrincipal.frmNuevaEtapa = new frmNuevaEtapa(Asunto.ID_Asunto);
            Program.frmPrincipal.frmNuevaEtapa.Show();
            
        }

        private void tpPagos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (Program.frmPrincipal.frmNuevoPago == null || Program.frmPrincipal.frmNuevoPago.IsDisposed)
                Program.frmPrincipal.frmNuevoPago = new frmNuevoPago(Asunto);
            Program.frmPrincipal.frmNuevoPago.Show();
        }

        private void tcEtapasPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando se presiona tab de convenio 
            if (tcEtapasPagos.SelectedIndex == 1)
            {
                //checa si existe convenio, si no existe pregunta si desea agregar nuevo y manda forma
                sistema.Convenio[] convenioAsunto = Program.frmPrincipal.servicioWeb.getConvenio("ID_Asunto", Asunto.ID_Asunto.ToString());
                if (convenioAsunto == null)
                {
                    if (MessageBox.Show("No hay convenio para este asunto. ¿Desea agregar un nuevo convenio?", "Advertencia", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (Program.frmPrincipal.frmNuevoConvenio == null || Program.frmPrincipal.frmNuevoConvenio.IsDisposed)
                            Program.frmPrincipal.frmNuevoConvenio = new frmNuevoConvenio(Asunto);
                        Program.frmPrincipal.frmNuevoConvenio.Show();
                    }
                    else
                    {
                        gbConvenio.Visible = false;
                        gbPagos.Visible = false;
                    }
                }
                else
                {
                    try
                    {
                        //llena campos de convenio actual si si existe
                        sistema.Convenio Convenio = Program.frmPrincipal.servicioWeb.getConvenio("ID_Asunto", Asunto.ID_Asunto.ToString())[0];
                        txtCantidad.Text = Convenio.Cantidad.ToString();
                        txtDescripcionConvenio.Text = Convenio.Descripcion.ToString();
                        bsTipoMoneda.DataSource = Program.frmPrincipal.servicioWeb.getTipoMoneda();
                        cbTipoMoneda.SelectedValue = Convenio.ID_Tipo_Moneda.ToString();
                        sistema.Pago[] Pagos = Program.frmPrincipal.servicioWeb.getPago("ID_Asunto", Asunto.ID_Asunto.ToString());
                        if (Pagos != null)
                        {
                            bsPago.DataSource = Pagos;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tcEtapasPagos_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el asunto?", "Advertencia", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    //borra el asunto
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteAsunto(Asunto.ID_Asunto.ToString()));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarEtapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar la etapa?", "Advertencia", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    //borra la etapa
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteEtapa(cbEtapasProcesoAsunto.SelectedValue.ToString()));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPagos.SelectedRows != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar pago?", "Advertencia", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show(Program.frmPrincipal.servicioWeb.deletePago(dgPagos[0, dgPagos.CurrentCell.RowIndex].Value.ToString()));
                        bsPago.DataSource = Program.frmPrincipal.servicioWeb.getPago("ID_Asunto", Asunto.ID_Asunto.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarEtapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.frmPrincipal.frmEditarEtapa == null || Program.frmPrincipal.frmEditarEtapa.IsDisposed)
                    Program.frmPrincipal.frmEditarEtapa = new frmEditarEtapa((int)cbEtapasProcesoAsunto.SelectedValue);
                Program.frmPrincipal.frmEditarEtapa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
