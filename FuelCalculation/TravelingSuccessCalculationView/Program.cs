using System;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //String[] arguments = Environment.GetCommandLineArgs();
            Application.Run(new TransportListForm(args));
        }
    }
}
