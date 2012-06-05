using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ProyectoFinal
{
    public partial class frmAbogados : Form
    {
        protected int idAbogado = 0;
        sistema.Abogados[] AbogadosList;
        sistema.Asuntos[] AsuntosList;
        sistema.Asuntos asuntoSeleccionado;
        public frmAbogados()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
        }

        private void frmAbogados_Load(object sender, EventArgs e)
        {
           try
            {
                txtFiltro.Focus();
                
                AbogadosList = Program.frmPrincipal.servicioWeb.getAbogados("","");
                               
                if (AbogadosList != null)
                {
                    
                   bsAbogados.DataSource= AbogadosList;
                   dgAbogados.Columns[3].Visible = false; //escondo campo de contraseña
                }
                else
                {
                    MessageBox.Show("No se encontraron datos");
                }

                cbCampo.Items.Add("ID_Abogado");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Email");
                cbCampo.Items.Add("Direccion");
                cbCampo.Items.Add("Telefono");
                cbCampo.Items.Add("Celular");
                cbCampo.Items.Add("Nextel");
                cbCampo.SelectedIndex = 1;

                //llenar el combo box de Estado de asuntos
                bsEstadoAsunto.DataSource = Program.frmPrincipal.servicioWeb.getEstadoAsunto("", "");
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.TargetSite);
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    AbogadosList = Program.frmPrincipal.servicioWeb.getAbogados(cbCampo.SelectedItem.ToString(),txtFiltro.Text);
                    
                    if (AbogadosList != null)
                    {
                        bsAbogados.DataSource = AbogadosList;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ":" + ex.Source);
                }
            }
        }

        private void dgAbogados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbEstadoAsunto.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
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
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un email");
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese una contraseña");
                    txtPassword.Focus();
                }
                 else if (!Funciones.ValidarEmail(txtEmail.Text))
                 {
                     MessageBox.Show("Ingrese una dirección valida de correo electrónico.");
                     txtEmail.Focus();
                 }
                 else
                 {

                     txtNombre.Enabled = false;
                     txtEmail.Enabled = false;
                     txtPassword.Enabled = false;
                     dtpFechaN.Enabled = false;
                     txtDireccion.Enabled = false;
                     txtCelular.Enabled = false;
                     txtTelefono.Enabled = false;
                     txtNextel.Enabled = false;
                     btnEditar.Enabled = true;
                     btnGuardar.Enabled = false;

                     DateTime fecha = new DateTime(dtpFechaN.Value.Year, dtpFechaN.Value.Month, dtpFechaN.Value.Day);
                     MessageBox.Show(Program.frmPrincipal.servicioWeb.updateAbogados(idAbogado.ToString(), txtNombre.Text, txtEmail.Text, txtPassword.Text, fecha, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, txtNextel.Text, false));
                     AbogadosList = Program.frmPrincipal.servicioWeb.getAbogados("", "");
                     bsAbogados.DataSource = AbogadosList;
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".Metodo:" + ex.TargetSite + ":" + ex.Source);
            }
        }

        private void dgAbogados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Para el tab de Asunto del abogado
                cbEstadoAsunto.Select();
                AsuntosList = Program.frmPrincipal.servicioWeb.getAsunto("ID_Abogado", dgAbogados[0, dgAbogados.CurrentRow.Index].Value.ToString());
               bsAsuntos.DataSource = AsuntosList;
               if (Program.sesionAbogado.Superusuario == true)
                   gbHerramientas.Enabled = true;
               
                //Para el tab de Información personal del abogado

                sistema.Abogados[] Abogado = Program.frmPrincipal.servicioWeb.getAbogados("ID_Abogado", dgAbogados[0, dgAbogados.CurrentRow.Index].Value.ToString());
                txtNombre.Text = Abogado[0].Nombre;
                txtEmail.Text = Abogado[0].Email;
                txtPassword.Text = Abogado[0].Password;
                dtpFechaN.Value = new DateTime(Abogado[0].FechaN.Year, Abogado[0].FechaN.Month, Abogado[0].FechaN.Day);
                txtDireccion.Text = Abogado[0].Direccion;
                txtTelefono.Text = Abogado[0].Telefono;
                txtCelular.Text = Abogado[0].Celular;
                txtNextel.Text = Abogado[0].Nextel;
                idAbogado = Abogado[0].ID_Abogado;
                tcAbogados.Appearance = TabAppearance.FlatButtons;
                tcAbogados.TabIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".Metodo:" + ex.TargetSite + ":" + ex.Source);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar los datos del sistema?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteAbogados(idAbogado.ToString()));
                    AbogadosList = Program.frmPrincipal.servicioWeb.getAbogados("", "");
                    bsAbogados.DataSource = AbogadosList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".Metodo:" + ex.TargetSite + ":" + ex.Source);
            }
        }

        private void cbEstadoAsunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgAbogados.SelectedRows != null&& cbEstadoAsunto.SelectedValue!=null)
                {
                    lbAsuntos.Select();
                    bsAsuntos.DataSource = Program.frmPrincipal.servicioWeb.getAsunto2("ID_Abogado", dgAbogados[0, dgAbogados.CurrentRow.Index].Value.ToString(), cbEstadoAsunto.SelectedValue.ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ ":" + ex.TargetSite + ":"+ ex.Source);
            }
        }

        private void lbAsuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
           //actualizar datos de los detalles del asunto seleccionado
            if (lbAsuntos.SelectedValue != null)
            {
                try
                {
                    btnVerAsunto.Enabled = true;
                    asuntoSeleccionado= Program.frmPrincipal.servicioWeb.getAsunto("ID_Asunto", lbAsuntos.SelectedValue.ToString())[0];
                    bsClientes.DataSource = Program.frmPrincipal.servicioWeb.getCliente("ID_Cliente", asuntoSeleccionado.ID_Cliente.ToString());
                    //si no tiene etapa registrará error
                    try
                    {
                        bsEtapaProceso.DataSource = Program.frmPrincipal.servicioWeb.getEstadoProceso("ID_EstadoProceso", Program.frmPrincipal.servicioWeb.getEtapa("ID_Asunto", asuntoSeleccionado.ID_Asunto.ToString())[0].ID_EstadoProceso.ToString());
                    }
                    catch
                    {
                        txtEtapa.Text = "Etapa no definida";
                    }
                    bsAutoridad.DataSource = Program.frmPrincipal.servicioWeb.getAutoridad("ID_Autoridad", asuntoSeleccionado.ID_Autoridad.ToString());
                   }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ":" + ex.TargetSite + ":" + ex.Source);
                }
            }

        }

        private void frmAbogados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void gbAsunto_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerAsunto_Click(object sender, EventArgs e)
        {
            if (Program.frmPrincipal.frmAsunto == null || Program.frmPrincipal.frmAsunto.IsDisposed)
                Program.frmPrincipal.frmAsunto = new frmAsunto(asuntoSeleccionado);
            Program.frmPrincipal.frmAsunto.Show();
        }

        public void Editar()
        {
            //activación de controles

        }

        public void Guardar()
        {
            
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue == 46))
            {
            }
            else
            {
                MessageBox.Show("Solo números", "Error");
                txtTelefono.Text = "";
                txtTelefono.Focus();
            }
        }

        private void txtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue == 46))
            {
            }
            else
            {
                MessageBox.Show("Solo números", "Error");
                txtCelular.Text = "";
                txtCelular.Focus();
            }
        }
    }
}
