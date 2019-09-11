using System;
using System.Windows.Forms;
using PerformanceMonitorV2.Management.Concrete;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.Forms;

namespace PerformanceMonitorV2.WindowsFormsUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new DataManager().SetSources();
            new FormManager().Intro(new IntroDashboard(), new CompactDashboard());
            Application.Run();
        }
    }
}
