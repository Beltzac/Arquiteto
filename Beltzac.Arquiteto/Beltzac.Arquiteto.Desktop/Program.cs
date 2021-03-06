using Beltzac.Arquiteto.Infraestrutura.Externo;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beltzac.Arquiteto.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var api = RestService.For<IArquitetoAPI>("https://localhost:44340/");
            Application.Run(new Barracao(api));
        }
    }
}
