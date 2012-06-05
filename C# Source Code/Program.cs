using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ProyectoFinal
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static sistema.Abogados sesionAbogado;
        public static frmPrincipal frmPrincipal;
    
        [STAThread]     

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmPrincipal = new frmPrincipal());       
           
                
        }
    }
}
