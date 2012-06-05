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
    public partial class frmNuevaAutoridad : frmAlta
    {
        public frmNuevaAutoridad()
        {
            InitializeComponent();
        }

        private void frmNuevaAutoridad_Load(object sender, EventArgs e)
        {
            
        }

        protected override void Guardar()
        {
            try
            {
                string respuesta = Program.frmPrincipal.servicioWeb.addAutoridad(txtNombre.Text, txtDireccion.Text, txtTelefono.Text);
                MessageBox.Show(respuesta);
                Program.frmPrincipal.tsStatus.Text = respuesta;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
