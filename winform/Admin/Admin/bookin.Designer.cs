namespace Admin
{
    partial class bookin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.btdpl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfloor = new System.Windows.Forms.TextBox();
            this.txtrow = new System.Windows.Forms.TextBox();
            this.txtshelf = new System.Windows.Forms.TextBox();
            this.txtdpt = new System.Windows.Forms.TextBox();
            this.txtpress = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtwriter = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcaseID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vnumup = new System.Windows.Forms.NumericUpDown();
            this.vindata = new System.Windows.Forms.DataGridView();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvwriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btbookin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnumup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vindata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN：";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(74, 6);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(203, 21);
            this.txtisbn.TabIndex = 1;
            // 
            // btdpl
            // 
            this.btdpl.Location = new System.Drawing.Point(370, 4);
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
            this.label2.Text = "图书编码：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtfloor);
            this.panel1.Controls.Add(this.txtrow);
            this.panel1.Controls.Add(this.txtshelf);
            this.panel1.Controls.Add(this.txtdpt);
            this.panel1.Controls.Add(this.txtpress);
            this.panel1.Controls.Add(this.txtclass);
            this.panel1.Controls.Add(this.txtwriter);
            this.panel1.Controls.Add(this.txtpub);
            this.panel1.Controls.Add(this.txtcname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcaseID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 145);
            this.panel1.TabIndex = 4;
            // 
            // txtfloor
            // 
            this.txtfloor.Location = new System.Drawing.Point(358, 115);
            this.txtfloor.Name = "txtfloor";
            this.txtfloor.Size = new System.Drawing.Size(100, 21);
            this.txtfloor.TabIndex = 22;
            // 
            // txtrow
            // 
            this.txtrow.Location = new System.Drawing.Point(62, 115);
            this.txtrow.Name = "txtrow";
            this.txtrow.Size = new System.Drawing.Size(135, 21);
            this.txtrow.TabIndex = 21;
            // 
            // txtshelf
            // 
            this.txtshelf.Location = new System.Drawing.Point(358, 88);
            this.txtshelf.Name = "txtshelf";
            this.txtshelf.Size = new System.Drawing.Size(100, 21);
            this.txtshelf.TabIndex = 20;
            // 
            // txtdpt
            // 
            this.txtdpt.Location = new System.Drawing.Point(62, 88);
            this.txtdpt.Name = "txtdpt";
            this.txtdpt.Size = new System.Drawing.Size(135, 21);
            this.txtdpt.TabIndex = 19;
            // 
            // txtpress
            // 
            this.txtpress.Location = new System.Drawing.Point(62, 61);
            this.txtpress.Name = "txtpress";
            this.txtpress.Size = new System.Drawing.Size(135, 21);
            this.txtpress.TabIndex = 18;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(358, 61);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(100, 21);
            this.txtclass.TabIndex = 17;
            // 
            // txtwriter
            // 
            this.txtwriter.Location = new System.Drawing.Point(62, 34);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(135, 21);
            this.txtwriter.TabIndex = 16;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(358, 34);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(100, 21);
            this.txtpub.TabIndex = 15;
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(358, 7);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(100, 21);
            this.txtcname.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "层号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "作者：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "出版日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "典藏部门：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "分类号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "排号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "架号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "出版社：";
            // 
            // txtcaseID
            // 
            this.txtcaseID.Location = new System.Drawing.Point(62, 7);
            this.txtcaseID.Name = "txtcaseID";
            this.txtcaseID.Size = new System.Drawing.Size(135, 21);
            this.txtcaseID.TabIndex = 4;
            this.txtcaseID.Leave += new System.EventHandler(this.txtcaseID_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "册数：";
            // 
            // vnumup
            // 
            this.vnumup.Location = new System.Drawing.Point(65, 190);
            this.vnumup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vnumup.Name = "vnumup";
            this.vnumup.Size = new System.Drawing.Size(90, 21);
            this.vnumup.TabIndex = 6;
            this.vnumup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vnumup.ValueChanged += new System.EventHandler(this.vnumup_ValueChanged);
            // 
            // vindata
            // 
            this.vindata.AllowUserToAddRows = false;
            this.vindata.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.vindata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vindata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvname,
            this.dgdivision,
            this.dgvwriter,
            this.dgtopic});
            this.vindata.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vindata.Location = new System.Drawing.Point(12, 226);
            this.vindata.Name = "vindata";
            this.vindata.RowTemplate.Height = 23;
            this.vindata.Size = new System.Drawing.Size(484, 185);
            this.vindata.TabIndex = 7;
            // 
            // dgvname
            // 
            this.dgvname.HeaderText = "册号";
            this.dgvname.Name = "dgvname";
            this.dgvname.Width = 75;
            // 
            // dgdivision
            // 
            this.dgdivision.HeaderText = "分书名";
            this.dgdivision.Name = "dgdivision";
            // 
            // dgvwriter
            // 
            this.dgvwriter.HeaderText = "分书著者";
            this.dgvwriter.Name = "dgvwriter";
            // 
            // dgtopic
            // 
            this.dgtopic.HeaderText = "主题词";
            this.dgtopic.Name = "dgtopic";
            this.dgtopic.Width = 165;
            // 
            // btbookin
            // 
            this.btbookin.Location = new System.Drawing.Point(198, 426);
            this.btbookin.Name = "btbookin";
            this.btbookin.Size = new System.Drawing.Size(100, 23);
            this.btbookin.TabIndex = 8;
            this.btbookin.Text = "确认录入";
            this.btbookin.UseVisualStyleBackColor = true;
            this.btbookin.Click += new System.EventHandler(this.btbookin_Click);
            // 
            // bookin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 461);
            this.Controls.Add(this.btbookin);
            this.Controls.Add(this.vindata);
            this.Controls.Add(this.vnumup);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btdpl);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookin";
            this.Text = "图书录入";
            this.Load += new System.EventHandler(this.bookin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnumup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vindata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Button btdpl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfloor;
        private System.Windows.Forms.TextBox txtrow;
        private System.Windows.Forms.TextBox txtshelf;
        private System.Windows.Forms.TextBox txtdpt;
        private System.Windows.Forms.TextBox txtpress;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtwriter;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcaseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown vnumup;
        private System.Windows.Forms.DataGridView vindata;
        private System.Windows.Forms.Button btbookin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvwriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtopic;
    }
}