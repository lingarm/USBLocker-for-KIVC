namespace USBFence
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.pn_auth = new System.Windows.Forms.Panel();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.pb_ = new System.Windows.Forms.PictureBox();
            this.pn_auth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_auth
            // 
            this.pn_auth.BackColor = System.Drawing.Color.Transparent;
            this.pn_auth.Controls.Add(this.bt_close);
            this.pn_auth.Controls.Add(this.bt_ok);
            this.pn_auth.Controls.Add(this.tb_password);
            this.pn_auth.Controls.Add(this.lb_status);
            this.pn_auth.Controls.Add(this.lb_password);
            this.pn_auth.Location = new System.Drawing.Point(167, 24);
            this.pn_auth.Name = "pn_auth";
            this.pn_auth.Size = new System.Drawing.Size(269, 144);
            this.pn_auth.TabIndex = 0;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(153, 85);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(88, 43);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "Вихід";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(29, 85);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(88, 43);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(19, 50);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '✘';
            this.tb_password.Size = new System.Drawing.Size(232, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.Crimson;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_status.ForeColor = System.Drawing.Color.Transparent;
            this.lb_status.Location = new System.Drawing.Point(113, 17);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(138, 16);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "Пароль не вірний";
            this.lb_status.Visible = false;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(21, 19);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(87, 13);
            this.lb_password.TabIndex = 0;
            this.lb_password.Text = "Введіть пароль:";
            // 
            // pb_
            // 
            this.pb_.BackColor = System.Drawing.Color.Transparent;
            this.pb_.Image = global::USBFence.Properties.Resources.usb;
            this.pb_.Location = new System.Drawing.Point(33, 24);
            this.pb_.Name = "pb_";
            this.pb_.Size = new System.Drawing.Size(116, 144);
            this.pb_.TabIndex = 1;
            this.pb_.TabStop = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 193);
            this.Controls.Add(this.pb_);
            this.Controls.Add(this.pn_auth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.Text = "Form2";
            this.pn_auth.ResumeLayout(false);
            this.pn_auth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_auth;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.MaskedTextBox tb_password;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.PictureBox pb_;
    }
}