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
    public partial class frmNuevaEtapa : frmAlta
    {
        int ID_Asunto;
        public frmNuevaEtapa(int ID_Asunto)
        {
            InitializeComponent();
            this.ID_Asunto = ID_Asunto;
            //solo cargan las etapas que faltan de completar
            //select * from Estado_Proceso e where e.ID_EstadoProceso not in (Select ID_EstadoProceso FROM Etapa Where ID_Asunto = ID_Asunto )
            bsEstadoProceso.DataSource = Program.frmPrincipal.servicioWeb.getEstadoProceso("ID_Asunto",ID_Asunto.ToString());
            this.MdiParent = Program.frmPrincipal;
            txtID_Asunto.Text = ID_Asunto.ToString();
            dtpFechaInicio.Value = DateTime.Today;
        }

        private void frmNuevaEtapa_Load(object sender, EventArgs e)
        {
            
        }

        protected override void Guardar()
        {
            try
            {
            if (cbEstadoProceso.SelectedValue != null)
            {
                MessageBox.Show(Program.frmPrincipal.servicioWeb.addEtapa(ID_Asunto, dtpFechaInicio.Value, txtDescripcion.Text, (int)cbEstadoProceso.SelectedValue));
                this.Close();
            }
            else
            {
                MessageBox.Show("Elija una etapa procesal antes de continuar");
            }
            }
            catch(Exception ex)
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
