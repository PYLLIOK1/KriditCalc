using System;
using System.Windows.Forms;

namespace KriditCalc
{
    static class Program
    {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new One());
            Application.Run(Context);
        }
    }
}
