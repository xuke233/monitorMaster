namespace twpx
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.监控管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.监控管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页面监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.多窗口监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.电子地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一键报警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Window;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(177, 175);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(621, 28);
            label1.TabIndex = 2;
            label1.Text = "欢迎来到杭州电子科技大学智慧实验室监控系统\r\n";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.监控管理ToolStripMenuItem,
            this.电子地图ToolStripMenuItem,
            this.一键报警ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem1,
            this.设备管理ToolStripMenuItem1,
            this.监控管理ToolStripMenuItem1});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "管理系统";
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.刷新ToolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.用户管理ToolStripMenuItem1.Text = "用户管理";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem1.Text = "打开";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem1_Click);
            // 
            // 刷新ToolStripMenuItem1
            // 
            this.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1";
            this.刷新ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.刷新ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.刷新ToolStripMenuItem1.Text = "刷新";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 设备管理ToolStripMenuItem1
            // 
            this.设备管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem2,
            this.刷新ToolStripMenuItem2,
            this.退出ToolStripMenuItem1});
            this.设备管理ToolStripMenuItem1.Name = "设备管理ToolStripMenuItem1";
            this.设备管理ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.设备管理ToolStripMenuItem1.Text = "设备管理";
            // 
            // 打开ToolStripMenuItem2
            // 
            this.打开ToolStripMenuItem2.Name = "打开ToolStripMenuItem2";
            this.打开ToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.打开ToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.打开ToolStripMenuItem2.Text = "打开";
            this.打开ToolStripMenuItem2.Click += new System.EventHandler(this.打开ToolStripMenuItem2_Click);
            // 
            // 刷新ToolStripMenuItem2
            // 
            this.刷新ToolStripMenuItem2.Name = "刷新ToolStripMenuItem2";
            this.刷新ToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.刷新ToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.刷新ToolStripMenuItem2.Text = "刷新";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.退出ToolStripMenuItem1.Text = "退出";
            // 
            // 监控管理ToolStripMenuItem1
            // 
            this.监控管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem3,
            this.刷新ToolStripMenuItem3,
            this.退出ToolStripMenuItem2});
            this.监控管理ToolStripMenuItem1.Name = "监控管理ToolStripMenuItem1";
            this.监控管理ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.监控管理ToolStripMenuItem1.Text = "监控管理";
            // 
            // 打开ToolStripMenuItem3
            // 
            this.打开ToolStripMenuItem3.Name = "打开ToolStripMenuItem3";
            this.打开ToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D7)));
            this.打开ToolStripMenuItem3.Size = new System.Drawing.Size(164, 26);
            this.打开ToolStripMenuItem3.Text = "打开";
            // 
            // 刷新ToolStripMenuItem3
            // 
            this.刷新ToolStripMenuItem3.Name = "刷新ToolStripMenuItem3";
            this.刷新ToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D8)));
            this.刷新ToolStripMenuItem3.Size = new System.Drawing.Size(164, 26);
            this.刷新ToolStripMenuItem3.Text = "刷新";
            // 
            // 退出ToolStripMenuItem2
            // 
            this.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2";
            this.退出ToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D9)));
            this.退出ToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
            this.退出ToolStripMenuItem2.Text = "退出";
            // 
            // 监控管理ToolStripMenuItem
            // 
            this.监控管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页面监控ToolStripMenuItem,
            this.监控列表ToolStripMenuItem,
            this.多窗口监控ToolStripMenuItem});
            this.监控管理ToolStripMenuItem.Name = "监控管理ToolStripMenuItem";
            this.监控管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.监控管理ToolStripMenuItem.Text = "监控视图";
            // 
            // 主页面监控ToolStripMenuItem
            // 
            this.主页面监控ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem4,
            this.刷新ToolStripMenuItem4,
            this.返回ToolStripMenuItem});
            this.主页面监控ToolStripMenuItem.Name = "主页面监控ToolStripMenuItem";
            this.主页面监控ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.主页面监控ToolStripMenuItem.Text = "主页面监控";
            // 
            // 打开ToolStripMenuItem4
            // 
            this.打开ToolStripMenuItem4.Name = "打开ToolStripMenuItem4";
            this.打开ToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.打开ToolStripMenuItem4.Size = new System.Drawing.Size(171, 26);
            this.打开ToolStripMenuItem4.Text = "打开";
            this.打开ToolStripMenuItem4.Click += new System.EventHandler(this.打开ToolStripMenuItem4_Click);
            // 
            // 刷新ToolStripMenuItem4
            // 
            this.刷新ToolStripMenuItem4.Name = "刷新ToolStripMenuItem4";
            this.刷新ToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.刷新ToolStripMenuItem4.Size = new System.Drawing.Size(171, 26);
            this.刷新ToolStripMenuItem4.Text = "刷新";
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.返回ToolStripMenuItem.Text = "返回";
            // 
            // 监控列表ToolStripMenuItem
            // 
            this.监控列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem5,
            this.刷新ToolStripMenuItem5,
            this.返回ToolStripMenuItem1});
            this.监控列表ToolStripMenuItem.Name = "监控列表ToolStripMenuItem";
            this.监控列表ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.监控列表ToolStripMenuItem.Text = "监控列表";
            // 
            // 打开ToolStripMenuItem5
            // 
            this.打开ToolStripMenuItem5.Name = "打开ToolStripMenuItem5";
            this.打开ToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.打开ToolStripMenuItem5.Size = new System.Drawing.Size(186, 26);
            this.打开ToolStripMenuItem5.Text = "打开";
            // 
            // 刷新ToolStripMenuItem5
            // 
            this.刷新ToolStripMenuItem5.Name = "刷新ToolStripMenuItem5";
            this.刷新ToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.刷新ToolStripMenuItem5.Size = new System.Drawing.Size(186, 26);
            this.刷新ToolStripMenuItem5.Text = "刷新";
            // 
            // 返回ToolStripMenuItem1
            // 
            this.返回ToolStripMenuItem1.Name = "返回ToolStripMenuItem1";
            this.返回ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.返回ToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.返回ToolStripMenuItem1.Text = "返回";
            // 
            // 多窗口监控ToolStripMenuItem
            // 
            this.多窗口监控ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem6,
            this.刷新ToolStripMenuItem6,
            this.返回ToolStripMenuItem2});
            this.多窗口监控ToolStripMenuItem.Name = "多窗口监控ToolStripMenuItem";
            this.多窗口监控ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.多窗口监控ToolStripMenuItem.Text = "多窗口监控";
            // 
            // 打开ToolStripMenuItem6
            // 
            this.打开ToolStripMenuItem6.Name = "打开ToolStripMenuItem6";
            this.打开ToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.打开ToolStripMenuItem6.Size = new System.Drawing.Size(177, 26);
            this.打开ToolStripMenuItem6.Text = "打开";
            // 
            // 刷新ToolStripMenuItem6
            // 
            this.刷新ToolStripMenuItem6.Name = "刷新ToolStripMenuItem6";
            this.刷新ToolStripMenuItem6.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.刷新ToolStripMenuItem6.Size = new System.Drawing.Size(177, 26);
            this.刷新ToolStripMenuItem6.Text = "刷新";
            // 
            // 返回ToolStripMenuItem2
            // 
            this.返回ToolStripMenuItem2.Name = "返回ToolStripMenuItem2";
            this.返回ToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.返回ToolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.返回ToolStripMenuItem2.Text = "返回";
            // 
            // 电子地图ToolStripMenuItem
            // 
            this.电子地图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.标记ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.电子地图ToolStripMenuItem.Name = "电子地图ToolStripMenuItem";
            this.电子地图ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.电子地图ToolStripMenuItem.Text = "电子地图";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 标记ToolStripMenuItem
            // 
            this.标记ToolStripMenuItem.Name = "标记ToolStripMenuItem";
            this.标记ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.标记ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.标记ToolStripMenuItem.Text = "标记";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 一键报警ToolStripMenuItem
            // 
            this.一键报警ToolStripMenuItem.Name = "一键报警ToolStripMenuItem";
            this.一键报警ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.一键报警ToolStripMenuItem.Text = "一键报警";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::twpx.Properties.Resources.timg__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 640);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "杭电智慧实验室监控系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电子地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设备管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 监控管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 主页面监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多窗口监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 一键报警ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

