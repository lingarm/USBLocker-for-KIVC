using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace USBFence
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 fence = new Form1();
            Auth auth = new Auth();
            DialogResult res = auth.ShowDialog();
            if (res == DialogResult.Yes)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
