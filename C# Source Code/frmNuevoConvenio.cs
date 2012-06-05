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
    public partial class frmNuevoConvenio : frmAlta
    {
        sistema.Asuntos Asunto;
        public frmNuevoConvenio(sistema.Asuntos Asunto)
        {
            InitializeComponent();
            this.Asunto = Asunto;
        }

        private void frmNuevoConvenio_Load(object sender, EventArgs e)
        {
            try
            {
                bsTipoMoneda.DataSource = Program.frmPrincipal.servicioWeb.getTipoMoneda();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void Guardar()
        {
            try
            {
                MessageBox.Show(Program.frmPrincipal.servicioWeb.addConvenio(Asunto.ID_Asunto, double.Parse(txtCantidad.Text), txtDescripcion.Text, (int)cbTipoMoneda.SelectedValue));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue == 46))
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
