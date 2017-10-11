using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Microsoft.Win32;
using System.Resources;

namespace USBFence
{
    public partial class Form1 : Form
    {
        static string path1 = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\inf\Usbstor.pnf");
        static string path2 = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\inf\Usbstor.inf");
        private bool status;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            check_status(path1, path2);
        }

        //Если нет обоих файлов - отключен return false. Если есть оба return true. Если только один - выключить второй и return false
        private void check_status(string p1, string p2)
        {
            if (!File.Exists(p1) && !File.Exists(p2))
            {
                status = false;
                set_UI();
                //Добавить если только один - выключить второй и return false
            }
            else if (File.Exists(p1) && File.Exists(p2))
            {
                status = true;
                set_UI();
            }
        }

        //Изменить текст и кнопки приложения в зависимости от статуса
        private void set_UI()
        {
            if (status == true)
            {
                menu_status.Text = "Дозволено";
                menu_status.Image = Properties.Resources.bt_status_1;
                gb_3.Text = "3. Заблокувати USB порти";
                lb_3_1.Text = "Зараз USB порти розблоковано. Натисніть, щоб заблокувати.";
                pb_lock.Visible = true;
                pb_unlock.Visible = false;
            }
            else
            {
                menu_status.Text = "Заборонено";
                menu_status.Image = Properties.Resources.bt_status_0;
                gb_3.Text = "3. Розблокувати USB порти";
                lb_3_1.Text = "Зараз USB порти заблоковано. Натисніть, щоб розблокувати.";
                pb_lock.Visible = false;
                pb_unlock.Visible = true;
            }
        }

        private void pb_clear_MouseEnter(object sender, EventArgs e)
        {
            pb_clear.Image = Properties.Resources.bt_clear_hover;
        }

        private void pb_clear_MouseLeave(object sender, EventArgs e)
        {
            pb_clear.Image = Properties.Resources.bt_clear;
        }

        private void pb_lock_MouseEnter(object sender, EventArgs e)
        {
            pb_lock.Image = Properties.Resources.bt_lock_hover;
        }

        private void pb_lock_MouseLeave(object sender, EventArgs e)
        {
            pb_lock.Image = Properties.Resources.bt_lock;
        }

        private void pb_unlock_MouseEnter(object sender, EventArgs e)
        {
            pb_unlock.Image = Properties.Resources.bt_unlock_hover;
        }

        private void pb_unlock_MouseLeave(object sender, EventArgs e)
        {
            pb_unlock.Image = Properties.Resources.bt_unlock;
        }

        private void pb_clear_Click(object sender, EventArgs e)
        {
            string[] keys = {
                                "SYSTEM\\ControlSet001\\Control\\DeviceClasses\\{53f56307-b6bf-11d0-94f2-00a0c91efb8b}",
                                "SYSTEM\\ControlSet002\\Control\\DeviceClasses\\{53f56307-b6bf-11d0-94f2-00a0c91efb8b}",
                                "SYSTEM\\CurrentControlSet\\Control\\DeviceClasses\\{53f56307-b6bf-11d0-94f2-00a0c91efb8b}",
                                "SYSTEM\\CurrentControlSet\\Enum\\USBSTOR",
                                "SYSTEM\\ControlSet001\\Enum\\USBSTOR",
                                "SYSTEM\\ControlSet002\\Enum\\USBSTOR"
                            };
            RegistryKey reg;

            foreach (string k in keys)
            {
                try
                {
                    reg = Registry.CurrentUser.OpenSubKey(k, true);
                    if (reg != null)
                    {
                        foreach (string name in reg.GetSubKeyNames())
                        {
                            if (k.Contains("Enum") && !name.StartsWith("Disk"))
                            {
                                continue;
                            }
                            reg.DeleteSubKeyTree(name, true);
                            //Вести лог удаленных разделов реестра
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("catch");
                }
                finally
                {
                    MessageBox.Show("finally");
                }
            }
        }

        private void pb_lock_Click(object sender, EventArgs e)
        {
            status = false;
            set_UI();
        }

        private void pb_unlock_Click(object sender, EventArgs e)
        {
            status = true;
            set_UI();
        }
    }
}