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
    public partial class frmClientes : Form
    {
       public int idCliente = 0;
        sistema.Clientes[] ClientesList;

        public frmClientes()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
            try
            {

                txtFiltro.Focus();
                //cargo datos de clientes en lista
                ClientesList = Program.frmPrincipal.servicioWeb.getCliente("", "");

                if (ClientesList != null)
                    //lleno datasource de clientes
                    bsClientes.DataSource = ClientesList;
                else
                    MessageBox.Show("No se encontraron datos");

                //opciones para filtro de busqueda 
                cbCampo.Items.Add("ID_Cliente");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Email");
                cbCampo.Items.Add("Direccion");
                cbCampo.Items.Add("Telefono");
                cbCampo.Items.Add("Celular");
                cbCampo.Items.Add("Nextel");
                cbCampo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                  //aplico filtro de busqueda  
                    ClientesList = Program.frmPrincipal.servicioWeb.getCliente(cbCampo.SelectedItem.ToString(), txtFiltro.Text);

                    if (ClientesList != null)
                        bsClientes.DataSource = ClientesList;
                    else
                        MessageBox.Show("No se encontraron datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            dtpFechaN.Enabled = true;
            txtDireccion.Enabled = true;
            txtCelular.Enabled = true;
            txtTelefono.Enabled = true;
            txtNextel.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un nombre");
                    txtNombre.Focus();
                }
                else if (!Funciones.ValidarEmail(txtEmail.Text))
                {
                    MessageBox.Show("Ingrese una dirección valida de correo electrónico.");
                    txtEmail.Focus();
                }
                else
                {
                 //desactivo controles 
                    txtNombre.Enabled = false;
                    txtEmail.Enabled = false;
                    dtpFechaN.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCelular.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtNextel.Enabled = false;
                    btnEditar.Enabled = true;
                    btnGuardar.Enabled = false;
                    DateTime fecha = new DateTime(dtpFechaN.Value.Year, dtpFechaN.Value.Month, dtpFechaN.Value.Day);
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.updateCliente(idCliente.ToString(), txtNombre.Text, txtEmail.Text, fecha, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, txtNextel.Text));
                    ClientesList = Program.frmPrincipal.servicioWeb.getCliente("", "");
                    bsClientes.DataSource = ClientesList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar los datos del sistema?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteCliente(idCliente.ToString()));
                    ClientesList = Program.frmPrincipal.servicioWeb.getCliente("", "");
                    bsClientes.DataSource = ClientesList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                //saco la información del cliente selccionado y lleno los datos del tab de informacion personal para editar
                idCliente = (int)dgClientes[0, dgClientes.CurrentCell.RowIndex].Value;
                sistema.Clientes Cliente = Program.frmPrincipal.servicioWeb.getCliente("ID_Cliente",idCliente.ToString())[0];
                txtNombre.Text = Cliente.Nombre;
                txtEmail.Text = Cliente.Email;
                dtpFechaN.Value = Cliente.FechaN;
                txtDireccion.Text = Cliente.Direccion;
                txtTelefono.Text = Cliente.Telefono;
                txtCelular.Text = Cliente.Celular;
                txtNextel.Text = Cliente.Nextel;
                idCliente = Cliente.ID_Cliente;
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEstadoAsunto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
