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
    public partial class frmNuevoAsunto : frmAlta
    {
        public frmNuevoAsunto()
        {
            InitializeComponent();
        }

        protected override void Guardar()
        {
            try
            {
                DateTime fechaFin = new DateTime(dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day);
                DateTime fechaInicio = new DateTime(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day);
                string respuesta = Program.frmPrincipal.servicioWeb.addAsunto(txtNombre.Text, txtDescripcion.Text, fechaInicio, fechaFin, (int)cbEstado.SelectedValue, (int)cbProceso.SelectedValue, (int)cbAutoridad.SelectedValue, (int)cbCliente.SelectedValue, (int)cbAbogado.SelectedValue);
                MessageBox.Show(respuesta);
                Program.frmPrincipal.tsStatus.Text = respuesta;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNuevoAsunto_Load(object sender, EventArgs e)
        {
            try
            {
                estadoAsuntoBindingSource.DataSource = Program.frmPrincipal.servicioWeb.getEstadoAsunto("", "");
                procesoBindingSource.DataSource = Program.frmPrincipal.servicioWeb.getProceso("", "");
                autoridadBindingSource.DataSource = Program.frmPrincipal.servicioWeb.getAutoridad("", "");
                abogadosBindingSource.DataSource = Program.frmPrincipal.servicioWeb.getAbogados("", "");
                clientesBindingSource.DataSource = Program.frmPrincipal.servicioWeb.getCliente("", "");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void abogadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
