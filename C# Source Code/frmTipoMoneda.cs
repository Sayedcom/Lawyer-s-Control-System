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
    public partial class frmTipoMoneda : Form
    {
        public frmTipoMoneda()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
            Cargar(); 
        }

        private void frmTipoMoneda_Load(object sender, EventArgs e)
        {
                     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTipoMoneda.SelectedValue != null)
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteTipoMoneda((int)lbTipoMoneda.SelectedValue));
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       public  void Cargar()
        {
            try
            {
                bsTipoMoneda.DataSource = Program.frmPrincipal.servicioWeb.getTipoMoneda();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarTipoMoneda_Click(object sender, EventArgs e)
        {
            if (txtTipoMoneda.Text != "")
            {
                try
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.addTipoMoneda(txtTipoMoneda.Text));
                    Cargar();
                    txtTipoMoneda.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Ingrese un nombre para el tipo de moneda");
        }
    }
}
