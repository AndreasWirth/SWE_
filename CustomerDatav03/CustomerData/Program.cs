using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Application.Run(new FillLanguageDAtaset());

            /*
            // Reopen Main window, for Language change
            Main main;
            do
            {
                main = new Main();
            } while (DialogResult.OK == main.ShowDialog());
            */
        }
    }
}
