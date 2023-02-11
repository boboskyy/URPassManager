using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPassManager
{
    internal static class Program
    {
        public static Neurotec.Biometrics.Nffv Engine = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Engine = new Neurotec.Biometrics.Nffv("database\\FingerprintDB.CSharpSample.dat", "", "Futronic");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(Engine.Users.Count > 0)
            {
                Application.Run(new LoginForm());
            }
            else { Application.Run(new RegisterForm()); }
        }
    }
}
