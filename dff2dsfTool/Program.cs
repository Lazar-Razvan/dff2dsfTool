using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dff2dsfTool
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
            Application.Run(new dff2dsfToolForm());
        }
    }
}
