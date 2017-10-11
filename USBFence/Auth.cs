using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USBFence
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "123")
            {
                lb_status.Visible = false;
                tb_password.Clear();
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                lb_status.Visible = true;
                tb_password.Clear();
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_ok_Click(sender, e);
            }
        }
    }
}