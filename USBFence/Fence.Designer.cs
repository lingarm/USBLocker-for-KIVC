﻿namespace USBFence
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_1_1 = new System.Windows.Forms.GroupBox();
            this.lb_1_3 = new System.Windows.Forms.Label();
            this.lb_1_2 = new System.Windows.Forms.Label();
            this.pb_clear = new System.Windows.Forms.PictureBox();
            this.lb_1_4 = new System.Windows.Forms.Label();
            this.lb_1_1 = new System.Windows.Forms.Label();
            this.lb_2_3 = new System.Windows.Forms.Label();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.pb_unlock = new System.Windows.Forms.PictureBox();
            this.pb_lock = new System.Windows.Forms.PictureBox();
            this.lb_3_1 = new System.Windows.Forms.Label();
            this.lb_2_2 = new System.Windows.Forms.Label();
            this.lb_2_1 = new System.Windows.Forms.Label();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu_about = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_developer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_status_text = new System.Windows.Forms.ToolStripLabel();
            this.menu_status = new System.Windows.Forms.ToolStripLabel();
            this.gb_1_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clear)).BeginInit();
            this.gb_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lock)).BeginInit();
            this.menu_tray.SuspendLayout();
            this.gb_2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_1_1
            // 
            this.gb_1_1.BackColor = System.Drawing.Color.Transparent;
            this.gb_1_1.Controls.Add(this.lb_1_3);
            this.gb_1_1.Controls.Add(this.lb_1_2);
            this.gb_1_1.Controls.Add(this.pb_clear);
            this.gb_1_1.Controls.Add(this.lb_1_4);
            this.gb_1_1.Controls.Add(this.lb_1_1);
            this.gb_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_1_1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_1_1.Location = new System.Drawing.Point(21, 43);
            this.gb_1_1.Name = "gb_1_1";
            this.gb_1_1.Size = new System.Drawing.Size(474, 105);
            this.gb_1_1.TabIndex = 15;
            this.gb_1_1.TabStop = false;
            this.gb_1_1.Text = "1. Видалити встановлені USB пристрої";
            // 
            // lb_1_3
            // 
            this.lb_1_3.AutoEllipsis = true;
            this.lb_1_3.AutoSize = true;
            this.lb_1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_1_3.Location = new System.Drawing.Point(9, 57);
            this.lb_1_3.Name = "lb_1_3";
            this.lb_1_3.Size = new System.Drawing.Size(287, 13);
            this.lb_1_3.TabIndex = 0;
            this.lb_1_3.Text = "буде втрачено, та відновлено після перезавантаження.";
            // 
            // lb_1_2
            // 
            this.lb_1_2.AutoEllipsis = true;
            this.lb_1_2.AutoSize = true;
            this.lb_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_1_2.Location = new System.Drawing.Point(9, 39);
            this.lb_1_2.Name = "lb_1_2";
            this.lb_1_2.Size = new System.Drawing.Size(333, 13);
            this.lb_1_2.TabIndex = 0;
            this.lb_1_2.Text = "Якщо ви маєте USB мишу або клавіатуру, керування тимчасово";
            // 
            // pb_clear
            // 
            this.pb_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_clear.Image = ((System.Drawing.Image)(resources.GetObject("pb_clear.Image")));
            this.pb_clear.Location = new System.Drawing.Point(358, 17);
            this.pb_clear.Name = "pb_clear";
            this.pb_clear.Size = new System.Drawing.Size(110, 73);
            this.pb_clear.TabIndex = 1;
            this.pb_clear.TabStop = false;
            this.pb_clear.Click += new System.EventHandler(this.pb_clear_Click);
            this.pb_clear.MouseEnter += new System.EventHandler(this.pb_clear_MouseEnter);
            this.pb_clear.MouseLeave += new System.EventHandler(this.pb_clear_MouseLeave);
            // 
            // lb_1_4
            // 
            this.lb_1_4.AutoSize = true;
            this.lb_1_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_1_4.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_1_4.Location = new System.Drawing.Point(9, 77);
            this.lb_1_4.Name = "lb_1_4";
            this.lb_1_4.Size = new System.Drawing.Size(252, 13);
            this.lb_1_4.TabIndex = 0;
            this.lb_1_4.Text = "Комп\'ютер буде автоматично перезавантажено.";
            // 
            // lb_1_1
            // 
            this.lb_1_1.AutoEllipsis = true;
            this.lb_1_1.AutoSize = true;
            this.lb_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_1_1.Location = new System.Drawing.Point(9, 21);
            this.lb_1_1.Name = "lb_1_1";
            this.lb_1_1.Size = new System.Drawing.Size(343, 13);
            this.lb_1_1.TabIndex = 0;
            this.lb_1_1.Text = "Закрийте інші програми та файли. Відключіть зайві USB пристрої. ";
            // 
            // lb_2_3
            // 
            this.lb_2_3.AutoSize = true;
            this.lb_2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_2_3.Location = new System.Drawing.Point(7, 56);
            this.lb_2_3.Name = "lb_2_3";
            this.lb_2_3.Size = new System.Drawing.Size(246, 13);
            this.lb_2_3.TabIndex = 0;
            this.lb_2_3.Text = "Перевірте працездатність потрібних пристроїв.";
            // 
            // gb_3
            // 
            this.gb_3.BackColor = System.Drawing.Color.Transparent;
            this.gb_3.Controls.Add(this.pb_unlock);
            this.gb_3.Controls.Add(this.pb_lock);
            this.gb_3.Controls.Add(this.lb_3_1);
            this.gb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_3.Location = new System.Drawing.Point(21, 265);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(474, 105);
            this.gb_3.TabIndex = 16;
            this.gb_3.TabStop = false;
            this.gb_3.Text = "3. Заблокувати USB порти";
            // 
            // pb_unlock
            // 
            this.pb_unlock.Image = ((System.Drawing.Image)(resources.GetObject("pb_unlock.Image")));
            this.pb_unlock.Location = new System.Drawing.Point(358, 19);
            this.pb_unlock.Name = "pb_unlock";
            this.pb_unlock.Size = new System.Drawing.Size(109, 73);
            this.pb_unlock.TabIndex = 2;
            this.pb_unlock.TabStop = false;
            this.pb_unlock.Click += new System.EventHandler(this.pb_unlock_Click);
            this.pb_unlock.MouseEnter += new System.EventHandler(this.pb_unlock_MouseEnter);
            this.pb_unlock.MouseLeave += new System.EventHandler(this.pb_unlock_MouseLeave);
            // 
            // pb_lock
            // 
            this.pb_lock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_lock.Image = ((System.Drawing.Image)(resources.GetObject("pb_lock.Image")));
            this.pb_lock.Location = new System.Drawing.Point(358, 19);
            this.pb_lock.Name = "pb_lock";
            this.pb_lock.Size = new System.Drawing.Size(110, 73);
            this.pb_lock.TabIndex = 1;
            this.pb_lock.TabStop = false;
            this.pb_lock.Click += new System.EventHandler(this.pb_lock_Click);
            this.pb_lock.MouseEnter += new System.EventHandler(this.pb_lock_MouseEnter);
            this.pb_lock.MouseLeave += new System.EventHandler(this.pb_lock_MouseLeave);
            // 
            // lb_3_1
            // 
            this.lb_3_1.AutoSize = true;
            this.lb_3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_3_1.Location = new System.Drawing.Point(9, 25);
            this.lb_3_1.Name = "lb_3_1";
            this.lb_3_1.Size = new System.Drawing.Size(323, 13);
            this.lb_3_1.TabIndex = 0;
            this.lb_3_1.Text = "Зараз USB порти розблоковано. Натисніть, щоб заблокувати.";
            // 
            // lb_2_2
            // 
            this.lb_2_2.AutoSize = true;
            this.lb_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_2_2.Location = new System.Drawing.Point(7, 39);
            this.lb_2_2.Name = "lb_2_2";
            this.lb_2_2.Size = new System.Drawing.Size(329, 13);
            this.lb_2_2.TabIndex = 0;
            this.lb_2_2.Text = "Зачекайте, доки система їх розпізнає та встановить драйвери.";
            // 
            // lb_2_1
            // 
            this.lb_2_1.AutoSize = true;
            this.lb_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_2_1.Location = new System.Drawing.Point(7, 22);
            this.lb_2_1.Name = "lb_2_1";
            this.lb_2_1.Size = new System.Drawing.Size(259, 13);
            this.lb_2_1.TabIndex = 0;
            this.lb_2_1.Text = "Вставте USB пристрої, які потрібні користувачеві.";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // menu_tray
            // 
            this.menu_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menu_tray.Name = "menu_tray";
            this.menu_tray.Size = new System.Drawing.Size(117, 48);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.menu_tray;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Контроль USB пристроїв";
            this.tray.Visible = true;
            // 
            // gb_2
            // 
            this.gb_2.BackColor = System.Drawing.Color.Transparent;
            this.gb_2.Controls.Add(this.lb_2_3);
            this.gb_2.Controls.Add(this.lb_2_2);
            this.gb_2.Controls.Add(this.lb_2_1);
            this.gb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_2.Location = new System.Drawing.Point(21, 165);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(474, 83);
            this.gb_2.TabIndex = 14;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "2. Встановити дозволені USB пристрої";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_about,
            this.toolStripSeparator1,
            this.menu_developer,
            this.toolStripSeparator2,
            this.menu_status_text,
            this.menu_status});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(517, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_about
            // 
            this.menu_about.Image = ((System.Drawing.Image)(resources.GetObject("menu_about.Image")));
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(65, 22);
            this.menu_about.Text = "Довідка";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_developer
            // 
            this.menu_developer.Name = "menu_developer";
            this.menu_developer.Size = new System.Drawing.Size(67, 22);
            this.menu_developer.Text = "Розробник";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_status_text
            // 
            this.menu_status_text.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.menu_status_text.Name = "menu_status_text";
            this.menu_status_text.Size = new System.Drawing.Size(108, 22);
            this.menu_status_text.Text = "Статус USB портів:";
            // 
            // menu_status
            // 
            this.menu_status.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_status.Image = ((System.Drawing.Image)(resources.GetObject("menu_status.Image")));
            this.menu_status.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.menu_status.Name = "menu_status";
            this.menu_status.Size = new System.Drawing.Size(92, 22);
            this.menu_status.Text = "Дозволено";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::USBFence.Properties.Resources.bg_fence;
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.gb_1_1);
            this.Controls.Add(this.gb_3);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_1_1.ResumeLayout(false);
            this.gb_1_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clear)).EndInit();
            this.gb_3.ResumeLayout(false);
            this.gb_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lock)).EndInit();
            this.menu_tray.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            this.gb_2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1_1;
        private System.Windows.Forms.Label lb_1_3;
        private System.Windows.Forms.Label lb_1_2;
        private System.Windows.Forms.PictureBox pb_clear;
        private System.Windows.Forms.Label lb_1_4;
        private System.Windows.Forms.Label lb_1_1;
        private System.Windows.Forms.Label lb_2_3;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.PictureBox pb_unlock;
        private System.Windows.Forms.PictureBox pb_lock;
        private System.Windows.Forms.Label lb_3_1;
        private System.Windows.Forms.Label lb_2_2;
        private System.Windows.Forms.Label lb_2_1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menu_tray;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.ToolStripLabel menu_status;
        private System.Windows.Forms.ToolStripLabel menu_status_text;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel menu_about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel menu_developer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

