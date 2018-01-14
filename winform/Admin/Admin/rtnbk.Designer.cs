namespace Admin
{
    partial class rtnbk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtnbk));
            this.label1 = new System.Windows.Forms.Label();
            this.txtrtn = new System.Windows.Forms.TextBox();
            this.btrtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编码";
            // 
            // txtrtn
            // 
            this.txtrtn.Location = new System.Drawing.Point(126, 60);
            this.txtrtn.Name = "txtrtn";
            this.txtrtn.Size = new System.Drawing.Size(129, 21);
            this.txtrtn.TabIndex = 1;
            // 
            // btrtn
            // 
            this.btrtn.Location = new System.Drawing.Point(105, 103);
            this.btrtn.Name = "btrtn";
            this.btrtn.Size = new System.Drawing.Size(75, 23);
            this.btrtn.TabIndex = 2;
            this.btrtn.Text = "还书";
            this.btrtn.UseVisualStyleBackColor = true;
            this.btrtn.Click += new System.EventHandler(this.btrtn_Click);
            // 
            // rtnbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.btrtn);
            this.Controls.Add(this.txtrtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rtnbk";
            this.Text = "还书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrtn;
        private System.Windows.Forms.Button btrtn;
    }
}