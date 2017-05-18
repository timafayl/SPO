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
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TransportListForm(args));
            }
            catch (Exception)
            {
                MessageBox.Show("В проргамме произошла непредвиденная ошибка. Программа требует " +
                                "аварийного завершения. Извините за доставленные неудобства.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
