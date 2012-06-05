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
    public partial class frmAlta : Form
    {
        
        public frmAlta()
        {
            InitializeComponent();
            this.MdiParent = Program.frmPrincipal;
        }

        public void frmAlta_Load(object sender, EventArgs e)
        {

        }

        public void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void tsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void tsbCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        //metodo para guardar que debe ser override en la otra forma

        protected virtual void Guardar()
        {

        }


        protected virtual void Limpiar()
        {
        }

        public void Salir()
        {
            if (MessageBox.Show("¿Está usted seguro que desea cancelar", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
