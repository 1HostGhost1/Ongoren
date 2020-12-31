using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ongoren
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
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            var value = reg.GetValue("OngorenDesktopApp")?.ToString();
            var appPath = Application.ExecutablePath.ToString();
            if (value != appPath)
                reg.SetValue("OngorenDesktopApp", Application.ExecutablePath.ToString());
            Application.Run(new Form1());
        }
    }
}
