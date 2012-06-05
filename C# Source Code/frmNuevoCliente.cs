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
    public partial class frmNuevoCliente : frmAlta
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
        }


        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void gbAbogado_Enter(object sender, EventArgs e)
        {

        }

        protected override void Limpiar()
        {
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtNextel.Text = "";
            txtCelular.Text = "";
            txtTelefono.Text = "";

        }

        protected override void Guardar()
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
                    DateTime fecha = new DateTime(dtpFechaN.Value.Year, dtpFechaN.Value.Month, dtpFechaN.Value.Day);
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.addCliente(txtNombre.Text, txtEmail.Text,fecha, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, txtNextel.Text));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ocurrió un error");
            }

        }
    }
}
