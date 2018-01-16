using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (uname.Text == "" || upwd.Text == "")
                MessageBox.Show("用户名和密码不能为空");
            else 
            {
                this.Text = "正在验证...";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                string sqlStr = "select * from admin where adminID='" + uname.Text.Trim() + "'";
                DataSet ds = new DataSet();
                Cdatabase.conn.ConnectionString = Cdatabase.connStr;
                Cdatabase.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Cdatabase.conn);
                adapter.Fill(ds);
                Cdatabase.conn.Close();
                if (!(ds.Tables[0].Rows.Count == 0))
                {
                    string sqlad = "select * from admin where adminID='" + uname.Text.Trim() + "'";
                    DataSet ad = Cdatabase.GetDataFromDB(sqlad);
                    if (ad != null)
                    {
                        if (ad.Tables[0].Rows[0]["adminPwd"].ToString() == upwd.Text.ToString())
                        {
                            UserPublic.userInfo[0] = uname.Text.Trim();
                            UserPublic.userInfo[1] = ad.Tables[0].Rows[0]["adminName"].ToString();
                            UserPublic.userInfo[2] = ad.Tables[0].Rows[0]["adminPwd"].ToString();

                            this.Hide();
                            mainForm adm = new mainForm();
                            adm.Show();
                        }
                        else 
                        {
                            MessageBox.Show("密码错误,请重新输入!", "错误");
                            this.Cursor = System.Windows.Forms.Cursors.Arrow;
                            this.Text = "登录";
                            //uname.Text = "";
                            upwd.Text = "";
                            uname.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名错误,请重新输入!", "错误");
                        this.Cursor = System.Windows.Forms.Cursors.Arrow;
                        this.Text = "登录";
                        uname.Text = "";
                        upwd.Text = "";
                        uname.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("用户名不存在", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    uname.Text = "";
                    upwd.Text = "";
                    uname.Focus();
                }
            }

        }

        
    }
}
