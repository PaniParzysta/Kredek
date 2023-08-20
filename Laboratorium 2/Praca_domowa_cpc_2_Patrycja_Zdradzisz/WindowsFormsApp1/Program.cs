using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static bool Logged;
        public static string User;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            if (Logged)
                Application.Run(new FormProgram());

        }
    }
}
