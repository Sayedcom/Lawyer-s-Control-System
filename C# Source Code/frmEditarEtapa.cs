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
    public partial class frmEditarEtapa : frmAlta
    {
        int ID_Etapa;
        public frmEditarEtapa(int ID_Etapa)
        {
            InitializeComponent();
            try
            {
                this.ID_Etapa = ID_Etapa;
                sistema.Etapa Etapa = Program.frmPrincipal.servicioWeb.getEtapa("ID_Etapa", ID_Etapa.ToString())[0];
                //solo cargan las etapas que faltan de completar
                //select * from Estado_Proceso e where e.ID_EstadoProceso not in (Select ID_EstadoProceso FROM Etapa Where ID_Asunto = ID_Asunto )
                bsEstadoProceso.DataSource = Program.frmPrincipal.servicioWeb.getEstadoProceso("ID_Asunto", Etapa.ID_Asunto.ToString());
                this.MdiParent = Program.frmPrincipal;
                txtID_Asunto.Text = Etapa.ID_Asunto.ToString();
                txtDescripcion.Text = Etapa.Descripcion;
                dtpFechaInicio.Value = Etapa.Fecha_Inicio;
                cbEstadoProceso.SelectedValue = Etapa.ID_EstadoProceso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEditarEtapa_Load(object sender, EventArgs e)
        {

        }


        protected override void Guardar()
        {
            try
            {
                if (cbEstadoProceso.SelectedValue != null)
                {
                    MessageBox.Show(Program.frmPrincipal.servicioWeb.updateEtapa(ID_Etapa, int.Parse(txtID_Asunto.Text), dtpFechaInicio.Value, txtDescripcion.Text, (int)cbEstadoProceso.SelectedValue));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Elija una etapa procesal antes de continuar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void Limpiar()
        {
            txtDescripcion.Text = "";


        }
    }
}
