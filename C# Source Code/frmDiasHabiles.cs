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
    public partial class frmDiasHabiles : Form
    {
        sistema.DiaNoHabil[] diasNoHabiles;
        public frmDiasHabiles()
        {
            InitializeComponent();
            //obtengo los dias no habiles
            diasNoHabiles = Program.frmPrincipal.servicioWeb.getDiaNoHabil("", "");
            this.MdiParent = Program.frmPrincipal;
        }

        private void frmDiasHabiles_Load(object sender, EventArgs e)
        {
            try
            {
                cbAño.Select();
                //aplico filtro de año
                cbAño.Items.Add(DateTime.Today.Year.ToString());
                bsDiaNoHabil.DataSource = diasNoHabiles;
                //busco todos los años registrados en los dias inhabiles para llenar el combobox con años válidos
                foreach (sistema.DiaNoHabil dia in diasNoHabiles)
                {
                    if (cbAño.Items.IndexOf(dia.Dia.Year.ToString()) == -1)
                        cbAño.Items.Add(dia.Dia.Year.ToString());
                }

                ordenarDiasPorAno(DateTime.Today.Year.ToString());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ordenarDiasPorAno(string ano)
        {
            if (cbAño.SelectedItem != null)
            {
                try
                {
                    //filtro los dias inhabiles por el año seleccionado en el combobox
                    diasNoHabiles = Program.frmPrincipal.servicioWeb.getDiaNoHabil("Year", cbAño.SelectedItem.ToString());
                    bsDiaNoHabil.DataSource = diasNoHabiles;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        //función para checar si existe un dia inhabil dado de alta en el sistema
        public bool checarSiExiste(DateTime dia)
        {
            bool existe = false;
            foreach( sistema.DiaNoHabil Dia in diasNoHabiles)
            {
                if (Dia.Dia == dia)
                    existe = true;
            }
            return existe;
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            ordenarDiasPorAno(cbAño.SelectedItem.ToString());
        }

        private void dtpInhabiles_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                //valido que el dia que agregó no sea sabado ni domingo
                if (dtpInhabiles.Value.DayOfWeek == DayOfWeek.Saturday || dtpInhabiles.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Los días sábados y domingos no se trabajan.");
                }
                else
                {
                    if (checarSiExiste(dtpInhabiles.Value) == false)
                    {
                        MessageBox.Show(Program.frmPrincipal.servicioWeb.addDiaNoHabil(dtpInhabiles.Value));
                        ordenarDiasPorAno(cbAño.SelectedItem.ToString());
                    }
                    else
                        MessageBox.Show("Ese dia ya ha sido agregado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar la fecha?","Advertencia",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
            {               
                MessageBox.Show(Program.frmPrincipal.servicioWeb.deleteDiaNoHabil(lbDiasInhabiles.SelectedValue.ToString()));
                ordenarDiasPorAno(cbAño.SelectedItem.ToString());
            }
        }

        private void gbDiasNoHabiles_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
