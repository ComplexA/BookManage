namespace Admin
{
    partial class lendbk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lendbk));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlendcid = new System.Windows.Forms.TextBox();
            this.txtlendrid = new System.Windows.Forms.TextBox();
            this.btlend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "读者号";
            // 
            // txtlendcid
            // 
            this.txtlendcid.Location = new System.Drawing.Point(111, 44);
            this.txtlendcid.Name = "txtlendcid";
            this.txtlendcid.Size = new System.Drawing.Size(100, 21);
            this.txtlendcid.TabIndex = 2;
            // 
            // txtlendrid
            // 
            this.txtlendrid.Location = new System.Drawing.Point(111, 103);
            this.txtlendrid.Name = "txtlendrid";
            this.txtlendrid.Size = new System.Drawing.Size(100, 21);
            this.txtlendrid.TabIndex = 3;
            // 
            // btlend
            // 
            this.btlend.Location = new System.Drawing.Point(67, 154);
            this.btlend.Name = "btlend";
            this.btlend.Size = new System.Drawing.Size(75, 23);
            this.btlend.TabIndex = 4;
            this.btlend.Text = "借阅";
            this.btlend.UseVisualStyleBackColor = true;
            this.btlend.Click += new System.EventHandler(this.btlend_Click);
            // 
            // lendbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 240);
            this.Controls.Add(this.btlend);
            this.Controls.Add(this.txtlendrid);
            this.Controls.Add(this.txtlendcid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lendbk";
            this.Text = "借书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlendcid;
        private System.Windows.Forms.TextBox txtlendrid;
        private System.Windows.Forms.Button btlend;
    }
}