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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MdiParent = Program.frmPrincipal;
            txtEmail.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.frmPrincipal.servicioWeb.login(txtEmail.Text, txtPassword.Text) == true) //login valido
                {
                    Program.sesionAbogado = Program.frmPrincipal.servicioWeb.getAbogados("EmailLogin", txtEmail.Text)[0];
                    Program.frmPrincipal.activarMenu();
                    Program.frmPrincipal.tsStatus.Text = "Sesión iniciada como " + Program.sesionAbogado.Nombre; 
                    this.Close();
                   /* if (Program.frmPrincipal.frmInicio == null || Program.frmPrincipal.frmInicio.IsDisposed)
                        Program.frmPrincipal.frmInicio = new frmInicio();
                    Program.frmPrincipal.frmInicio.Show();*/
                }
                else
                {
                    MessageBox.Show("Usuario No valido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

    }
}
