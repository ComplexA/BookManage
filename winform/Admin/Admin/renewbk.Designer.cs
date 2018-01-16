namespace Admin
{
    partial class renewbk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(renewbk));
            this.btrn = new System.Windows.Forms.Button();
            this.txtrn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ridcp = new System.Windows.Forms.Label();
            this.lddtcp = new System.Windows.Forms.Label();
            this.rndtcp = new System.Windows.Forms.Label();
            this.rid = new System.Windows.Forms.Label();
            this.lenddt = new System.Windows.Forms.Label();
            this.rndt = new System.Windows.Forms.Label();
            this.rn = new System.Windows.Forms.Label();
            this.rncp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btrn
            // 
            this.btrn.Location = new System.Drawing.Point(88, 167);
            this.btrn.Name = "btrn";
            this.btrn.Size = new System.Drawing.Size(75, 23);
            this.btrn.TabIndex = 5;
            this.btrn.Text = "续借";
            this.btrn.UseVisualStyleBackColor = true;
            this.btrn.Click += new System.EventHandler(this.btrn_Click);
            // 
            // txtrn
            // 
            this.txtrn.Location = new System.Drawing.Point(108, 22);
            this.txtrn.Name = "txtrn";
            this.txtrn.Size = new System.Drawing.Size(129, 21);
            this.txtrn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "图书编码";
            // 
            // ridcp
            // 
            this.ridcp.AutoSize = true;
            this.ridcp.Location = new System.Drawing.Point(33, 54);
            this.ridcp.Name = "ridcp";
            this.ridcp.Size = new System.Drawing.Size(53, 12);
            this.ridcp.TabIndex = 6;
            this.ridcp.Text = "读者编码";
            // 
            // lddtcp
            // 
            this.lddtcp.AutoSize = true;
            this.lddtcp.Location = new System.Drawing.Point(33, 83);
            this.lddtcp.Name = "lddtcp";
            this.lddtcp.Size = new System.Drawing.Size(53, 12);
            this.lddtcp.TabIndex = 7;
            this.lddtcp.Text = "借书日期";
            // 
            // rndtcp
            // 
            this.rndtcp.AutoSize = true;
            this.rndtcp.Location = new System.Drawing.Point(27, 112);
            this.rndtcp.Name = "rndtcp";
            this.rndtcp.Size = new System.Drawing.Size(65, 12);
            this.rndtcp.TabIndex = 8;
            this.rndtcp.Text = "原还书日期";
            // 
            // rid
            // 
            this.rid.AutoSize = true;
            this.rid.Location = new System.Drawing.Point(106, 54);
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(41, 12);
            this.rid.TabIndex = 9;
            this.rid.Text = "label2";
            // 
            // lenddt
            // 
            this.lenddt.AutoSize = true;
            this.lenddt.Location = new System.Drawing.Point(106, 83);
            this.lenddt.Name = "lenddt";
            this.lenddt.Size = new System.Drawing.Size(41, 12);
            this.lenddt.TabIndex = 10;
            this.lenddt.Text = "label3";
            // 
            // rndt
            // 
            this.rndt.AutoSize = true;
            this.rndt.Location = new System.Drawing.Point(106, 112);
            this.rndt.Name = "rndt";
            this.rndt.Size = new System.Drawing.Size(41, 12);
            this.rndt.TabIndex = 11;
            this.rndt.Text = "label4";
            // 
            // rn
            // 
            this.rn.AutoSize = true;
            this.rn.Location = new System.Drawing.Point(106, 140);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(41, 12);
            this.rn.TabIndex = 13;
            this.rn.Text = "label4";
            // 
            // rncp
            // 
            this.rncp.AutoSize = true;
            this.rncp.Location = new System.Drawing.Point(39, 140);
            this.rncp.Name = "rncp";
            this.rncp.Size = new System.Drawing.Size(41, 12);
            this.rncp.TabIndex = 12;
            this.rncp.Text = "已续借";
            // 
            // renewbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.rn);
            this.Controls.Add(this.rncp);
            this.Controls.Add(this.rndt);
            this.Controls.Add(this.lenddt);
            this.Controls.Add(this.rid);
            this.Controls.Add(this.rndtcp);
            this.Controls.Add(this.lddtcp);
            this.Controls.Add(this.ridcp);
            this.Controls.Add(this.btrn);
            this.Controls.Add(this.txtrn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "renewbk";
            this.Text = "续借";
            this.Load += new System.EventHandler(this.renewbk_Load);
            this.Click += new System.EventHandler(this.renewbk_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btrn;
        private System.Windows.Forms.TextBox txtrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ridcp;
        private System.Windows.Forms.Label lddtcp;
        private System.Windows.Forms.Label rndtcp;
        private System.Windows.Forms.Label rid;
        private System.Windows.Forms.Label lenddt;
        private System.Windows.Forms.Label rndt;
        private System.Windows.Forms.Label rn;
        private System.Windows.Forms.Label rncp;
    }
}