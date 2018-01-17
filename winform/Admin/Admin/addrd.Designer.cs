namespace Admin
{
    partial class addrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addrd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtrdid = new System.Windows.Forms.TextBox();
            this.btdpl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtrddpt = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrdName = new System.Windows.Forms.TextBox();
            this.btaddrd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lablemonth = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者号：";
            // 
            // txtrdid
            // 
            this.txtrdid.Location = new System.Drawing.Point(74, 6);
            this.txtrdid.Name = "txtrdid";
            this.txtrdid.Size = new System.Drawing.Size(135, 21);
            this.txtrdid.TabIndex = 1;
            // 
            // btdpl
            // 
            this.btdpl.Location = new System.Drawing.Point(294, 4);
            this.btdpl.Name = "btdpl";
            this.btdpl.Size = new System.Drawing.Size(75, 23);
            this.btdpl.TabIndex = 2;
            this.btdpl.Text = "查重";
            this.btdpl.UseVisualStyleBackColor = true;
            this.btdpl.Click += new System.EventHandler(this.btdpl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "读者姓名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.lablemonth);
            this.panel1.Controls.Add(this.txtMonth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtrddpt);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtrdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 135);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(62, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "男";
            // 
            // txtrddpt
            // 
            this.txtrddpt.Location = new System.Drawing.Point(62, 34);
            this.txtrddpt.Name = "txtrddpt";
            this.txtrddpt.Size = new System.Drawing.Size(135, 21);
            this.txtrddpt.TabIndex = 16;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(62, 61);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(37, 21);
            this.txtYear.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "所在学院：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "性    别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生日期：";
            // 
            // txtrdName
            // 
            this.txtrdName.Location = new System.Drawing.Point(62, 7);
            this.txtrdName.Name = "txtrdName";
            this.txtrdName.Size = new System.Drawing.Size(135, 21);
            this.txtrdName.TabIndex = 4;
            this.txtrdName.Leave += new System.EventHandler(this.txtcaseID_Leave);
            // 
            // btaddrd
            // 
            this.btaddrd.Location = new System.Drawing.Point(177, 229);
            this.btaddrd.Name = "btaddrd";
            this.btaddrd.Size = new System.Drawing.Size(100, 23);
            this.btaddrd.TabIndex = 8;
            this.btaddrd.Text = "确认添加";
            this.btaddrd.UseVisualStyleBackColor = true;
            this.btaddrd.Click += new System.EventHandler(this.btbookin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "年";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(128, 61);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(37, 21);
            this.txtMonth.TabIndex = 19;
            // 
            // lablemonth
            // 
            this.lablemonth.AutoSize = true;
            this.lablemonth.Location = new System.Drawing.Point(171, 64);
            this.lablemonth.Name = "lablemonth";
            this.lablemonth.Size = new System.Drawing.Size(17, 12);
            this.lablemonth.TabIndex = 20;
            this.lablemonth.Text = "月";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(194, 61);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(37, 21);
            this.txtDay.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "日";
            // 
            // addrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 305);
            this.Controls.Add(this.btaddrd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btdpl);
            this.Controls.Add(this.txtrdid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addrd";
            this.Text = "新增读者";
            this.Load += new System.EventHandler(this.bookin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrdid;
        private System.Windows.Forms.Button btdpl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtrddpt;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrdName;
        private System.Windows.Forms.Button btaddrd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lablemonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label5;
    }
}