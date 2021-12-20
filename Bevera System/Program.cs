using System;
using System.Windows.Forms;

namespace Bevera_System
{
    static class Program
    {
		public static LoginForm lf;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			lf = new LoginForm();
            Application.Run(lf);
			
        }
    }
}
