using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//HECHO POR TOMAS AGUSTIN FRIZ
namespace Cibercafe_ElVicio
{
    //HECHO POR TOMAS AGUSTIN FRIZ
    static class Program
    {
        //HECHO POR TOMAS AGUSTIN FRIZ
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //HECHO POR TOMAS AGUSTIN FRIZ
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
