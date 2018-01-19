namespace Admin
{
    partial class editvlm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editvlm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvid = new System.Windows.Forms.TextBox();
            this.txtdivision = new System.Windows.Forms.TextBox();
            this.txtvwriter = new System.Windows.Forms.TextBox();
            this.txttopic = new System.Windows.Forms.TextBox();
            this.btedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "册号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "分书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "分书著者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "主题词";
            // 
            // txtvid
            // 
            this.txtvid.Location = new System.Drawing.Point(113, 43);
            this.txtvid.Name = "txtvid";
            this.txtvid.ReadOnly = true;
            this.txtvid.Size = new System.Drawing.Size(100, 21);
            this.txtvid.TabIndex = 4;
            // 
            // txtdivision
            // 
            this.txtdivision.Location = new System.Drawing.Point(113, 80);
            this.txtdivision.Name = "txtdivision";
            this.txtdivision.Size = new System.Drawing.Size(100, 21);
            this.txtdivision.TabIndex = 5;
            // 
            // txtvwriter
            // 
            this.txtvwriter.Location = new System.Drawing.Point(113, 117);
            this.txtvwriter.Name = "txtvwriter";
            this.txtvwriter.Size = new System.Drawing.Size(100, 21);
            this.txtvwriter.TabIndex = 6;
            // 
            // txttopic
            // 
            this.txttopic.Location = new System.Drawing.Point(96, 154);
            this.txttopic.Multiline = true;
            this.txttopic.Name = "txttopic";
            this.txttopic.Size = new System.Drawing.Size(140, 85);
            this.txttopic.TabIndex = 7;
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(82, 263);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 23);
            this.btedit.TabIndex = 8;
            this.btedit.Text = "确认修改";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // editvlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 315);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.txttopic);
            this.Controls.Add(this.txtvwriter);
            this.Controls.Add(this.txtdivision);
            this.Controls.Add(this.txtvid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editvlm";
            this.Text = "修改册的信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvid;
        private System.Windows.Forms.TextBox txtdivision;
        private System.Windows.Forms.TextBox txtvwriter;
        private System.Windows.Forms.TextBox txttopic;
        private System.Windows.Forms.Button btedit;
    }
}