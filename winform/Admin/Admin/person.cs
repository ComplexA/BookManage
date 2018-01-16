using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class person : Form
    {
        public person()
        {
            InitializeComponent();
        }

        private void person_Load(object sender, EventArgs e)
        {
            userid.Text = UserPublic.userInfo[0];
            usernm.Text = UserPublic.userInfo[1];
            txtpwd.Text = UserPublic.userInfo[2];


        }

        private void chgname_Click(object sender, EventArgs e)
        {
            if (chgname.Text == "修改")
            {
                usernm.ReadOnly = false;
                chgname.Text = "确定";
            }
            else if (chgname.Text == "确定")
            {
                if (usernm.Text.Trim() == "")
                {
                    MessageBox.Show("不能为空！");
                    return;
                }

                string sqlupnm = "update admin set adminName='"+usernm.Text.Trim()
                    +"' where adminID='"+UserPublic.userInfo[0]+"'";
                Cdatabase.UpdateDB(sqlupnm);
                usernm.ReadOnly = true;
                chgname.Text = "修改";
            }
        }

        private void chgpwd_Click(object sender, EventArgs e)
        {
            if (chgpwd.Text == "修改")
            {
                txtpwd.ReadOnly = false;
                chgpwd.Text = "确定";
                txtpwd.PasswordChar = new char();
            }
            else if (chgpwd.Text == "确定")
            {
                if (txtpwd.Text.Trim() == "")
                {
                    MessageBox.Show("不能为空！");
                    return;
                }

                txtpwd.PasswordChar = '*';
                string sqluppwd = "update admin set adminPwd='" + txtpwd.Text.Trim()
                    + "' where adminID='" + UserPublic.userInfo[0] + "'";
                Cdatabase.UpdateDB(sqluppwd);
                txtpwd.ReadOnly = true;
                chgpwd.Text = "修改";
            }
        }
    }
}
