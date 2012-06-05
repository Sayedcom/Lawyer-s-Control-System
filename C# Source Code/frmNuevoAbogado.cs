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
    public partial class frmNuevoAbogado : frmAlta
    {
        public frmNuevoAbogado()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
        }

        private void frmNuevoAbogado_Load(object sender, EventArgs e)
        {
            dtpFechaN.Value = DateTime.Now.Date;
            dtpFechaN.MaxDate = DateTime.Now.Date;
        }

        private void pnlSugerencias_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void Limpiar()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
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
                    
                    DateTime fecha = new DateTime(dtpFechaN.Value.Year, dtpFechaN.Value.Month, dtpFechaN.Value.Day);
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.addAbogados(txtNombre.Text, txtEmail.Text, txtPassword.Text, fecha, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, txtNextel.Text,false));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ocurrió un error");
            }
           
        }

      


    }
}
