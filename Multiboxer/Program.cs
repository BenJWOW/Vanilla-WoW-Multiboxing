using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Multiboxer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string exeName = "ScaleFix.exe";
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, exeName);
            Process.Start(exePath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
