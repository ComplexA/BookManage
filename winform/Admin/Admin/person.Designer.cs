namespace Admin
{
    partial class person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(person));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.chgpwd = new System.Windows.Forms.Button();
            this.chgname = new System.Windows.Forms.Button();
            this.usernm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(85, 58);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(41, 12);
            this.userid.TabIndex = 3;
            this.userid.Text = "label4";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(85, 151);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.ReadOnly = true;
            this.txtpwd.Size = new System.Drawing.Size(100, 21);
            this.txtpwd.TabIndex = 5;
            // 
            // chgpwd
            // 
            this.chgpwd.Location = new System.Drawing.Point(200, 149);
            this.chgpwd.Name = "chgpwd";
            this.chgpwd.Size = new System.Drawing.Size(60, 23);
            this.chgpwd.TabIndex = 6;
            this.chgpwd.Text = "修改";
            this.chgpwd.UseVisualStyleBackColor = true;
            this.chgpwd.Click += new System.EventHandler(this.chgpwd_Click);
            // 
            // chgname
            // 
            this.chgname.Location = new System.Drawing.Point(200, 106);
            this.chgname.Name = "chgname";
            this.chgname.Size = new System.Drawing.Size(60, 23);
            this.chgname.TabIndex = 7;
            this.chgname.Text = "修改";
            this.chgname.UseVisualStyleBackColor = true;
            this.chgname.Click += new System.EventHandler(this.chgname_Click);
            // 
            // usernm
            // 
            this.usernm.Location = new System.Drawing.Point(85, 108);
            this.usernm.Name = "usernm";
            this.usernm.ReadOnly = true;
            this.usernm.Size = new System.Drawing.Size(100, 21);
            this.usernm.TabIndex = 8;
            // 
            // person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.usernm);
            this.Controls.Add(this.chgname);
            this.Controls.Add(this.chgpwd);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "person";
            this.Text = "个人管理";
            this.Load += new System.EventHandler(this.person_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button chgpwd;
        private System.Windows.Forms.Button chgname;
        private System.Windows.Forms.TextBox usernm;
    }
}