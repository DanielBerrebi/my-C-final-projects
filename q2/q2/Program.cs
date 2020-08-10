using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q2
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
            string username="";
            //forcing the user to enter username to continue
            while (username == "")
            {
                using (FormLogin login = new FormLogin())
                {
                    if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        username = login.getUsername();
                    }
                }
            }
            //opening the main menu form
            Application.Run(new FormMainMenu(username));
        }
    }
}
