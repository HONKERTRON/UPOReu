using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPOReu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Zastavka first = new Zastavka();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            first.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();

            

            Application.Run(new FormAuth());
        }
    }
}
