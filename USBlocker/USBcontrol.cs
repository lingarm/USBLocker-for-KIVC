using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
//using Microsoft.Win32;

namespace USBlocker
{
    public partial class USBcontrol : Form
    {
        static string path1 = @"C:\Windows\1\Usbstor.pnf";
        static string path2 = @"C:\Windows\1\Usbstor.inf";
        private bool status;

        public USBcontrol()
        {
            InitializeComponent();
            check_status(path1, path2);
        }

        /*Если нет обоих файлов - отключен return false. Если есть оба return true. Если только один - віключить второй и return false*/
        private void check_status(string p1, string p2)
        {
            if (!File.Exists(p1) && !File.Exists(p2))
            {
                menu_status.Text = "Заборонено";
                menu_status.Image = Image.FromFile(@"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_status_0.png");
                status = false;
                //Добавить если только один - выключить второй и return false
            }
            else if (File.Exists(p1) && File.Exists(p2))
            {
                menu_status.Text = "Дозволено";
                menu_status.Image = Image.FromFile(@"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_status_1.png");
                status = true;
            }
        }

        private void pb_clear_MouseEnter(object sender, EventArgs e)
        {
            pb_clear.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_clear_hover.png";
        }

        private void pb_clear_MouseLeave(object sender, EventArgs e)
        {
            pb_clear.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_clear.png";
        }

        private void pb_clear_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pb_lock_MouseEnter(object sender, EventArgs e)
        {
            pb_lock.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_lock_hover.png";
        }

        private void pb_lock_MouseLeave(object sender, EventArgs e)
        {
            pb_lock.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_lock.png";
        }

        private void pb_lock_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pb_unlock_MouseEnter(object sender, EventArgs e)
        {
            pb_unlock.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_unlock_hover.png";
        }

        private void pb_unlock_MouseLeave(object sender, EventArgs e)
        {
            pb_unlock.ImageLocation = @"C:\Users\Sunny\Documents\Visual Studio 2010\Projects\USBlocker\USBlocker\bt_unlock.png";
        }
    }
}