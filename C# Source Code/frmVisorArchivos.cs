using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ProyectoFinal
{
    public partial class frmVisorArchivos : Form
    {
        sistema.Asuntos Asunto;
        int ID_Etapa;
        sistema.Archivo[] Archivos;
        System.Net.WebClient Client;
        public frmVisorArchivos(sistema.Asuntos Asunto, int ID_Etapa)
        {
            InitializeComponent();
            this.Asunto = Asunto;
            this.ID_Etapa = ID_Etapa;
            cargarLista();
            Client = new System.Net.WebClient();
            this.MdiParent = Program.frmPrincipal;
       
        }

        private void frmVisorArchivos_Load(object sender, EventArgs e)
        {
            this.Text += "para la etapa " + ID_Etapa.ToString() + " del asunto " + Asunto.Nombre;
        }

        public void cargarLista()
        {
            try
            {
                lvVisor.Items.Clear();
                Archivos = Program.frmPrincipal.servicioWeb.getArchivo("ID_Etapa", ID_Etapa.ToString());
                if (Archivos != null)
                {
                    foreach (sistema.Archivo archivo in Archivos)
                    {
                        ListViewItem listItem = new ListViewItem(archivo.Nombre.ToString());
                        listItem.ImageIndex = 0;
                        string nombre = "";
                        string extension = "";
                        for (int i = 0; i < archivo.Nombre.IndexOf("."); i++)
                            nombre += archivo.Nombre[i];
                        for (int i = archivo.Nombre.IndexOf("."); i < archivo.Nombre.Length; i++)
                            extension += archivo.Nombre[i];

                        listItem.SubItems.Add(extension);
                        listItem.SubItems.Add(archivo.Tamano);
                        lvVisor.Items.Add(listItem);
                    }
                    lvVisor.View = View.Details;
                }
                else
                {
                    MessageBox.Show("No hay archivos para esta etapa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarArchivo()
        {
            try
            {
                this.Activate();
                tslblSubirArchivo.Visible = true;
                tspbSubirArchivo.Visible = true;
                tspbSubirArchivo.Minimum = 1;
                tspbSubirArchivo.Step = 1;

                string nombreArchivo = fdElegirArchivo.FileName.ToString();

                Client.UploadProgressChanged += new UploadProgressChangedEventHandler(Client_UploadProgressChanged);
               Client.UploadFileCompleted += new UploadFileCompletedEventHandler(Client_UploadFileCompleted);
                Client.Headers.Add("Content-Type", "binary/octet-stream");
                Uri url = new Uri("http://www.vgcorporativo.com/sistema/upload.php");
                //byte[] result = Client.UploadFileAsync(url, "POST", fdElegirArchivo.FileName);
                Client.UploadFileAsync(url, "POST", fdElegirArchivo.FileName);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Client_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            tspbSubirArchivo.PerformStep();
            tslblSubirArchivo.Text = "Completado: " + e.ProgressPercentage;
  
        }

        void Client_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            tslblSubirArchivo.Text = "Archivo subido!";
            tspbSubirArchivo.Visible = false;
            try
            {
                Program.frmPrincipal.servicioWeb.addArchivo(ID_Etapa, Asunto.ID_Asunto, "Archivo", fdElegirArchivo.SafeFileName, "", (new FileInfo(fdElegirArchivo.FileName)).Length.ToString());
                cargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void fdElegirArchivo_FileOk(object sender,
        System.ComponentModel.CancelEventArgs e)
        {
            cargarArchivo();
        }
        
        private void tsbCargar_Click(object sender, EventArgs e)
        {
            fdElegirArchivo.ShowDialog();
        }

        private void lvVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsmiEliminar.Visible = true;
            tsbDescargarArchivo.Visible = true;

        }

        private void tsmiEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el archivo?", "Advertencia", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                   MessageBox.Show( Program.frmPrincipal.servicioWeb.deleteArchivo(lvVisor.SelectedItems[0].Text));
                   tslblSubirArchivo.Text = "Archivo Eliminado.";
                   cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsbDescargarArchivo_Click(object sender, EventArgs e)
        {
            //fdGuardarRuta.DefaultExt = lvVisor.SelectedItems[0].SubItems[0].Text;
            if (fbdGuardarRuta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.Activate();
                    tslblSubirArchivo.Visible = true;
                    tspbSubirArchivo.Visible = true;
                    tspbSubirArchivo.Minimum = 1;
                    tspbSubirArchivo.Step = 1;
                    Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                    Client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                    Uri direccionDescarga = new Uri("http://www.vgcorporativo.com/sistema/download.php?archivo=" + lvVisor.SelectedItems[0].Text);
                    Client.DownloadFileAsync(direccionDescarga, fbdGuardarRuta.SelectedPath + "//" + lvVisor.SelectedItems[0].SubItems[0].Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            tspbSubirArchivo.Visible = false;
            tslblSubirArchivo.Text = "Archivo Descargado en: " + fbdGuardarRuta.SelectedPath; 
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            tspbSubirArchivo.PerformStep();
            tslblSubirArchivo.Text = "Descargando: " + e.ProgressPercentage;
        }


    }
}
