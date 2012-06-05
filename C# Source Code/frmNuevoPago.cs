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
    public partial class frmNuevoPago : frmAlta
    {
        sistema.Asuntos Asunto;
        public frmNuevoPago(sistema.Asuntos Asunto)
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
            this.Asunto = Asunto;
            dtpFechaPago.Value = DateTime.Today;
        }

        private void frmNuevoPago_Load(object sender, EventArgs e)
        {
            
        }

        protected override void Guardar()
        {
            if (txtCantidad != null)
            {
                try
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.addPago(Program.frmPrincipal.servicioWeb.getConvenio("ID_Asunto", Asunto.ID_Asunto.ToString())[0].ID_Convenio, Asunto.ID_Asunto, double.Parse(txtCantidad.Text), dtpFechaPago.Value));
                    this.Close();
                    Program.frmPrincipal.frmAsunto.bsPago.DataSource = Program.frmPrincipal.servicioWeb.getPago("ID_Asunto", Asunto.ID_Asunto.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Cantidad");
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue == 46) )
            { 
            }
            else
            {
                MessageBox.Show("Solo números", "Error");
                txtCantidad.Text = "";
                txtCantidad.Focus();
            }
        }
    }
}
