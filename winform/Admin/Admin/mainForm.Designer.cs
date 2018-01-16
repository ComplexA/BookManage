namespace Admin
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tButton1 = new System.Windows.Forms.ToolStripButton();
            this.tButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.查看所有图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.添加读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看所有读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.续借ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有借阅信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tButton1,
            this.tButton2,
            this.tButton3,
            this.tButton4,
            this.tButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tButton1
            // 
            this.tButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tButton1.Image = ((System.Drawing.Image)(resources.GetObject("tButton1.Image")));
            this.tButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tButton1.Name = "tButton1";
            this.tButton1.Size = new System.Drawing.Size(60, 22);
            this.tButton1.Text = "图书录入";
            this.tButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tButton2
            // 
            this.tButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看所有图书ToolStripMenuItem,
            this.图书查询ToolStripMenuItem});
            this.tButton2.Image = ((System.Drawing.Image)(resources.GetObject("tButton2.Image")));
            this.tButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tButton2.Name = "tButton2";
            this.tButton2.Size = new System.Drawing.Size(72, 22);
            this.tButton2.Text = "图书管理";
            // 
            // 查看所有图书ToolStripMenuItem
            // 
            this.查看所有图书ToolStripMenuItem.Name = "查看所有图书ToolStripMenuItem";
            this.查看所有图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看所有图书ToolStripMenuItem.Text = "查看所有图书";
            this.查看所有图书ToolStripMenuItem.Click += new System.EventHandler(this.查看所有图书ToolStripMenuItem_Click);
            // 
            // 图书查询ToolStripMenuItem
            // 
            this.图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            this.图书查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书查询ToolStripMenuItem.Text = "图书查询";
            this.图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书查询ToolStripMenuItem_Click);
            // 
            // tButton3
            // 
            this.tButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者ToolStripMenuItem,
            this.查询读者ToolStripMenuItem,
            this.查看所有读者ToolStripMenuItem});
            this.tButton3.Image = ((System.Drawing.Image)(resources.GetObject("tButton3.Image")));
            this.tButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tButton3.Name = "tButton3";
            this.tButton3.Size = new System.Drawing.Size(72, 22);
            this.tButton3.Text = "读者管理";
            // 
            // 添加读者ToolStripMenuItem
            // 
            this.添加读者ToolStripMenuItem.Name = "添加读者ToolStripMenuItem";
            this.添加读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加读者ToolStripMenuItem.Text = "添加读者";
            this.添加读者ToolStripMenuItem.Click += new System.EventHandler(this.添加读者ToolStripMenuItem_Click);
            // 
            // 查询读者ToolStripMenuItem
            // 
            this.查询读者ToolStripMenuItem.Name = "查询读者ToolStripMenuItem";
            this.查询读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询读者ToolStripMenuItem.Text = "查询读者";
            this.查询读者ToolStripMenuItem.Click += new System.EventHandler(this.查询读者ToolStripMenuItem_Click);
            // 
            // 查看所有读者ToolStripMenuItem
            // 
            this.查看所有读者ToolStripMenuItem.Name = "查看所有读者ToolStripMenuItem";
            this.查看所有读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看所有读者ToolStripMenuItem.Text = "查看所有读者";
            this.查看所有读者ToolStripMenuItem.Click += new System.EventHandler(this.查看所有读者ToolStripMenuItem_Click);
            // 
            // tButton4
            // 
            this.tButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem,
            this.续借ToolStripMenuItem,
            this.所有借阅信息ToolStripMenuItem});
            this.tButton4.Image = ((System.Drawing.Image)(resources.GetObject("tButton4.Image")));
            this.tButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tButton4.Name = "tButton4";
            this.tButton4.Size = new System.Drawing.Size(72, 22);
            this.tButton4.Text = "借阅管理";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 续借ToolStripMenuItem
            // 
            this.续借ToolStripMenuItem.Name = "续借ToolStripMenuItem";
            this.续借ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.续借ToolStripMenuItem.Text = "续借";
            this.续借ToolStripMenuItem.Click += new System.EventHandler(this.续借ToolStripMenuItem_Click);
            // 
            // 所有借阅信息ToolStripMenuItem
            // 
            this.所有借阅信息ToolStripMenuItem.Name = "所有借阅信息ToolStripMenuItem";
            this.所有借阅信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.所有借阅信息ToolStripMenuItem.Text = "所有借阅信息";
            this.所有借阅信息ToolStripMenuItem.Click += new System.EventHandler(this.所有借阅信息ToolStripMenuItem_Click);
            // 
            // tButton5
            // 
            this.tButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tButton5.Image = ((System.Drawing.Image)(resources.GetObject("tButton5.Image")));
            this.tButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tButton5.Name = "tButton5";
            this.tButton5.Size = new System.Drawing.Size(60, 22);
            this.tButton5.Text = "个人管理";
            this.tButton5.Click += new System.EventHandler(this.tButton5_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 635);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Text = "古籍图书管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tButton1;
        private System.Windows.Forms.ToolStripSplitButton tButton2;
        private System.Windows.Forms.ToolStripSplitButton tButton3;
        private System.Windows.Forms.ToolStripSplitButton tButton4;
        private System.Windows.Forms.ToolStripButton tButton5;
        private System.Windows.Forms.ToolStripMenuItem 查看所有图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看所有读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 续借ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有借阅信息ToolStripMenuItem;


    }
}

