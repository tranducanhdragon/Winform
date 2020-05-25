using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
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
            Form_loginfacebook f_facebook = new Form_loginfacebook();
            if (f_facebook.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new DangKy());
            }

        }
    }
}
