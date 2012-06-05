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
    public partial class frmBuscarAsunto : Form
    {
        sistema.Asuntos asunto;
        public frmBuscarAsunto()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
        }

        private void frmBuscarAsunto_Load(object sender, EventArgs e)
        {
            try
            {
                bsAsuntos.DataSource = Program.frmPrincipal.servicioWeb.getAsunto("", "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVerAsunto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAsunto.SelectedValue != null)
                {
                    cbAsunto.Select();
                    asunto = Program.frmPrincipal.servicioWeb.getAsunto("ID_Asunto", cbAsunto.SelectedValue.ToString())[0];


                    if (Program.frmPrincipal.frmAsunto == null || Program.frmPrincipal.frmAsunto.IsDisposed)
                        Program.frmPrincipal.frmAsunto = new frmAsunto(asunto);
                    Program.frmPrincipal.frmAsunto.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAsunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbAsunto.SelectedValue!=null)
                asunto = Program.frmPrincipal.servicioWeb.getAsunto("ID_Asunto", cbAsunto.SelectedValue.ToString())[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
