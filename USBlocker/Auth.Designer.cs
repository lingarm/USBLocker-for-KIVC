namespace USBlocker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 175);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.bt_ok);
            this.panel1.Location = new System.Drawing.Point(167, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 175);
            this.panel1.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Culture = new System.Globalization.CultureInfo("en-001");
            this.tb_password.Location = new System.Drawing.Point(23, 56);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '✘';
            this.tb_password.Size = new System.Drawing.Size(241, 20);
            this.tb_password.TabIndex = 0;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.Crimson;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_status.ForeColor = System.Drawing.Color.Transparent;
            this.lb_status.Location = new System.Drawing.Point(115, 14);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(141, 16);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Пароль не принят";
            this.lb_status.Visible = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(158, 104);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(96, 40);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Выход";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_password.Location = new System.Drawing.Point(23, 17);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(91, 13);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Введите пароль:";
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(39, 104);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(96, 40);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.Text = "USB Locker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.MaskedTextBox tb_password;
    }
}